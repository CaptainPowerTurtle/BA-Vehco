using System.ComponentModel.DataAnnotations;

namespace Vehco.Repository.Models.General;

public class Vehicle
{
    [Key]
    public string? VehicleId { get; set; }
    public string? RoadBoxId { get; set; }
    public string? LicensePlate { get; set; }
    public string? ExternalId { get; set; }
}