using System.ComponentModel.DataAnnotations;

namespace Vehco.Repository.Models.DRTEvent;

public class TachographInformation
{
    [Key]
    public string? InformationId { get; set; }
    public string? CardId { get; set; }
    public string? CardSlot { get; set; }
}