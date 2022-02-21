using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Vehco.Repository.Models.DRTEvent;
using Vehco.Repository.Models.General;

namespace Vehco.Repository;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext()
    {

    }
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    { }

    public DbSet<Card> Cards { get; set; }
    public DbSet<DRTEventEnvelope> DrtEventEnvelopes { get; set; }
    public DbSet<Models.DRTEvent.DRTEvent> DrtEvents { get; set; }
    public DbSet<TachographActivityPeriod> TachographActivityPeriods { get; set; }
    public DbSet<TachographEvent> TachographEvents { get; set; }
    public DbSet<TachographInformation> TachographInformations { get; set; }
    public DbSet<Driver> Drivers { get; set; }
    public DbSet<Position> Positions { get; set; }
    public DbSet<Vehicle> VehicleIds { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        var configuration = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile($"appsettings.Development.json", optional: false, reloadOnChange: true)
            .Build();

        var connectionString = configuration.GetConnectionString("DefaultConnection");
        optionsBuilder.UseSqlServer(connectionString);
    }
}