#pragma checksum "D:\dev\cs\code for Ciliberti J. - ASP.NET Core Recipes, 2nd Edition - 2017\Chapter03\Razor\Views\Home\StandardHtmlHelpers.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cc0f0a381c79326fa78792e65c9a5cdd987b148b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_StandardHtmlHelpers), @"mvc.1.0.view", @"/Views/Home/StandardHtmlHelpers.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cc0f0a381c79326fa78792e65c9a5cdd987b148b", @"/Views/Home/StandardHtmlHelpers.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fc4a001eb163016710cb6ff29c4698538c16c9e9", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_StandardHtmlHelpers : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<h1>Login form with html helpers</h1>\r\nStandard HTML helpers usage for building forms\r\n\r\n<h2>Please log-in</h2>\r\n\r\n");
#nullable restore
#line 6 "D:\dev\cs\code for Ciliberti J. - ASP.NET Core Recipes, 2nd Edition - 2017\Chapter03\Razor\Views\Home\StandardHtmlHelpers.cshtml"
 using (Html.BeginForm("StandardHtmlHelpers", "Home", FormMethod.Post)) 

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\dev\cs\code for Ciliberti J. - ASP.NET Core Recipes, 2nd Edition - 2017\Chapter03\Razor\Views\Home\StandardHtmlHelpers.cshtml"
                                                                                                                        
{

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"form-group\">\r\n    ");
#nullable restore
#line 9 "D:\dev\cs\code for Ciliberti J. - ASP.NET Core Recipes, 2nd Edition - 2017\Chapter03\Razor\Views\Home\StandardHtmlHelpers.cshtml"
Write(Html.Label("exampleInputEmail", "Email address"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
            WriteLiteral("\r\n    ");
#nullable restore
#line 10 "D:\dev\cs\code for Ciliberti J. - ASP.NET Core Recipes, 2nd Edition - 2017\Chapter03\Razor\Views\Home\StandardHtmlHelpers.cshtml"
Write(Html.TextBox("exampleInputEmail", "",
     new { placeholder = "Enter email", @class = "form-control", type = "email" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("</div>\r\n    <div class=\"form-group\">\r\n        ");
#nullable restore
#line 15 "D:\dev\cs\code for Ciliberti J. - ASP.NET Core Recipes, 2nd Edition - 2017\Chapter03\Razor\Views\Home\StandardHtmlHelpers.cshtml"
   Write(Html.Label("exampleInputPassword", "Password"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 16 "D:\dev\cs\code for Ciliberti J. - ASP.NET Core Recipes, 2nd Edition - 2017\Chapter03\Razor\Views\Home\StandardHtmlHelpers.cshtml"
   Write(Html.Password("exampleInputPassword", "",
         new { placeholder = "Enter password", @class = "form-control"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n    <div class=\"checkbox\">\r\n        <label>\r\n            ");
#nullable restore
#line 21 "D:\dev\cs\code for Ciliberti J. - ASP.NET Core Recipes, 2nd Edition - 2017\Chapter03\Razor\Views\Home\StandardHtmlHelpers.cshtml"
       Write(Html.CheckBox("Remember me", false));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            Remember me\r\n        </label>\r\n    </div>\r\n    <button type=\"submit\" class=\"btn btn-primary\">Submit</button>\r\n");
#nullable restore
#line 26 "D:\dev\cs\code for Ciliberti J. - ASP.NET Core Recipes, 2nd Edition - 2017\Chapter03\Razor\Views\Home\StandardHtmlHelpers.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
