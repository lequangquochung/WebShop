using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebShopApp.Models;

namespace WebShopApp.Models
{
    public class AppDbContext : IdentityDbContext<ApplicationUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<WebShopApp.Models.Product> Products { get; set; }
        public DbSet<WebShopApp.Models.Brand> Brands { get; set; }
        public DbSet<WebShopApp.Models.Category> Categories { get; set; }
        public DbSet<WebShopApp.Models.Order> Orders { get; set; }
        public DbSet<WebShopApp.Models.OrderDetail> OrderDetails { get; set; }
        public DbSet<WebShopApp.Models.Stock> Stocks { get; set; }
        public DbSet<WebShopApp.Models.ProductType> ProductTypes { get; set; }
        public DbSet<WebShopApp.Models.ShoppingCartItem> ShoppingCartItems { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            base.OnModelCreating(modelBuilder);

            foreach (var foreignKey in modelBuilder.Model.GetEntityTypes().SelectMany(e => e.GetForeignKeys()))
            {
                foreignKey.DeleteBehavior = DeleteBehavior.Restrict;
            }
        }

    }
}
