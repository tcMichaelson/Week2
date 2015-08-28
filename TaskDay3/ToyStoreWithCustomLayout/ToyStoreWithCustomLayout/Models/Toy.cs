using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ToyStoreWithCustomLayout.Models {
    public class Toy {
        public string Name { get; set; }
        public string Desc { get; set; }
        public decimal Price { get; set; }
        public string imageURL { get; set; }
    }
}