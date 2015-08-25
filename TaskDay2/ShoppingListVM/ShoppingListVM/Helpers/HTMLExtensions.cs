using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ShoppingListVM.Helpers {
    public static class HTMLExtensions {
        public static MvcHtmlString FormatCurrency(this HtmlHelper helper, decimal amount) {
            if (amount < 0) {
                TagBuilder newTag = new TagBuilder("span");
                newTag.MergeAttribute("style", "color:red");
                newTag.SetInnerText(amount.ToString("c"));
                return MvcHtmlString.Create(newTag.ToString(TagRenderMode.EndTag));
            }
            return MvcHtmlString.Create(amount.ToString("c"));
        }
    }
}