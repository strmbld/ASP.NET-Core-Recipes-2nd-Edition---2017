#pragma checksum "D:\dev\cs\code for Ciliberti J. - ASP.NET Core Recipes, 2nd Edition - 2017\Chapter03\Razor\Views\Home\StronglyTypedHtmlHelpers.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "89bc5b29d6726539055856f39920764bd5d8044a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_StronglyTypedHtmlHelpers), @"mvc.1.0.view", @"/Views/Home/StronglyTypedHtmlHelpers.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"89bc5b29d6726539055856f39920764bd5d8044a", @"/Views/Home/StronglyTypedHtmlHelpers.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fc4a001eb163016710cb6ff29c4698538c16c9e9", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_StronglyTypedHtmlHelpers : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<LoginViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\dev\cs\code for Ciliberti J. - ASP.NET Core Recipes, 2nd Edition - 2017\Chapter03\Razor\Views\Home\StronglyTypedHtmlHelpers.cshtml"
 using (Html.BeginForm())
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\dev\cs\code for Ciliberti J. - ASP.NET Core Recipes, 2nd Edition - 2017\Chapter03\Razor\Views\Home\StronglyTypedHtmlHelpers.cshtml"
Write(Html.ValidationSummary());

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"form-group\">\r\n        ");
#nullable restore
#line 8 "D:\dev\cs\code for Ciliberti J. - ASP.NET Core Recipes, 2nd Edition - 2017\Chapter03\Razor\Views\Home\StronglyTypedHtmlHelpers.cshtml"
   Write(Html.LabelFor(m => m.EmailAddress));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 9 "D:\dev\cs\code for Ciliberti J. - ASP.NET Core Recipes, 2nd Edition - 2017\Chapter03\Razor\Views\Home\StronglyTypedHtmlHelpers.cshtml"
   Write(Html.TextBoxFor(m => m.EmailAddress,
         new { placeholder = "Enter email", @class = "form-control", type = "email" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n    <div class=\"form-group\">\r\n        ");
#nullable restore
#line 13 "D:\dev\cs\code for Ciliberti J. - ASP.NET Core Recipes, 2nd Edition - 2017\Chapter03\Razor\Views\Home\StronglyTypedHtmlHelpers.cshtml"
   Write(Html.LabelFor(m => m.Password));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 14 "D:\dev\cs\code for Ciliberti J. - ASP.NET Core Recipes, 2nd Edition - 2017\Chapter03\Razor\Views\Home\StronglyTypedHtmlHelpers.cshtml"
   Write(Html.PasswordFor(m => m.Password,
         new { placeholder = "Enter password", @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n    <div class=\"checkbox\">\r\n        <label>\r\n            ");
#nullable restore
#line 19 "D:\dev\cs\code for Ciliberti J. - ASP.NET Core Recipes, 2nd Edition - 2017\Chapter03\Razor\Views\Home\StronglyTypedHtmlHelpers.cshtml"
       Write(Html.CheckBoxFor(m => m.RememberMe));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            Remember me\r\n        </label>\r\n    </div>\r\n    <button type=\"submit\" class=\"btn btn-primary\">Submit</button>\r\n");
#nullable restore
#line 24 "D:\dev\cs\code for Ciliberti J. - ASP.NET Core Recipes, 2nd Edition - 2017\Chapter03\Razor\Views\Home\StronglyTypedHtmlHelpers.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<LoginViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
