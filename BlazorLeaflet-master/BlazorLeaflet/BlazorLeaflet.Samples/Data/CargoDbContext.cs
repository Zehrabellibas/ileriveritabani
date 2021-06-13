using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace BlazorLeaflet.Samples.Data
{
    public class CargoDbContext : DbContext
    {
        public CargoDbContext(DbContextOptions<CargoDbContext> options)
                : base(options)
        {

        }
       
        public DbSet<Cargo> Cargo { get; set; }
       

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cargo>().HasData(
                new Cargo { Id = 1, Weight = 12, Price = 23.50, DeliveryCity = "Çanakkale", Latitude = 42.5, Longitude = 45 },
                new Cargo { Id = 2, Weight = 317, Price = 1200, DeliveryCity = "İstanbul", Latitude = 39, Longitude = 35.67 },
                new Cargo { Id = 3, Weight = 8.300, Price = 55.90, DeliveryCity = "Eskişehir", Latitude = 36.78, Longitude = 38.42 },
                new Cargo { Id = 4, Weight = 24.67, Price = 545.50, DeliveryCity = "Antalya", Latitude = 45, Longitude = 34.78 }
                );

            /*if (!options.IsConfigured)
            {
                options.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=BlazorLeaflet;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            }*/
        }
    }
}
