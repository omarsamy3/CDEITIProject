#pragma checksum "D:\iti data\Final Project Data\Code\After Adding Template\Trial 7 24-6-2022\ITICDE\ITICDE\Views\Project\ViewUser.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8c4cd88ef1ac552251943d11dd3dfea3c6b53e52"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Project_ViewUser), @"mvc.1.0.view", @"/Views/Project/ViewUser.cshtml")]
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
#line 1 "D:\iti data\Final Project Data\Code\After Adding Template\Trial 7 24-6-2022\ITICDE\ITICDE\Views\_ViewImports.cshtml"
using ITICDE;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\iti data\Final Project Data\Code\After Adding Template\Trial 7 24-6-2022\ITICDE\ITICDE\Views\_ViewImports.cshtml"
using ITICDE.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\iti data\Final Project Data\Code\After Adding Template\Trial 7 24-6-2022\ITICDE\ITICDE\Views\_ViewImports.cshtml"
using ITICDE.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\iti data\Final Project Data\Code\After Adding Template\Trial 7 24-6-2022\ITICDE\ITICDE\Views\_ViewImports.cshtml"
using ITICDE.Enums;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\iti data\Final Project Data\Code\After Adding Template\Trial 7 24-6-2022\ITICDE\ITICDE\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\iti data\Final Project Data\Code\After Adding Template\Trial 7 24-6-2022\ITICDE\ITICDE\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "D:\iti data\Final Project Data\Code\After Adding Template\Trial 7 24-6-2022\ITICDE\ITICDE\Views\Project\ViewUser.cshtml"
using System.Security.Claims;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8c4cd88ef1ac552251943d11dd3dfea3c6b53e52", @"/Views/Project/ViewUser.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7b2cd2ffe7b3021a4c86954be0160b30368a6171", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Project_ViewUser : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ITICDE.Models.User>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DeleteUser", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-info btn-sm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Folders", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-dark"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddUser", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-secondary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "D:\iti data\Final Project Data\Code\After Adding Template\Trial 7 24-6-2022\ITICDE\ITICDE\Views\Project\ViewUser.cshtml"
  var ThisProject = (ITICDE.Models.Project)ViewBag.project;
var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 7 "D:\iti data\Final Project Data\Code\After Adding Template\Trial 7 24-6-2022\ITICDE\ITICDE\Views\Project\ViewUser.cshtml"
  
    ViewData["Title"] = "ViewUser";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>");
