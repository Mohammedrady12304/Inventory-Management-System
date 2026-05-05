using Class_Library.Models;
using InventoryManagementSystem.ClassLibrary.Models;
using Microsoft.EntityFrameworkCore;

namespace Class_Library.Context
{
    public class InventoryManagementContext : DbContext
    {
        public InventoryManagementContext(DbContextOptions<InventoryManagementContext> options)
            : base(options) { }

        public InventoryManagementContext() { }

        public DbSet<User> Users { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(
                    @"Server=.;Database=InventoryManagementSystem;Integrated Security=True;TrustServerCertificate=True;"
                );
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Category -> Product (1:M)
            modelBuilder.Entity<Product>()
                .HasOne(p => p.Category)
                .WithMany(c => c.Products)
                .HasForeignKey(p => p.catid)
                .OnDelete(DeleteBehavior.SetNull);

            // Customer -> Order (1:M) — Customer:Product is M:M through Order
            modelBuilder.Entity<Order>()
                .HasOne(o => o.Customer)
                .WithMany(c => c.Orders)
                .HasForeignKey(o => o.cid)
                .OnDelete(DeleteBehavior.Cascade);

            // Product -> Order (1:M)
            modelBuilder.Entity<Order>()
                .HasOne(o => o.Product)
                .WithMany(p => p.Orders)
                .HasForeignKey(o => o.pid)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<User>().HasData(new User
            {
                username = "admin",
                fullname = "Administrator",
                password = "admin123",
                phone = "01000000000"
            });
        }
    }
}