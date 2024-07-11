using Journey.Infrastructure.Entities;
using Microsoft.EntityFrameworkCore;

namespace Journey.Infrastructure;

public class JourneyDbContext : DbContext
{
    public DbSet<Trip> Trips { get; set; }
    public DbSet<Activity> Activities { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source = C:\\INFORMATIC\\C#\\Journey\\JourneyDatabase.db"); // mude o Data Source conforme a localização do banco de dados em seu sistema!
    }
}
