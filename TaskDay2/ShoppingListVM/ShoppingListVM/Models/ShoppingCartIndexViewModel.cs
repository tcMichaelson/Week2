using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShoppingListVM.Models {
    public class ShoppingCartIndexViewModel {
        public Customer CustomerInfo { get; set; }
        public IList<Product> ProductList { get; set; }
    }
}