using System.ComponentModel.DataAnnotations;

namespace Vehco.Repository.Models.DRTEvent;

public class TachographActivityPeriod
{
    [Key]
    public string? EventTypeId { get; set; }
    public string? InformationId { get; set; }
    public string? TachographActivity { get; set; }
    public string? DriverId { get; set; }
    public string? VehicleId { get; set; }
    public DateTime StartTimestamp { get; set; }
    public DateTime EndTimestamp { get; set; }
    public string StartPosition { get; set; }
    public string EndPosition { get; set; }
    public long StartMileage { get; set; }
    public long EndMileage { get; set; }
}