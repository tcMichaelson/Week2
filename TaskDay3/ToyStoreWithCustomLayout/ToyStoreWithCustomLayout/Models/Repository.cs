using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ToyStoreWithCustomLayout.Models {
    public class Repository {
        public List<Toy> GetToys() {
            return new List<Toy> {
                new Toy {
                    Desc = "This is an awesome toy for everyone that comes with built-in laser vision",
                    Name = "Stuffed Bunny",
                    Price = 37.45m,
                    imageURL="/Content/laserbunny.jpg"
                },
                new Toy {
                    Desc ="The ultimate flying machine.  Get your flying boot here!",
                    Name="Flying Boot",
                    Price = 7999.99m,
                    imageURL="/Content/flyingboot.jpg"
                }
            };
        }
    }
}