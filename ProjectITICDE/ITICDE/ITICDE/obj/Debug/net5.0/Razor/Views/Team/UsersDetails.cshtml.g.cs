#pragma checksum "E:\A1Programming\1My.CEI Program\Project\CDEITIProject\ProjectITICDE\ITICDE\ITICDE\Views\Team\UsersDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c6e768a027dd8e2e9bc800407074773a7caed947"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Team_UsersDetails), @"mvc.1.0.view", @"/Views/Team/UsersDetails.cshtml")]
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
#line 1 "E:\A1Programming\1My.CEI Program\Project\CDEITIProject\ProjectITICDE\ITICDE\ITICDE\Views\_ViewImports.cshtml"
using ITICDE;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\A1Programming\1My.CEI Program\Project\CDEITIProject\ProjectITICDE\ITICDE\ITICDE\Views\_ViewImports.cshtml"
using ITICDE.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c6e768a027dd8e2e9bc800407074773a7caed947", @"/Views/Team/UsersDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a0e79c1c365f83f179a037dd7d262446ddbb1b96", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Team_UsersDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ITICDE.Models.User>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "E:\A1Programming\1My.CEI Program\Project\CDEITIProject\ProjectITICDE\ITICDE\ITICDE\Views\Team\UsersDetails.cshtml"
  
    ViewData["Title"] = "UsersDetails";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Team Data</h1>\r\n\r\n<div class=\"table-responsive\">\r\n    <table class=\"table\">\r\n        <thead>\r\n            <tr>\r\n                <th>\r\n                    ");
#nullable restore
#line 14 "E:\A1Programming\1My.CEI Program\Project\CDEITIProject\ProjectITICDE\ITICDE\ITICDE\Views\Team\UsersDetails.cshtml"
               Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 17 "E:\A1Programming\1My.CEI Program\Project\CDEITIProject\ProjectITICDE\ITICDE\ITICDE\Views\Team\UsersDetails.cshtml"
               Write(Html.DisplayNameFor(model => model.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 20 "E:\A1Programming\1My.CEI Program\Project\CDEITIProject\ProjectITICDE\ITICDE\ITICDE\Views\Team\UsersDetails.cshtml"
               Write(Html.DisplayNameFor(model => model.Role));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 23 "E:\A1Programming\1My.CEI Program\Project\CDEITIProject\ProjectITICDE\ITICDE\ITICDE\Views\Team\UsersDetails.cshtml"
               Write(Html.DisplayNameFor(model => model.OrganizationType));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n\t\t\t\t<th>\r\n                    ");
#nullable restore
#line 26 "E:\A1Programming\1My.CEI Program\Project\CDEITIProject\ProjectITICDE\ITICDE\ITICDE\Views\Team\UsersDetails.cshtml"
               Write(Html.DisplayNameFor(model => model.Discipline));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th></th>\r\n            </tr>\r\n        </thead>\r\n        <tbody>\r\n");
#nullable restore
#line 32 "E:\A1Programming\1My.CEI Program\Project\CDEITIProject\ProjectITICDE\ITICDE\ITICDE\Views\Team\UsersDetails.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>\r\n                        ");
#nullable restore
#line 36 "E:\A1Programming\1My.CEI Program\Project\CDEITIProject\ProjectITICDE\ITICDE\ITICDE\Views\Team\UsersDetails.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 39 "E:\A1Programming\1My.CEI Program\Project\CDEITIProject\ProjectITICDE\ITICDE\ITICDE\Views\Team\UsersDetails.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 42 "E:\A1Programming\1My.CEI Program\Project\CDEITIProject\ProjectITICDE\ITICDE\ITICDE\Views\Team\UsersDetails.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Role));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 45 "E:\A1Programming\1My.CEI Program\Project\CDEITIProject\ProjectITICDE\ITICDE\ITICDE\Views\Team\UsersDetails.cshtml"
                   Write(Html.DisplayFor(modelItem => item.OrganizationType));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 48 "E:\A1Programming\1My.CEI Program\Project\CDEITIProject\ProjectITICDE\ITICDE\ITICDE\Views\Team\UsersDetails.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Discipline));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                </tr>\r\n");
#nullable restore
#line 52 "E:\A1Programming\1My.CEI Program\Project\CDEITIProject\ProjectITICDE\ITICDE\ITICDE\Views\Team\UsersDetails.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n</div>\r\n\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ITICDE.Models.User>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
