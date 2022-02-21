using System.ComponentModel.DataAnnotations;

namespace Vehco.Repository.Models.DRTEvent;

public class DRTEventEnvelope
{
    [Key]
    public string? EnvelopeId { get; set; }
}