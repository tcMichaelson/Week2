using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCDataGridHelper.Helpers {
    public static class HTMLExtensions {
        public static MvcHtmlString DataGrid(this HtmlHelper helper, IEnumerable<string> data) {
            var allTRs = "";
            foreach (var item in data) {
                var tagTR = new TagBuilder("tr");
                var tagTD = new TagBuilder("td");
                tagTD.InnerHtml = item;
                tagTD.MergeAttribute("style", "border: 1px solid black");
                tagTR.InnerHtml = tagTD.ToString();
                allTRs += tagTR.ToString();
            }
            var finalString = new TagBuilder("table");
            finalString.InnerHtml = allTRs;
            return MvcHtmlString.Create(finalString.ToString());
        }
    }
}