#pragma checksum "D:\dev\cs\code for Ciliberti J. - ASP.NET Core Recipes, 2nd Edition - 2017\Chapter03\Razor\Views\Home\HtmlHelper.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "df130f3bc0c60d4b78350ef3efdd65256ecee69b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_HtmlHelper), @"mvc.1.0.view", @"/Views/Home/HtmlHelper.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"df130f3bc0c60d4b78350ef3efdd65256ecee69b", @"/Views/Home/HtmlHelper.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fc4a001eb163016710cb6ff29c4698538c16c9e9", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_HtmlHelper : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Guitar>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\dev\cs\code for Ciliberti J. - ASP.NET Core Recipes, 2nd Edition - 2017\Chapter03\Razor\Views\Home\HtmlHelper.cshtml"
 using (Html.BeginForm())
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\dev\cs\code for Ciliberti J. - ASP.NET Core Recipes, 2nd Edition - 2017\Chapter03\Razor\Views\Home\HtmlHelper.cshtml"
Write(Html.ValidationSummary());

#line default
#line hidden
#nullable disable
            WriteLiteral("    <fieldset>\r\n        <legend>New Guitar</legend>\r\n        <ul class=\"list-unstyled\">\r\n            <li class=\"form-group\">\r\n                ");
#nullable restore
#line 11 "D:\dev\cs\code for Ciliberti J. - ASP.NET Core Recipes, 2nd Edition - 2017\Chapter03\Razor\Views\Home\HtmlHelper.cshtml"
           Write(Html.LabelFor(m => m.Brand));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 12 "D:\dev\cs\code for Ciliberti J. - ASP.NET Core Recipes, 2nd Edition - 2017\Chapter03\Razor\Views\Home\HtmlHelper.cshtml"
           Write(Html.TextBoxFor(m => m.Brand));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </li>\r\n            <li class=\"form-group\">\r\n                ");
#nullable restore
#line 15 "D:\dev\cs\code for Ciliberti J. - ASP.NET Core Recipes, 2nd Edition - 2017\Chapter03\Razor\Views\Home\HtmlHelper.cshtml"
           Write(Html.LabelFor(m => m.Model));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 16 "D:\dev\cs\code for Ciliberti J. - ASP.NET Core Recipes, 2nd Edition - 2017\Chapter03\Razor\Views\Home\HtmlHelper.cshtml"
           Write(Html.TextBoxFor(m => m.Model));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </li>\r\n            <li class=\"form-group\">\r\n                ");
#nullable restore
#line 19 "D:\dev\cs\code for Ciliberti J. - ASP.NET Core Recipes, 2nd Edition - 2017\Chapter03\Razor\Views\Home\HtmlHelper.cshtml"
           Write(Html.LabelFor(m => m.HasWhammyBar));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 20 "D:\dev\cs\code for Ciliberti J. - ASP.NET Core Recipes, 2nd Edition - 2017\Chapter03\Razor\Views\Home\HtmlHelper.cshtml"
           Write(Html.CheckBoxFor(m => m.HasWhammyBar));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </li>\r\n        </ul>\r\n        <input type=\"submit\" value=\"Save\" class=\"btn btn-primary\" />\r\n    </fieldset>\r\n");
#nullable restore
#line 25 "D:\dev\cs\code for Ciliberti J. - ASP.NET Core Recipes, 2nd Edition - 2017\Chapter03\Razor\Views\Home\HtmlHelper.cshtml"
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
