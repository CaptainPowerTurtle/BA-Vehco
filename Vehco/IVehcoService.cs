namespace Vehco.Consumer;

public interface IVehcoService
{
    Task GetDRTEventService(CancellationToken ct);
}