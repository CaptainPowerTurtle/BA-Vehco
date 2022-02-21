using Vehco.Repository;
using Vehco.Repository.Interfaces.General;
using Vehco.Repository.Models.General;

namespace Vehco.Infrastructure.General;

public class VehicleRepository : GenericRepository<Vehicle>, IVehicleRepository
{
    public VehicleRepository(ApplicationDbContext context) : base(context)
    {

    }
}