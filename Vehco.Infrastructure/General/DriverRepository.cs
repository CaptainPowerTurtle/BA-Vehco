using Vehco.Repository;
using Vehco.Repository.Interfaces.General;
using Vehco.Repository.Models.General;

namespace Vehco.Infrastructure.General;

public class DriverRepository : GenericRepository<Driver>, IDriverRepository
{
    public DriverRepository(ApplicationDbContext context) : base(context)
    {

    }
}