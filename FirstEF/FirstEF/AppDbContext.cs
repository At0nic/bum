using FirstEF.Cars;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace FirstEF;

internal class AppDbContext : DbContext
{
    public DbSet<Car> Cars { get; set; } = null!;
    protected override void OnConfiguring(DbContextOptionsBuilder options)
    {
        options.UseNpgsql("User ID=postgres;Password=MasterPassword;Host=localhost;Port=5432;Database=Allah;");
    }
}