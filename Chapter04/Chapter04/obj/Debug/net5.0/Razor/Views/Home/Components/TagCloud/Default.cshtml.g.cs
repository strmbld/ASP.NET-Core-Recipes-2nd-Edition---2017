#pragma checksum "D:\dev\cs\code for Ciliberti J. - ASP.NET Core Recipes, 2nd Edition - 2017\Chapter04\Chapter04\Views\Home\Components\TagCloud\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "09ab2725f48d561c56d34274cf8313ba1e23c038"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Components_TagCloud_Default), @"mvc.1.0.view", @"/Views/Home/Components/TagCloud/Default.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "D:\dev\cs\code for Ciliberti J. - ASP.NET Core Recipes, 2nd Edition - 2017\Chapter04\Chapter04\Views\_ViewImports.cshtml"
using Chapter04;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\dev\cs\code for Ciliberti J. - ASP.NET Core Recipes, 2nd Edition - 2017\Chapter04\Chapter04\Views\_ViewImports.cshtml"
using Chapter04.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"09ab2725f48d561c56d34274cf8313ba1e23c038", @"/Views/Home/Components/TagCloud/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fad762f2486cbfa8ac1817a42c84bb2f1a0c39f5", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Components_TagCloud_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TagCloud>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"tagcloud\">\r\n");
#nullable restore
#line 4 "D:\dev\cs\code for Ciliberti J. - ASP.NET Core Recipes, 2nd Edition - 2017\Chapter04\Chapter04\Views\Home\Components\TagCloud\Default.cshtml"
     foreach (var item in Model.Items)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <a");
            BeginWriteAttribute("href", " href=\"", 100, "\"", 116, 1);
#nullable restore
#line 6 "D:\dev\cs\code for Ciliberti J. - ASP.NET Core Recipes, 2nd Edition - 2017\Chapter04\Chapter04\Views\Home\Components\TagCloud\Default.cshtml"
WriteAttributeValue("", 107, item.Url, 107, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("class", " class=\"", 117, "\"", 158, 1);
#nullable restore
#line 6 "D:\dev\cs\code for Ciliberti J. - ASP.NET Core Recipes, 2nd Edition - 2017\Chapter04\Chapter04\Views\Home\Components\TagCloud\Default.cshtml"
WriteAttributeValue("", 125, Model.GetLinkItemClassName(item), 125, 33, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 6 "D:\dev\cs\code for Ciliberti J. - ASP.NET Core Recipes, 2nd Edition - 2017\Chapter04\Chapter04\Views\Home\Components\TagCloud\Default.cshtml"
                                                                 Write(item.DisplayText);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n");
#nullable restore
#line 7 "D:\dev\cs\code for Ciliberti J. - ASP.NET Core Recipes, 2nd Edition - 2017\Chapter04\Chapter04\Views\Home\Components\TagCloud\Default.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TagCloud> Html { get; private set; }
    }
}
#pragma warning restore 1591
