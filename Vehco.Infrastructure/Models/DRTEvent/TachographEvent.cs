using System.ComponentModel.DataAnnotations;
using Vecho.Consumer.Model.General;

namespace Vehco.Repository.Models.DRTEvent;

public class TachographEvent
{
    [Key]
    public string? EventTypeId { get; set; }
    public string? InformationId { get; set; }
    public string? TachographEventType { get; set; }
    public string? DriverId { get; set; }
    public string? VehicleId { get; set; }
    public DateTime Timestamp { get; set; }
    public string? PositionId { get; set; }
    public long Mileage { get; set; }
}