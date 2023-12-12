using System.Security.Cryptography.X509Certificates;
using FakeStoreInc.Core.src.Entity.User;
using Microsoft.EntityFrameworkCore;
using Npgsql;

namespace FakeStoreInc.WebAPI.src.Database
{
    public class DatabaseContext : DbContext // builder pattern
    {
        private readonly IConfiguration _config;
        public DbSet<User> Users { get; set;}
        public DatabaseContext(DbContextOptions options, IConfiguration config) : base(options)
        {
            _config = config;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var dataSourceBuilder = new NpgsqlDataSourceBuilder("Host=dpg-cls51rbip8as73a3c3pg-a.frankfurt-postgres.render.com;Database=fakestore_db_5r5a;Username=fakestore_db_5r5a_user;Password=AiCIAP8MMmhiys86wQkMwRTkzBscyfCi");
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