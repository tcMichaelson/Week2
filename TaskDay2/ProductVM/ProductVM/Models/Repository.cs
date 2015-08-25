using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProductVM.Models {
    public class Repository {

        public IList<Product> ListProducts() {
            return new List<Product>{
            new Product{Name="Milk", Price=2.33m},
            new Product{Name="Eggs", Price=1.09m},
            new Product{Name="Cheese", Price=12.00m}
            };
        }
    }
}


