using Vehco.Consumer;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Builder;
using Vehco.Consumer.Messaging;
using Vehco.Infrastructure.General;
using Vehco.Repository;
using Vehco.Repository.DRTEvent;
using Vehco.Repository.Interfaces;
using Vehco.Repository.Interfaces.DRTEvent;
using Vehco.Repository.Interfaces.General;

public class Program
{

    public static void Main(string[] args)
    {
        CreateHostBuilder(args).Run();
        //using IHost host = Host.CreateDefaultBuilder(args)
        //    .UseWindowsService()
        //    .ConfigureAppConfiguration((hostingContext, config) =>
        //    {
        //        var builder = new ConfigurationBuilder()
        //            .SetBasePath(Directory.GetCurrentDirectory())
        //            .AddJsonFile($"appsettings.{hostingContext.HostingEnvironment.EnvironmentName}.json", optional: false, reloadOnChange: true)
        //            .AddEnvironmentVariables()
        //            .Build();
        //    })
        //    .ConfigureServices((hostContext, services) =>
        //    {
        //        services.AddOptions();

        //        //Services
        //        services.AddTransient<IVehcoService, VehcoService>();

        //        //Database options
        //        var databaseOptions = hostContext.Configuration.GetConnectionString("DefaultConnection");

        //        services.AddHostedService<Worker>();
        //    })
        //    .Build();
        //var builder = WebApplication.CreateBuilder(args);
        //var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
        //builder.Services.AddDbContext<ApplicationDbContext>(x => x.UseSqlServer(connectionString));
        //builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
        //builder.Services.AddHostedService<Worker>();
        //builder.Services.AddTransient<IVehcoService, VehcoService>();
        //builder.Services.AddSingleton<PersistentConnection>();
        //builder.Build().Run();
    }

    public static IHost CreateHostBuilder(string[] args) =>
        Host.CreateDefaultBuilder(args)
            .UseWindowsService()
            .ConfigureAppConfiguration((hostingContext, config) =>
            {
                config.AddJsonFile("appsettings.Development.json", false, true);
            })
            .ConfigureServices((hostContext, services) =>
            {
                services.AddOptions();
                var connectionString = hostContext.Configuration.GetConnectionString("DefaultConnection");
                //Services
                services.AddTransient<IVehcoService, VehcoService>();
                services.AddDbContext<ApplicationDbContext>(x => x.UseSqlServer(connectionString));
                services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
                services.AddHostedService<Worker>();
                services.AddSingleton<PersistentConnection>();
                services.AddHostedService<Worker>();
                services.AddScoped<IUnitOfWork, UnitOfWork>();
                services.AddScoped<ICardRepository, CardRepository>();
                services.AddScoped<IDrtEventEnvelopeRepository, DrtEventEnvelopeRepository>();
                services.AddScoped<IDrtEventRepository, DrtEventRepository>();
                services.AddScoped<ITachographActivityPeriodRepository, TachographActivityPeriodRepository>();
                services.AddScoped<ITachographEventRepository, TachographEventRepository>();
                services.AddScoped<ITachographInformationRepository, TachographInformationRepository>();
                services.AddScoped<IDriverRepository, DriverRepository>();
                services.AddScoped<IPositionRepository, PositionRepository>();
                services.AddScoped<IVehicleRepository, VehicleRepository>();
            })
            .Build();

}