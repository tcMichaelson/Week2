using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DataBindingThing.Models {
    public class Repository {

        public IList<Customer> ListCustomers() {
            List<Customer> customerList = new List<Customer> {
                new Customer {
                    FirstName ="Tom",
                    LastName = "Michaelson",
                    ShippingAddress = new Address {
                        Street = "1507 Something St.",
                        City = "Houston"
                    },
                    BillingAddress = new Address {
                        Street = "1507 Something St.",
                        City = "Houston"
                    }
                },
                new Customer {
                    FirstName ="Tom",
                    LastName = "Michaelson",
                    ShippingAddress = new Address {
                        Street = "1507 Something St.",
                        City = "Houston"
                    },
                    BillingAddress = new Address {
                        Street = "1507 Something St.",
                        City = "Sandwich"
                    }
                },
                new Customer {
                    FirstName = "Tom",
                    LastName = "Michaelson",

                    ShippingAddress = new Address {
                        Street = "1507 Something St.",
                        City = "Houston"
                    },
                    BillingAddress = new Address {
                        Street = "1507 Something St.",
                        City = "Sandwich"
                    }
                }
            };

            return customerList;
        }
    }
}