#nullable restore
#line 11 "D:\iti data\Final Project Data\Code\After Adding Template\Trial 7 24-6-2022\ITICDE\ITICDE\Views\Project\ViewUser.cshtml"
Write(ThisProject.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" users</h1>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8c4cd88ef1ac552251943d11dd3dfea3c6b53e528045", async() => {
                WriteLiteral("\r\n    <script src=\"https://kit.fontawesome.com/056ba6c557.js\" crossorigin=\"anonymous\"></script>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n\r\n");
#nullable restore
#line 17 "D:\iti data\Final Project Data\Code\After Adding Template\Trial 7 24-6-2022\ITICDE\ITICDE\Views\Project\ViewUser.cshtml"
  if (ThisProject.Users.Count==0)
{}
else
{ 

#line default
#line hidden
#nullable disable
            WriteLiteral("    <table class=\"table\">\r\n        <thead>\r\n            <tr>\r\n                <th></th>\r\n                <th>\r\n                    ");
#nullable restore
#line 26 "D:\iti data\Final Project Data\Code\After Adding Template\Trial 7 24-6-2022\ITICDE\ITICDE\Views\Project\ViewUser.cshtml"
               Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 29 "D:\iti data\Final Project Data\Code\After Adding Template\Trial 7 24-6-2022\ITICDE\ITICDE\Views\Project\ViewUser.cshtml"
               Write(Html.DisplayNameFor(model => model.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 32 "D:\iti data\Final Project Data\Code\After Adding Template\Trial 7 24-6-2022\ITICDE\ITICDE\Views\Project\ViewUser.cshtml"
               Write(Html.DisplayNameFor(model => model.Position));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    Organization Type\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 38 "D:\iti data\Final Project Data\Code\After Adding Template\Trial 7 24-6-2022\ITICDE\ITICDE\Views\Project\ViewUser.cshtml"
               Write(Html.DisplayNameFor(model => model.Discipline));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th></th>\r\n            </tr>\r\n        </thead>\r\n        <tbody>\r\n        \r\n");
#nullable restore
#line 45 "D:\iti data\Final Project Data\Code\After Adding Template\Trial 7 24-6-2022\ITICDE\ITICDE\Views\Project\ViewUser.cshtml"
         foreach (var item in Model)
            {
                if (item.WorkonProjects.Contains(ThisProject))
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td><i class=\"fas fa-user\"></i></td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 52 "D:\iti data\Final Project Data\Code\After Adding Template\Trial 7 24-6-2022\ITICDE\ITICDE\Views\Project\ViewUser.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 55 "D:\iti data\Final Project Data\Code\After Adding Template\Trial 7 24-6-2022\ITICDE\ITICDE\Views\Project\ViewUser.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 58 "D:\iti data\Final Project Data\Code\After Adding Template\Trial 7 24-6-2022\ITICDE\ITICDE\Views\Project\ViewUser.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Position));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 61 "D:\iti data\Final Project Data\Code\After Adding Template\Trial 7 24-6-2022\ITICDE\ITICDE\Views\Project\ViewUser.cshtml"
                       Write(Html.DisplayFor(modelItem => item.OrganizationType));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 64 "D:\iti data\Final Project Data\Code\After Adding Template\Trial 7 24-6-2022\ITICDE\ITICDE\Views\Project\ViewUser.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Discipline));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n");
#nullable restore
#line 66 "D:\iti data\Final Project Data\Code\After Adding Template\Trial 7 24-6-2022\ITICDE\ITICDE\Views\Project\ViewUser.cshtml"
                          
                            
                            if (userId == ThisProject.CreatorUserId)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <td>\r\n                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8c4cd88ef1ac552251943d11dd3dfea3c6b53e5214139", async() => {
                WriteLiteral(" \r\n                                        <i class=\"fa-solid fa-user-slash\"></i> &nbsp; Delete");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-ProjectUser", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 71 "D:\iti data\Final Project Data\Code\After Adding Template\Trial 7 24-6-2022\ITICDE\ITICDE\Views\Project\ViewUser.cshtml"
                                                                          WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["ProjectUser"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-ProjectUser", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["ProjectUser"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 72 "D:\iti data\Final Project Data\Code\After Adding Template\Trial 7 24-6-2022\ITICDE\ITICDE\Views\Project\ViewUser.cshtml"
                         WriteLiteral(ThisProject.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["projectId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-projectId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["projectId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("  \r\n                                </td>\r\n");
#nullable restore
#line 75 "D:\iti data\Final Project Data\Code\After Adding Template\Trial 7 24-6-2022\ITICDE\ITICDE\Views\Project\ViewUser.cshtml"
                            }
                        

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </tr>\r\n");
#nullable restore
#line 78 "D:\iti data\Final Project Data\Code\After Adding Template\Trial 7 24-6-2022\ITICDE\ITICDE\Views\Project\ViewUser.cshtml"
                }
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n");
#nullable restore
#line 82 "D:\iti data\Final Project Data\Code\After Adding Template\Trial 7 24-6-2022\ITICDE\ITICDE\Views\Project\ViewUser.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<hr />\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8c4cd88ef1ac552251943d11dd3dfea3c6b53e5218239", async() => {
                WriteLiteral(" \r\n    <i class=\"fa-regular fa-building\"></i> Go To project ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-projectId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 85 "D:\iti data\Final Project Data\Code\After Adding Template\Trial 7 24-6-2022\ITICDE\ITICDE\Views\Project\ViewUser.cshtml"
                                                         WriteLiteral(ThisProject.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["projectId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-projectId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["projectId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    &nbsp;&nbsp;\r\n");
#nullable restore
#line 88 "D:\iti data\Final Project Data\Code\After Adding Template\Trial 7 24-6-2022\ITICDE\ITICDE\Views\Project\ViewUser.cshtml"
  if (ThisProject.CreatorUserId == userId)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8c4cd88ef1ac552251943d11dd3dfea3c6b53e5221136", async() => {
                WriteLiteral(" \r\n            <i class=\"fa-solid fa-user-plus\"></i> Add Users");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-projectId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 90 "D:\iti data\Final Project Data\Code\After Adding Template\Trial 7 24-6-2022\ITICDE\ITICDE\Views\Project\ViewUser.cshtml"
                                     WriteLiteral(ThisProject.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["projectId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-projectId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["projectId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 92 "D:\iti data\Final Project Data\Code\After Adding Template\Trial 7 24-6-2022\ITICDE\ITICDE\Views\Project\ViewUser.cshtml"
    }
    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8c4cd88ef1ac552251943d11dd3dfea3c6b53e5223766", async() => {
                WriteLiteral(" \r\n            <i class=\"icon fas fa-info\"></i> &nbsp;Details ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 95 "D:\iti data\Final Project Data\Code\After Adding Template\Trial 7 24-6-2022\ITICDE\ITICDE\Views\Project\ViewUser.cshtml"
                                  WriteLiteral(ThisProject.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 97 "D:\iti data\Final Project Data\Code\After Adding Template\Trial 7 24-6-2022\ITICDE\ITICDE\Views\Project\ViewUser.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public Microsoft.AspNetCore.Http.IHttpContextAccessor HttpContextAccessor { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public UserManager<User> UserManager { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public SignInManager<User> SignInManager { get; private set; } = default!;
        #nullable disable
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