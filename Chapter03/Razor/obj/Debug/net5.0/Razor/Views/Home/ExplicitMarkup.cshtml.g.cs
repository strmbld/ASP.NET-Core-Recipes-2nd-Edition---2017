#pragma checksum "D:\dev\cs\code for Ciliberti J. - ASP.NET Core Recipes, 2nd Edition - 2017\Chapter03\Razor\Views\Home\ExplicitMarkup.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "50ca70737cea9a0493571716e55f81e705b1d0c7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_ExplicitMarkup), @"mvc.1.0.view", @"/Views/Home/ExplicitMarkup.cshtml")]
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
#line 1 "D:\dev\cs\code for Ciliberti J. - ASP.NET Core Recipes, 2nd Edition - 2017\Chapter03\Razor\Views\_ViewImports.cshtml"
using Razor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\dev\cs\code for Ciliberti J. - ASP.NET Core Recipes, 2nd Edition - 2017\Chapter03\Razor\Views\_ViewImports.cshtml"
using Razor.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"50ca70737cea9a0493571716e55f81e705b1d0c7", @"/Views/Home/ExplicitMarkup.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fc4a001eb163016710cb6ff29c4698538c16c9e9", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_ExplicitMarkup : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Guitar>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\dev\cs\code for Ciliberti J. - ASP.NET Core Recipes, 2nd Edition - 2017\Chapter03\Razor\Views\Home\ExplicitMarkup.cshtml"
  
    string title = "Explicit Markup";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>");
#nullable restore
#line 7 "D:\dev\cs\code for Ciliberti J. - ASP.NET Core Recipes, 2nd Edition - 2017\Chapter03\Razor\Views\Home\ExplicitMarkup.cshtml"
Write(title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n<pre>\r\n");
            WriteLiteral("@if (6 == 6)\r\n{\r\n    ");
            WriteLiteral("@: ");
            WriteLiteral("@Model.Brand ");
            WriteLiteral("@Model.Model has ");
            WriteLiteral("@Model.Strings.Count strings\r\n\r\n<text>\r\n    Only best guitar players play on ");
            WriteLiteral("@Model.Brand\r\n    and bla blabla\r\n</text>\r\n}\r\n</pre>\r\n\r\n");
#nullable restore
#line 20 "D:\dev\cs\code for Ciliberti J. - ASP.NET Core Recipes, 2nd Edition - 2017\Chapter03\Razor\Views\Home\ExplicitMarkup.cshtml"
 if (6 == 6)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    ");
            WriteLiteral(" ");
#nullable restore
#line 22 "D:\dev\cs\code for Ciliberti J. - ASP.NET Core Recipes, 2nd Edition - 2017\Chapter03\Razor\Views\Home\ExplicitMarkup.cshtml"
  Write(Model.Brand);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 22 "D:\dev\cs\code for Ciliberti J. - ASP.NET Core Recipes, 2nd Edition - 2017\Chapter03\Razor\Views\Home\ExplicitMarkup.cshtml"
               Write(Model.Model);

#line default
#line hidden
#nullable disable
            WriteLiteral(" has ");
#nullable restore
#line 22 "D:\dev\cs\code for Ciliberti J. - ASP.NET Core Recipes, 2nd Edition - 2017\Chapter03\Razor\Views\Home\ExplicitMarkup.cshtml"
                                Write(Model.Strings.Count);

#line default
#line hidden
#nullable disable
            WriteLiteral(" strings\r\n");
            WriteLiteral("\r\n        Only best guitar players play on ");
#nullable restore
#line 26 "D:\dev\cs\code for Ciliberti J. - ASP.NET Core Recipes, 2nd Edition - 2017\Chapter03\Razor\Views\Home\ExplicitMarkup.cshtml"
                                    Write(Model.Brand);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n        and bla blabla\r\n    ");
#nullable restore
#line 28 "D:\dev\cs\code for Ciliberti J. - ASP.NET Core Recipes, 2nd Edition - 2017\Chapter03\Razor\Views\Home\ExplicitMarkup.cshtml"
           
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Guitar> Html { get; private set; }
    }
}
#pragma warning restore 1591
