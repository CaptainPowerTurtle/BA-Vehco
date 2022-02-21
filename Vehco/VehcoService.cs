using Apache.NMS;
using AutoMapper;
using Vecho.Consumer.Model.General;
using Vehco.Consumer.Converter;
using Vehco.Consumer.Messaging;
using Vehco.Domain.Models.DRTEvent;
using Vehco.Repository.Interfaces;
using Vehco.Repository.Models.DRTEvent;
using Vehco.Repository.Models.General;

namespace Vehco.Consumer;

public class VehcoService : IVehcoService
{
    private PersistentConnection _persistentConnection;
    private IMessageConsumer _consumer;
    private IUnitOfWork _unitOfWork;
    public readonly IMapper _mapper;
    protected static ITextMessage? _message;
    public VehcoService(PersistentConnection persistentConnection, IUnitOfWork unitOfWork, IMapper mapper)
    {
        _persistentConnection = persistentConnection;
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }
    public async Task GetDRTEventService(CancellationToken ct)
    {
        string queue = "DrtEvents";
        InitializeListener(queue);
        await Task.Delay(10000, ct);
    }
    private void InitializeListener(string queue)
    {
        _consumer = _persistentConnection.CreateConsumer(queue + "?consumer.prefetchSize=10");
        _consumer.Listener += new MessageListener(OnMessage);
        //while (true)
        //{
        //    _message = _consumer.Receive() as ITextMessage;
        //    //ITextMessage message = _consumer.Receive() as ITextMessage;
        //    if (_message == null)
        //    {
        //        Console.WriteLine("Waiting for message");
        //    }

        //    Console.WriteLine("Received message with ID:   " + _message.NMSCorrelationID);
        //}
    }

    protected void OnMessage(IMessage receivedMsg)
    {
        var watch = System.Diagnostics.Stopwatch.StartNew();
        _message = receivedMsg as ITextMessage;
        DRTEventEnvelopeDTO drtEventEnvelope = XmlHelper.FromStringToXml<DRTEventEnvelopeDTO>(_message.Text);
        string envelopeId = Guid.NewGuid().ToString();

        DRTEventEnvelope envelope = new DRTEventEnvelope();
        envelope.EnvelopeId = envelopeId;

        _unitOfWork.DrtEventEnvelopeRepository.Add(envelope);

        for (int events = 0; events < drtEventEnvelope.DRTEvent.Count(); events++)
        {
            AddDRTEvent(drtEventEnvelope, envelopeId, events);

        }
        _unitOfWork.Complete();
        Console.WriteLine($"Inserted {_message.NMSCorrelationID} into database in {watch.ElapsedMilliseconds} from queue {_message.NMSDestination.ToString()}");
        _message.Acknowledge();

    }

    private void AddDRTEvent(DRTEventEnvelopeDTO eventEnvelope, string envelopeId, int index)
    {
        string eventId = Guid.NewGuid().ToString();
        string eventTypeId = Guid.NewGuid().ToString();
        if (eventEnvelope.DRTEvent[index].Item.GetType() == typeof(TachographEventDTO))
        {
            TachographEventDTO tachographEvent = (TachographEventDTO)Convert.ChangeType(eventEnvelope.DRTEvent[index].Item, typeof(TachographEventDTO));
            AddOrIgnoreUserInDB(tachographEvent.User);

            AddUpdateOrIgnoreVehicleInDB(tachographEvent.Vehicle);

            var informationId = AddTachographInformationInDB(tachographEvent.TachographInformation);

            var positionId = AddPositionInDB(tachographEvent.Position);

            AddTachographEventInDB(tachographEvent, eventTypeId, informationId, positionId);

            DRTEvent drtEvent = new DRTEvent();

            drtEvent.EnvelopeId = envelopeId;
            drtEvent.EventTypeId = eventTypeId;
            drtEvent.EventId = eventId;
            //var mappedDrtEvent = _mapper.Map<DRTEvent>(eventEnvelope.DRTEvent);
            //mappedDrtEvent.EnvelopeId = envelopeId;
            //mappedDrtEvent.EventTypeId = eventTypeId;
            //mappedDrtEvent.EventId = eventId;

            _unitOfWork.DrtEventRepository.Add(drtEvent);
        }
    }

    private void AddOrIgnoreUserInDB(DriverDTO driver)
    {
        var mappedDriver = _mapper.Map<Driver>(driver);
        _unitOfWork.DriverRepository.Add(mappedDriver);
    }

    private void AddUpdateOrIgnoreVehicleInDB(VehicleIdDTO vehicle)
    {
        var mappedVehicle = _mapper.Map<Vehicle>(vehicle);

        _unitOfWork.VehicleRepository.Add(mappedVehicle);

    }

    private string AddTachographInformationInDB(TachographInformationDTO tachographInformation)
    {
        string informationId = Guid.NewGuid().ToString();
        AddUpdateOrIgnoreCardInDB(tachographInformation.Card);
        var mappedTachographInformation = _mapper.Map<TachographInformation>(tachographInformation);
        mappedTachographInformation.InformationId = informationId;
        _unitOfWork.TachographInformationRepository.Add(mappedTachographInformation);

        return informationId;
    }

    private void AddUpdateOrIgnoreCardInDB(CardDTO card)
    {
        if (!string.IsNullOrEmpty(card.CardId))
        {
            var mappedCard = _mapper.Map<Card>(card);

            _unitOfWork.CardRepository.Add(mappedCard);
        }
    }

    private string AddPositionInDB(PositionDTO position)
    {
        string positionId = Guid.NewGuid().ToString();

        var mappedPosition = _mapper.Map<Position>(position);
        mappedPosition.PositionId = positionId;
        _unitOfWork.PositionRepository.Add(mappedPosition);
        return positionId;
    }

    private void AddTachographEventInDB(TachographEventDTO tachographEvent, string eventTypeId, string informationId,
        string positionId)
    {
        var mappedTachographEvent = _mapper.Map<TachographEvent>(tachographEvent);

        mappedTachographEvent.EventTypeId = eventTypeId;
        mappedTachographEvent.InformationId = informationId;
        mappedTachographEvent.PositionId = positionId;

        _unitOfWork.TachographEventRepository.Add(mappedTachographEvent);
    }
}