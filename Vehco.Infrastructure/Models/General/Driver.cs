using System.ComponentModel.DataAnnotations;

namespace Vehco.Repository.Models.General;

public class Driver
{
    [Key]
    public string? DriverId { get; set; }
    public string? Username { get; set; }
}