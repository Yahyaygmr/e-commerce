using API.Entity;
using Microsoft.EntityFrameworkCore;

namespace API.Data;

public class DataContext(DbContextOptions options) : DbContext(options)
{
    public DbSet<Product> Products { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Product>().HasData(
            new List<Product>
            {
                new(){Id=1, Name="Iphone 15", Description="Phone description", ImageUrl="1.jpg", Price=7000, IsActive=true, Stock=100},
                new(){Id=2, Name="Iphone 16", Description="Phone description", ImageUrl="2.jpg", Price=8000, IsActive=true, Stock=200},
                new(){Id=3, Name="Iphone 17", Description="Phone description", ImageUrl="3.jpg", Price=9000, IsActive=true, Stock=50},
                new(){Id=4, Name="Iphone 18", Description="Phone description", ImageUrl="4.jpg", Price=10000, IsActive=true, Stock=800},
                new(){Id=5, Name="Iphone 19", Description="Phone description", ImageUrl="5.jpg", Price=11000, IsActive=true, Stock=60},
                new(){Id=6, Name="Iphone 14", Description="Phone description", ImageUrl="6.jpg", Price=6000, IsActive=true, Stock=30},
                new(){Id=7, Name="Iphone 13", Description="Phone description", ImageUrl="7.jpg", Price=5000, IsActive=true, Stock=4},
            }
        );
    }
}