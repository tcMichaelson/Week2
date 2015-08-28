using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RolodexWithSQLServer.Models {
    public class Contact {
        public int Id { get; set; }
        [Required]
        [RegularExpression(@"^[a-zA-Z ]+$")]
        public string Name { get; set; }
        public DateTime Birthday { get; set; }

        [Required]
        [DataType(DataType.PhoneNumber)]
        public string Phone { get; set; }

        public Address Address { get; set; }
    }
}