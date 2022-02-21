using Vehco.Repository;
using Vehco.Repository.Interfaces.General;
using Vehco.Repository.Models.General;

namespace Vehco.Infrastructure.General;

public class PositionRepository : GenericRepository<Position>, IPositionRepository
{
    public PositionRepository(ApplicationDbContext context) : base(context)
    {

    }
}