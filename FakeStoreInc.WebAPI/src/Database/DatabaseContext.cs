using System.Drawing;
using FakeStoreInc.Business.src.Shared;
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
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<Product> Products { get; set; }
        public DatabaseContext(DbContextOptions options, IConfiguration config) : base(options)
        {
            _config = config;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var dataSourceBuilder = new NpgsqlDataSourceBuilder(_config.GetConnectionString("Render"));
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
            modelBuilder.Entity<User>(entity => entity.Property(e => e.Role).HasColumnType("role"));
            
            modelBuilder.Entity<Order>()
                .HasMany(o => o.OrderDetails)
                .WithOne()
                .HasForeignKey(od => od.OrderId)
                .OnDelete(DeleteBehavior.Cascade);
            modelBuilder.Entity<OrderDetail>().HasKey("ProductId", "OrderId");
            
            modelBuilder.Entity<OrderDetail>()
                .HasOne<Product>()
                .WithMany()
                .HasForeignKey(od => od.ProductId);
            modelBuilder.Entity<OrderDetail>()
                .HasOne<Order>()
                .WithMany(o => o.OrderDetails)
                .HasForeignKey(od => od.OrderId);
            modelBuilder.Entity<Product>()
                .HasOne<Category>()
                .WithMany()
                .HasForeignKey(p => p.CategoryId);
            modelBuilder.Entity<User>().HasIndex(u => u.Email).IsUnique();
            modelBuilder.Entity<User>()
                .HasMany(u => u.Addresses)
                .WithOne()
                .HasForeignKey(a => a.UserId)
                .OnDelete(DeleteBehavior.Cascade);
            modelBuilder.Entity<User>()
                .HasMany(u => u.Orders)
                .WithOne()
                .HasForeignKey(o => o.UserId);
            modelBuilder.Entity<User>().HasData(
                new User
                {
                    Id = new Guid("00000000-0000-0000-0000-000000000666"),
                    FirstName = "Super",
                    LastName = "Admin",
                    Email = "matt.rc.simpson@gmail.com",
                    Password = HashSuperAdminPassword("SuperAdminPass2024!"),
                    Role = Role.Admin 
                }
        );
            base.OnModelCreating(modelBuilder);
        }
        private string HashSuperAdminPassword(string originalPassword)
        {
            PasswordService.HashPassword(originalPassword, out string hashedPassword, out byte[] salt);
            return hashedPassword;
        }
    }
}