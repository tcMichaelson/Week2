using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProductVM.Models {
    public class ProductIndexViewModel {
        public IList<Product> Products { get; set; }
    }
}