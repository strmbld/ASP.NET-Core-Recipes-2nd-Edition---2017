using Chapter04.Controllers;
using Chapter04.TagHelpers.Base;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using Microsoft.AspNetCore.Mvc.Routing;
using Microsoft.AspNetCore.Razor.TagHelpers;


namespace Chapter04.TagHelpers
{
    public class ItemCreateTagHelper : ItemLinkTagHelperBase
    {
        public ItemCreateTagHelper(IActionContextAccessor contextAccessor, IUrlHelperFactory urlHelperFactory)
            : base(contextAccessor, urlHelperFactory) { }


        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            BuildContent(output, nameof(HomeController.Create), "text-success", "Create new", "plus");
        }
    }
}
