using assa_api_test.Models;
using Microsoft.EntityFrameworkCore;

namespace assa_api_test.Data;

public class ApiDbContext : DbContext
{
    public ApiDbContext(DbContextOptions<ApiDbContext> options) : base(options)
    {
        
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<MarcasAutos>().HasData(
                    new MarcasAutos()
                    {
                        Id = 1,
                        NombreMarca = "Chevrolet"
                    },
                    new MarcasAutos()
                    {
                        Id = 2,
                        NombreMarca = "Ford"
                    },
                    new MarcasAutos()
                    {
                        Id = 3,
                        NombreMarca = "Toyota"
                    }
                );
        }

    public DbSet<MarcasAutos> MarcasAutos { get; set; }



}