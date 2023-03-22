using Microsoft.EntityFrameworkCore;


namespace web_layer.Entity
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<OrderEntity> Orders { get; set; }
        public DbSet<OrderItemEntity> OrderItems { get; set; }
        public DbSet<ProviderEntity> Providers { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
			AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);
			Database.EnsureCreated();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ProviderEntity>().HasData(
               new ProviderEntity() { Id = 1, Name = "Yandex" },
               new ProviderEntity() { Id = 2, Name = "Google" },
               new ProviderEntity() { Id = 3, Name = "Intel" }
            );
        }
    }
}