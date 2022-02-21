using Vehco.Infrastructure;
using Vehco.Repository.Interfaces.DRTEvent;
using Vehco.Repository.Models.DRTEvent;

namespace Vehco.Repository.DRTEvent;

public class CardRepository : GenericRepository<Card>, ICardRepository
{
    public CardRepository(ApplicationDbContext context) : base(context)
    {

    }
    
}