using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PhoneMVCUsingEditorTemplates.Models {
    public class Repository {
        public IList<Customer> GetCustomers() {
            return new List<Customer> {
                new Customer {
                    FirstName="Tom",
                    LastName="Michaelson",
                    PhoneNumber="8158158151"
                }
            };
        }
    }
}