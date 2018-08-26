using BookingBoss.Domain;

namespace BookingBoss.Infrastructure.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<BookingBoss.Infrastructure.BookingBossContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(BookingBoss.Infrastructure.BookingBossContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.

            context.Users.AddOrUpdate(x => x.UserName, new []
            {
                new UserEntity { UserName = "test1", Password = "123456"},
                new UserEntity { UserName = "test2", Password = "123456"}
            });

            context.Products.AddOrUpdate(x => x.Name, new []
            {
                new ProductEntity {Name = "Product 1", Quantity = 10, SaleAmount = 2},
                new ProductEntity {Name = "Product 2", Quantity = 20, SaleAmount = 20},
                new ProductEntity {Name = "Product 3", Quantity = 15, SaleAmount = 10},
                new ProductEntity {Name = "Product 4", Quantity = 80, SaleAmount = 200},
                new ProductEntity {Name = "Product 5", Quantity = 30, SaleAmount = 15},
                new ProductEntity {Name = "Product 6", Quantity = 50, SaleAmount = 60},
                new ProductEntity {Name = "Product 7", Quantity = 100, SaleAmount = 20},
                new ProductEntity {Name = "Product 8", Quantity = 25, SaleAmount = 30},
                new ProductEntity {Name = "Product 9", Quantity = 35, SaleAmount = 40},
                new ProductEntity {Name = "Product 10", Quantity = 60, SaleAmount = 50}
            });
        }
    }
}
