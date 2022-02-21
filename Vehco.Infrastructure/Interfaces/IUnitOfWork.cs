
using Vehco.Repository.Interfaces.DRTEvent;
using Vehco.Repository.Interfaces.General;

namespace Vehco.Repository.Interfaces;

public interface IUnitOfWork : IDisposable
{
    ICardRepository CardRepository { get; }
    IDrtEventEnvelopeRepository DrtEventEnvelopeRepository { get; }
    IDrtEventRepository DrtEventRepository { get; }
    ITachographActivityPeriodRepository TachographActivityPeriodRepository { get; }
    ITachographEventRepository TachographEventRepository { get; }
    ITachographInformationRepository TachographInformationRepository { get; }
    IDriverRepository DriverRepository { get; }
    IPositionRepository PositionRepository { get; }
    IVehicleRepository VehicleRepository { get; }
    int Complete();
}