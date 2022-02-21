using Apache.NMS;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace Vehco.Consumer;

public class Worker : BackgroundService
{
    private readonly ILogger<Worker> _logger;
    private IVehcoService _drtEvent;
    public IServiceProvider Services {get;}
    public Worker(ILogger<Worker> logger, IVehcoService drtEvent, IServiceProvider services)
    {
        _logger = logger;
        _drtEvent = drtEvent;
        Services = services;
    }

    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        while (!stoppingToken.IsCancellationRequested)
        {
            var workers = new List<Task>();
            workers.Add(DRTEventWorker(stoppingToken));
            workers.Add(DRTEventWorker(stoppingToken));
            workers.Add(DRTEventWorker(stoppingToken));
            workers.Add(DRTEventWorker(stoppingToken));
            //workers.Add(DRTEventWorker(stoppingToken));
            //workers.Add(DRTCumulationWorker(stoppingToken));

            await Task.WhenAll(workers.ToArray());
        }
    }
    public override Task StopAsync(CancellationToken ct)
    {
        _logger.LogInformation("Timed Hosted Service is stopping.");

        return Task.CompletedTask;
    }
    private async Task DRTEventWorker(CancellationToken ct)
    {
        string thread = Thread.CurrentThread.ManagedThreadId.ToString();
        //Console.WriteLine("This is the current thread " + thread);
        //_drtEvent.GetDRTEventService();

        using (var scope = Services.CreateScope())
        {
            var scopedVehcoService = scope.ServiceProvider.GetRequiredService<IVehcoService>();
            await scopedVehcoService.GetDRTEventService(ct);
        }
        

        while (!ct.IsCancellationRequested)
        {
            try
            {
            }
            catch (Exception e)
            {
                _logger.LogError(e.InnerException.ToString());
            }

            await Task.Delay(10000, ct);
        }
    }
}