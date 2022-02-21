using System.ComponentModel.DataAnnotations;

namespace Vehco.Repository.Models.DRTEvent;

public class Card
{
    [Key]
    public string? CardId { get; set; }
    public string? CardConsecutiveIndex { get; set; }
    public string? CardReplacementIndex { get; set; }
    public string? CardRenewalIndex { get; set; }
}