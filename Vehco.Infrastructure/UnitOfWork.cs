using Vehco.Repository.Interfaces;
using Vehco.Repository.Interfaces.DRTEvent;
using Vehco.Repository.Interfaces.General;

namespace Vehco.Repository;

public class UnitOfWork : IUnitOfWork
{
    private readonly ApplicationDbContext _context;
    public ICardRepository CardRepository { get; }
    public IDrtEventEnvelopeRepository DrtEventEnvelopeRepository { get; }
    public IDrtEventRepository DrtEventRepository { get; }
    public ITachographActivityPeriodRepository TachographActivityPeriodRepository { get; }
    public ITachographEventRepository TachographEventRepository { get; }
    public ITachographInformationRepository TachographInformationRepository { get; }
    public IDriverRepository DriverRepository { get; }
    public IPositionRepository PositionRepository { get; }
    public IVehicleRepository VehicleRepository { get; }

    public UnitOfWork(ApplicationDbContext vehcoDbContext,
        ICardRepository cardRepository,
        IDrtEventEnvelopeRepository drtEventEnvelopeRepository,
        IDrtEventRepository drtEventRepository,
        ITachographActivityPeriodRepository tachographActivityPeriodRepository,
        ITachographEventRepository tachographEventRepository,
        ITachographInformationRepository tachographInformationRepository,
        IDriverRepository driverRepository,
        IPositionRepository positionRepository,
        IVehicleRepository vehicleRepository)
    {
        this._context = vehcoDbContext;

        this.CardRepository = cardRepository;
        this.DrtEventEnvelopeRepository = drtEventEnvelopeRepository;
        this.DrtEventRepository = drtEventRepository;
        this.TachographActivityPeriodRepository = tachographActivityPeriodRepository;
        this.TachographEventRepository = tachographEventRepository;
        this.TachographInformationRepository = tachographInformationRepository;
        this.DriverRepository = driverRepository;
        this.PositionRepository = positionRepository;
        this.VehicleRepository = vehicleRepository;
    }
    public int Complete()
    {
        return _context.SaveChanges();
    }
    public void Dispose()
    {
        Dispose(true);
        GC.SuppressFinalize(this);
    }
    protected virtual void Dispose(bool disposing)
    {
        if (disposing)
        {
            _context.Dispose();
        }
    }
}