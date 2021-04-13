using FagElGamous.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.Routing;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FagElGamous.Infrastructure
{
    [HtmlTargetElement("ul", Attributes = "page-info")]
    public class PaginationTagHelper : TagHelper 
    {
        //constructor
        private IUrlHelperFactory urlInfo;
        public PaginationTagHelper (IUrlHelperFactory uhf)
        {
            urlInfo = uhf;
        }

        //properties
        public PagingInfo PageInfo { get; set; }
        //public string gender { get; set; }

        //css properties
        public bool PageClassesEnabled { get; set; } = false;
        public string PageClass { get; set; }
        public string PageClassNormal { get; set; }
        public string PageClassSelected { get; set; }

        //dictionary key value pairs
        [HtmlAttributeName(DictionaryAttributePrefix ="page-url-")]
        public Dictionary<string, object> KeyValuePairs { get; set; } = new Dictionary<string, object>();
        
        
        [HtmlAttributeNotBound]
        [ViewContext]
        public ViewContext ViewContext { get; set; }


        //override defual process method
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            
            IUrlHelper urlHelp = urlInfo.GetUrlHelper(ViewContext);

            //build the ul tag
            TagBuilder ultag = new TagBuilder("ul");
            
            //loop to build a tags
            for (int i = 1; i <= PageInfo.NumPages; i++)
            {
                TagBuilder liTag = new TagBuilder("li");
                    
                TagBuilder aTag = new TagBuilder("a");

                KeyValuePairs["pageNum"] = i;

                aTag.Attributes["href"] = urlHelp.Action("Index", KeyValuePairs);
                

                aTag.InnerHtml.Append(i.ToString());

                //append to li tag
                liTag.InnerHtml.AppendHtml(aTag);

                //connect to css classes
                if (PageClassesEnabled)
                {
                    liTag.AddCssClass(i == PageInfo.CurrentPage ? PageClassSelected : PageClassNormal);
                }

                //append completed a tag
                ultag.InnerHtml.AppendHtml(liTag);


            }

            output.Content.AppendHtml(ultag.InnerHtml);

        }
    }
}
