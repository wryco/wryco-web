using Caspnetti.DAL.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace Caspnetti.DAL;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(){}

    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options){}

    public DbSet<User> Users { get; set; } = null!;

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        // Build configuration from appsettings.json
        var config = new ConfigurationBuilder()
            .SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../Caspnetti.API"))
            .AddJsonFile("appsettings.json")
            .Build();

        var connectionString = config.GetConnectionString("DefaultConnection");
        optionsBuilder.UseSqlServer(connectionString);

        // optionsBuilder.UseSqlServer("Server=caspnetti_mssql; Database=caspnetti; User ID=sa; Password=GPYVVWINOE8BrxMe1noTDLs8blBJ3DYGxM1fMUfDS9AvffaCcK2cArIjfDXIL99b; TrustServerCertificate=True;");
    }
}
