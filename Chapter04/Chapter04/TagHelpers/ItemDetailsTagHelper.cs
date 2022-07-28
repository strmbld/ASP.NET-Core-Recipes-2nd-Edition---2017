using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Chapter04.Controllers;
using Chapter04.TagHelpers.Base;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using Microsoft.AspNetCore.Mvc.Routing;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace Chapter04.TagHelpers
{
    public class ItemDetailsTagHelper : ItemLinkTagHelperBase
    {
        public ItemDetailsTagHelper(IActionContextAccessor contextAccessor, IUrlHelperFactory urlHelperFactory)
            : base(contextAccessor, urlHelperFactory) { }


        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            BuildContent(output, nameof(HomeController.Details), "text-info", "Details", "info-circle");
        }
    }
}
