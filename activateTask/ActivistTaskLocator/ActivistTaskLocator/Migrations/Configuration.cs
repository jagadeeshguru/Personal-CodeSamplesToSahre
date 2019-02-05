namespace ActivistTaskLocator.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using ActivistTaskLocator.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<ActivistTaskLocator.Models.ActivityDBContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(ActivistTaskLocator.Models.ActivityDBContext context)
        {
            context.ActivityList.AddOrUpdate(i => i.Activity,
                new Activities
                {
                    Activity = "Rally",
                    Date = DateTime.Parse("2017-3-13"),
                    Address = "Boston",
                    Organizer = "Micheal",
                    Attending = "100"
                    
                },

             new Activities
                {
                    Activity = "support rally",
                    Date = DateTime.Parse("2017-4-12"),
                    Address = "Chicago,IL",
                    Organizer = "Hopkins",
                    Attending = "265"
                    
                },
                 new Activities
                 {
                     Activity = "Group meeting",
                     Date = DateTime.Parse("2017-5-17"),
                     Address = "Newyork",
                     Organizer = "John Williams",
                     Attending="156"

                 },
                  new Activities
                {
                    Activity = "Rally",
                    Date = DateTime.Parse("2017-5-30"),
                    Address = "Washington",
                    Organizer = "Mike",
                    Attending = "600"
                    
                }
                );
        }
    }
        }
