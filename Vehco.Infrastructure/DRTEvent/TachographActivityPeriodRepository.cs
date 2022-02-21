using Vehco.Domain.Models.DRTEvent;
using Vehco.Infrastructure;
using Vehco.Repository.Interfaces.DRTEvent;
using Vehco.Repository.Models.DRTEvent;

namespace Vehco.Repository.DRTEvent;

public class TachographActivityPeriodRepository : GenericRepository<TachographActivityPeriod>, ITachographActivityPeriodRepository
{
    public TachographActivityPeriodRepository(ApplicationDbContext context) : base(context)
    {

    }
}