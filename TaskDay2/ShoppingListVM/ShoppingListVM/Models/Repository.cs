using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShoppingListVM.Models {

    public class Repository {
        
        public IList<Product> GetItems() {

            return new List<Product> {
                new Product { Name="Milk", Price=2.33m, Quantity=23 },
                new Product { Name="Eggs", Price=-2.50m, Quantity=2 },
                new Product { Name="Cheese", Price=-2.12m, Quantity=3 }

            };
        }

        public IList<Customer> GetAllCustomers() {
            return new List<Customer> {
                new Customer {FirstName = "Tom", LastName = "Michaelson" },
                new Customer {FirstName = "Joanne", LastName="Smith"},
                new Customer {FirstName = "Steve", LastName="Pinkous" }
            };
        }

        public Customer GetCustomer() {
            return new Customer { FirstName = "Tom", LastName = "Michaelson" };
        }
    }
}