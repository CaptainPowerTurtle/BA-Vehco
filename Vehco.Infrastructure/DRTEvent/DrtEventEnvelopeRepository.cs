using Vehco.Infrastructure;
using Vehco.Repository.Interfaces;
using Vehco.Repository.Models.DRTEvent;

namespace Vehco.Repository.DRTEvent;

public class DrtEventEnvelopeRepository : GenericRepository<DRTEventEnvelope>, IDrtEventEnvelopeRepository
{
    public DrtEventEnvelopeRepository(ApplicationDbContext context) : base(context){}

}