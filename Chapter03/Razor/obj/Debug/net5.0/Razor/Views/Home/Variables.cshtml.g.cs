#pragma checksum "D:\dev\cs\code for Ciliberti J. - ASP.NET Core Recipes, 2nd Edition - 2017\Chapter03\Razor\Views\Home\Variables.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d63db1cbe60bcf101ad61b549689a2db143ed517"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Variables), @"mvc.1.0.view", @"/Views/Home/Variables.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d63db1cbe60bcf101ad61b549689a2db143ed517", @"/Views/Home/Variables.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fc4a001eb163016710cb6ff29c4698538c16c9e9", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Variables : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Guitar>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\dev\cs\code for Ciliberti J. - ASP.NET Core Recipes, 2nd Edition - 2017\Chapter03\Razor\Views\Home\Variables.cshtml"
   
    ViewBag.Title = "Variables";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2>Variables</h2>\r\n<h3>Print var</h3>\r\n<pre>&lt;span&gt;It is ");
            WriteLiteral("@DateTime.Now now&lt;/span&gt;</pre>\r\n<span>It is ");
#nullable restore
#line 10 "D:\dev\cs\code for Ciliberti J. - ASP.NET Core Recipes, 2nd Edition - 2017\Chapter03\Razor\Views\Home\Variables.cshtml"
       Write(DateTime.Now);

#line default
#line hidden
#nullable disable
            WriteLiteral(" now</span>\r\n\r\n<h3>Print date with string format</h3>\r\n<pre>&lt;span&gt;It is ");
            WriteLiteral("@DateTime.Now.ToString(\"D\") now&lt;/span&gt;</pre>\r\n<pre>&lt;span&gt;It is ");
            WriteLiteral("@DateTime.Now.ToString(\"d\") now&lt;/span&gt;</pre>\r\n<span>It is ");
#nullable restore
#line 15 "D:\dev\cs\code for Ciliberti J. - ASP.NET Core Recipes, 2nd Edition - 2017\Chapter03\Razor\Views\Home\Variables.cshtml"
       Write(DateTime.Now.ToString("D"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" now</span>\r\n<span>It is ");
#nullable restore
#line 16 "D:\dev\cs\code for Ciliberti J. - ASP.NET Core Recipes, 2nd Edition - 2017\Chapter03\Razor\Views\Home\Variables.cshtml"
       Write(DateTime.Now.ToString("d"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" now</span>\r\n\r\n<h3>Show result of method</h3>\r\n<pre>&lt;span&gt;1973 was a leap year = ");
            WriteLiteral("@DateTime.IsLeapYear(1973)&lt;/span&gt;</pre>\r\n<span>1973 was a leap year = ");
#nullable restore
#line 20 "D:\dev\cs\code for Ciliberti J. - ASP.NET Core Recipes, 2nd Edition - 2017\Chapter03\Razor\Views\Home\Variables.cshtml"
                        Write(DateTime.IsLeapYear(1973));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n<br />\r\n\r\n<h3>Show results of C# expr</h3>\r\n<pre>&lt;span&gt;2 + 2 = ");
            WriteLiteral("@(2 + 2)&lt;/span&gt;</pre>\r\n<span>2 + 2 = ");
#nullable restore
#line 25 "D:\dev\cs\code for Ciliberti J. - ASP.NET Core Recipes, 2nd Edition - 2017\Chapter03\Razor\Views\Home\Variables.cshtml"
          Write(2 + 2);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n<br />\r\n\r\n<h3>Show model data</h3>\r\n<pre>&lt;span&gt;Loaded guitar entity is ");
            WriteLiteral("@Model.Brand ");
#nullable restore
#line 29 "D:\dev\cs\code for Ciliberti J. - ASP.NET Core Recipes, 2nd Edition - 2017\Chapter03\Razor\Views\Home\Variables.cshtml"
                                                  Write(Model.Model);

#line default
#line hidden
#nullable disable
            WriteLiteral("&lt;/span&gt;</pre>\r\n<span>Loaded guitar entity is a ");
#nullable restore
#line 30 "D:\dev\cs\code for Ciliberti J. - ASP.NET Core Recipes, 2nd Edition - 2017\Chapter03\Razor\Views\Home\Variables.cshtml"
                           Write(Model.Brand);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 30 "D:\dev\cs\code for Ciliberti J. - ASP.NET Core Recipes, 2nd Edition - 2017\Chapter03\Razor\Views\Home\Variables.cshtml"
                                        Write(Model.Model);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n<br />\r\n\r\n<h3>HTML is encoded by default</h3>\r\n<pre>&lt;span&gt;Guitar Description: ");
            WriteLiteral("@Model.Description&lt;/span&gt;</pre>\r\n<span>Guitar Description: ");
#nullable restore
#line 35 "D:\dev\cs\code for Ciliberti J. - ASP.NET Core Recipes, 2nd Edition - 2017\Chapter03\Razor\Views\Home\Variables.cshtml"
                     Write(Model.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n<br />\r\n\r\n<h3>Use Html.Raw() helper to render html</h3>\r\n<pre>&lt;span&gt;Guitar Description: ");
            WriteLiteral("@Model.Description&lt;/span&gt;</pre>\r\n<span>Guitar Description: ");
#nullable restore
#line 40 "D:\dev\cs\code for Ciliberti J. - ASP.NET Core Recipes, 2nd Edition - 2017\Chapter03\Razor\Views\Home\Variables.cshtml"
                     Write(Html.Raw(Model.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n<br />\r\n");
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