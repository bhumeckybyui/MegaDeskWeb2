using MegaDeskWeb.Models; 
using System; 
using System.Linq; 

namespace MegaDeskWeb.Data {
    public class DbInitializer

    {
        public static void Initialize(MegaDeskContext context)

        {
            //checks if there is already materials in the database
            context.Database.EnsureCreated();
            if (context.Material.Any())

            {
                return;
                // DB has been seeded
            }

            var material = new Material[] {
                    new Material
                    {
                        Description = "Laminated",
                        Amount = 100
                    },
                    new Material
                    {
                        Description = "Oak",
                        Amount = 200
                    },
                    new Material
                    {
                        Description = "Rosewood",
                        Amount = 300
                    },
                    new Material
                    {
                        Description = "Veneer",
                        Amount = 125
                    },
                    new Material
                    {
                        Description = "Pine",
                        Amount = 5
                    }
            };

            foreach (Material m in material)
            {
                context.Material.Add(m);
            }
            context.SaveChanges();

            /*
            var shippingTime = new ShippingTime[]{

                new ShippingTime
                {
                    Days = 3
                },
                new ShippingTime
                {
                    Days = 5
                },
                new ShippingTime
                {
                    Days = 7
                },
                new ShippingTime
                {
                    Days = 14
                }
            };
        
            foreach (ShippingTime st in shippingTime)
            {
                context.ShippingTime.Add(st);
            }
            context.SaveChanges();
            */

        }
    }
}

