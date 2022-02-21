using System.ComponentModel.DataAnnotations;

namespace Vehco.Repository.Models.General;

public class Position
{
    [Key]
    public string? PositionId { get; set; }
    public string? Latitude { get; set; }
    public string? Longitude { get; set; }
}