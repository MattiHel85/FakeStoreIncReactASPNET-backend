using System.Security.Cryptography.X509Certificates;
using FakeStoreInc.Core.src.Entity;
using Microsoft.EntityFrameworkCore;
using Npgsql;

namespace FakeStoreInc.WebAPI.src.Database
{
    public class DatabaseContext : DbContext // builder pattern
    {
        private readonly IConfiguration _config;
        public DbSet<User> Users { get; set;}
        public DbSet<Address> Addresses { get; set;}
        public DbSet<Category> Categories { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<Product> Products { get; set; }
        public DatabaseContext(DbContextOptions options, IConfiguration config) : base(options)
        {
            _config = config;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var dataSourceBuilder = new NpgsqlDataSourceBuilder(_config.GetConnectionString("Local"));
            dataSourceBuilder.MapEnum<Role>();
            var dataSource = dataSourceBuilder.Build();
            optionsBuilder
                .UseNpgsql(dataSource)
                .UseSnakeCaseNamingConvention();
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasPostgresEnum<Role>();
            modelBuilder.Entity<Order>()
                .HasOne(o => o.User)
                .WithMany(u => u.Orders)
                .HasForeignKey(o => o.UserId);
            modelBuilder.Entity<Product>()
                .HasOne(p => p.Category)
                .WithMany(c => c.Products)
                .HasForeignKey(p => p.CategoryId);
            modelBuilder.Entity<OrderItem>()
                .HasOne(oi => oi.Order)
                .WithMany(o => o.OrderItems)
                .HasForeignKey(oi => oi.OrderId);
            modelBuilder.Entity<Category>()
                .HasMany(c => c.Products)
                .WithOne(p => p.Category);
            modelBuilder.Entity<User>()
                .HasMany(u => u.Addresses)
                .WithOne(a => a.User)
                .HasForeignKey(a => a.UserId)
                .OnDelete(DeleteBehavior.Cascade);

            base.OnModelCreating(modelBuilder);
        }
    }
}