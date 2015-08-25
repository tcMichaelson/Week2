using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShoppingListVM.Models {
    public class ShoppingCartAllCustomersViewModel {
        public IList<Customer> AllCustomers { get; set; }
        public IList<Product> AllProdcuts { get; set; }
    }
}