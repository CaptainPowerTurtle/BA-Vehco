using Vehco.Infrastructure;
using Vehco.Repository.Interfaces.DRTEvent;
using Vehco.Repository.Models.DRTEvent;

namespace Vehco.Repository.DRTEvent;

public class TachographInformationRepository : GenericRepository<TachographInformation>, ITachographInformationRepository
{
    public TachographInformationRepository(ApplicationDbContext context) : base(context)
    {

    }
}