using System.ComponentModel.DataAnnotations;

namespace Vehco.Repository.Models.DRTEvent;

public class DRTEvent
{
    [Key]
    public string? EventId { get; set; }
    public string? EnvelopeId { get; set; }
    public string? EventTypeId { get; set; }
}