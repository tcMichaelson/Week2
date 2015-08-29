namespace AuctionSite.Migrations
{
    using Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<AuctionSite.Models.DataContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(AuctionSite.Models.DataContext context) {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //

            context.AuctionItems.AddOrUpdate(
                new AuctionItem {
                    Name = "Old Tractor",
                    Description = "This antique tractor comes with all four wheels still attached.",
                    MinimumBid = 100.0m,
                    MaximumBids = 10
                },
                new AuctionItem {
                    Name = "Horse",
                    Description = "A coarse horse is better than a moose caboose.",
                    MinimumBid = 150.0m,
                    MaximumBids = 10
                },
                new AuctionItem {
                    Name = "Lamp",
                    Description = "Shine the light",
                    MinimumBid = 20.0m,
                    MaximumBids = 5
                },
                new AuctionItem {
                    Name = "Table",
                    Description = "I put food on it.",
                    MinimumBid = 30.0m,
                    MaximumBids = 5
                },
                new AuctionItem {
                    Name = "Pet Snake",
                    Description = "Slitherific.",
                    MinimumBid = 100.0m,
                    MaximumBids = 8
                },
                new AuctionItem {
                    Name = "Snake Food",
                    Description = "Actually it's just a mouse.",
                    MinimumBid = 15.0m,
                    MaximumBids = 2
                }
                );
        }
    }
}
