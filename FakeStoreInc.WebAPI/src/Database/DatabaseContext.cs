using System.Security.Cryptography.X509Certificates;
using FakeStoreInc.Core.src.Entity;
using FakeStoreInc.Core.src.Entity.Category;
using FakeStoreInc.Core.src.Entity.Order;
using FakeStoreInc.Core.src.Entity.OrderItem;
using FakeStoreInc.Core.src.Entity.Product;
using FakeStoreInc.Core.src.Entity.User;
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
        }
    }
}