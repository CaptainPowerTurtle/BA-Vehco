using Vehco.Infrastructure;
using Vehco.Repository.Interfaces.DRTEvent;

namespace Vehco.Repository.DRTEvent;

public class DrtEventRepository : GenericRepository<Models.DRTEvent.DRTEvent>, IDrtEventRepository
{
    public DrtEventRepository(ApplicationDbContext context) : base(context)
    {

    }
}