using CarShop.Common.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarShop.Infrastructure.Databases
{
    public class CarShopContext : DbContext
    {
        public DbSet<Car> Cars { get; set; }
        public DbSet<BrandModel> BrandModels { get; set; }
        public DbSet<CarBrand> CarBrands { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<User> Users { get; set; }

        public CarShopContext(DbContextOptions<CarShopContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }
    }
}
