using Vehco.Infrastructure;
using Vehco.Repository.Interfaces.DRTEvent;
using Vehco.Repository.Models.DRTEvent;

namespace Vehco.Repository.DRTEvent;

public class TachographEventRepository : GenericRepository<TachographEvent>, ITachographEventRepository
{
    public TachographEventRepository(ApplicationDbContext context) : base(context)
    {

    }
}