using System.Data.Entity;
using BookingBoss.Domain;

namespace BookingBoss.Infrastructure
{
    public class BookingBossContext : DbContext, IContext
    {
        public BookingBossContext()
            : base("Name=BookingBossContext")
        {
            this.Configuration.LazyLoadingEnabled = false;
        }

        public DbSet<ProductEntity> Products { get; set; }
        public DbSet<UserEntity> Users { get; set; }
    }
}
