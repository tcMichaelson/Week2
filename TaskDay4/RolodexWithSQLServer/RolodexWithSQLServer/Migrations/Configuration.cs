namespace RolodexWithSQLServer.Migrations {
    using Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<RolodexWithSQLServer.Models.DataContext> {
        public Configuration() {
            AutomaticMigrationsEnabled = false;
            ContextKey = "RolodexWithSQLServer.Models.DataContext";
        }

        protected override void Seed(RolodexWithSQLServer.Models.DataContext context) {
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
            context.Contacts.AddOrUpdate(
                c => c.Name,
                new Contact {
                    Name = "Tom Michaelson",
                    Phone = "8159705076",
                    Birthday = new DateTime(1983, 5, 8),
                    Address = new Address {
                        State = "IL",
                        City = "Chicago",
                        Street = "Some Street",
                        Zip = "92021"
                    }
                },
                new Contact {
                    Name = "Todd Michaels",
                    Phone = "8159705076",
                    Birthday = new DateTime(1983, 5, 8),
                    Address = new Address {
                        State = "IL",
                        City = "Chicago",
                        Street = "Some Street",
                        Zip = "92021"
                    }
                },
                new Contact {
                    Name = "Tim Nichols",
                    Phone = "8159444333",
                    Birthday = new DateTime(1983, 5, 8),
                    Address = new Address {
                        State = "IL",
                        City = "Chicago",
                        Street = "Some Street",
                        Zip = "92021"
                    }
                },
                new Contact {
                    Name = "Tad Knuckles",
                    Phone = "8159705076",
                    Birthday = new DateTime(1983, 5, 8),
                    Address = new Address {
                        State = "IL",
                        City = "Chicago",
                        Street = "Some Street",
                        Zip = "92021"
                    }
                }
                
                );
        }
    }
}
