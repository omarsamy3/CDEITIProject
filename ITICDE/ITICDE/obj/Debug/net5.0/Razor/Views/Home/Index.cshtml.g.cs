#pragma checksum "E:\A1Programming\1My.CEI Program\Project\CDEITIProject\ITICDE\ITICDE\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5b444493c446b29753c53862d3e8bcd3975818a1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "E:\A1Programming\1My.CEI Program\Project\CDEITIProject\ITICDE\ITICDE\Views\_ViewImports.cshtml"
using ITICDE;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\A1Programming\1My.CEI Program\Project\CDEITIProject\ITICDE\ITICDE\Views\_ViewImports.cshtml"
using ITICDE.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\A1Programming\1My.CEI Program\Project\CDEITIProject\ITICDE\ITICDE\Views\_ViewImports.cshtml"
using ITICDE.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "E:\A1Programming\1My.CEI Program\Project\CDEITIProject\ITICDE\ITICDE\Views\_ViewImports.cshtml"
using ITICDE.Enums;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "E:\A1Programming\1My.CEI Program\Project\CDEITIProject\ITICDE\ITICDE\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "E:\A1Programming\1My.CEI Program\Project\CDEITIProject\ITICDE\ITICDE\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5b444493c446b29753c53862d3e8bcd3975818a1", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7b2cd2ffe7b3021a4c86954be0160b30368a6171", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("hold-transition layout-top-nav"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "E:\A1Programming\1My.CEI Program\Project\CDEITIProject\ITICDE\ITICDE\Views\Home\Index.cshtml"
  
    Layout = "";

#line default
#line hidden
#nullable disable
            WriteLiteral("<!DOCTYPE html>\n<!--\nThis is a starter template page. Use this page to start your new project from\nscratch. This page gets rid of all links and provides the needed markup only.\n-->\n<html lang=\"en\">\n\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5b444493c446b29753c53862d3e8bcd3975818a14878", async() => {
                WriteLiteral(@"
    <meta charset=""utf-8"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1"">
    <title>Bay Bridge</title>
    <link rel=""shortcut icon"" href=""/dist/img/logo 128x128.ico"" />
    <!-- Google Font: Source Sans Pro -->
    <link rel=""stylesheet""
        href=""https://fonts.googleapis.com/css?family=Source+Sans+Pro:300,400,400i,700&display=fallback"">
    <!-- Font Awesome Icons -->
    <link rel=""stylesheet"" href=""../../plugins/fontawesome-free/css/all.min.css"">
    <!-- Theme style -->
    <link rel=""stylesheet"" href=""../../dist/css/adminlte.min.css"">
");
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
            WriteLiteral("\n\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5b444493c446b29753c53862d3e8bcd3975818a16442", async() => {
                WriteLiteral(@"
    <div class=""wrapper"">

        <!-- Navbar -->
        <nav class=""main-header navbar navbar-expand-md navbar-light navbar-white"">
            <div class=""container"">
                <a href=""#"" class=""navbar-brand"">
                    <img style=""width:50px;display:inline;"" src=""/dist/img/logo 128x128.png""/> &nbsp;
");
                WriteLiteral("                        <h3 style=\"display:inline\">Bay Bridge</h3>\n");
                WriteLiteral(@"                </a>

                <button class=""navbar-toggler order-1"" type=""button"" data-toggle=""collapse""
                    data-target=""#navbarCollapse"" aria-controls=""navbarCollapse"" aria-expanded=""false""
                    aria-label=""Toggle navigation"">
                    <span class=""navbar-toggler-icon""></span>
                </button>

                <div class=""collapse navbar-collapse order-3"" id=""navbarCollapse"">
                    <!-- Left navbar links -->
                    <ul class=""navbar-nav"">


                    </ul>


                </div>

                <!-- Right navbar links -->
                <ul class=""order-1 order-md-3 navbar-nav navbar-no-expand ml-auto"">
                    <li class=""nav-item"">
                        <a href=""../../Account/Login"" class=""nav-link"">Login</a>
                    </li>
                    <li class=""nav-item"">
                        <a href=""../../Account/Register"" class=""nav-link"">Register</a>
                    </li>
      ");
                WriteLiteral(@"          </ul>
            </div>
        </nav>
        <!-- /.navbar -->

        <!-- Content Wrapper. Contains page content -->
        <div class=""content-wrapper"">
            <!-- Content Header (Page header) -->
            <div class=""content"" style=""height: 400px;"">
                <div class=""container"">

                    <div class=""row  "" style=""height: 400px;"" >
                        <!-- <div class=""col-sm text-center""> -->
                            <div
                            class=""bg-image p-5 text-center shadow-1-strong rounded mb-5 text-white col-12  vcenter-item ""
                            style=""background-image: url('/dist/img/Welcome.jpg'); background-size: cover;
    background-position: 0 -100;""
                          >
                          <div style="" background-color:rgba(0,0,0,0.5); display: inline-block; position: absolute; top: 133px; left: 400px;"">
                            <h1  class=""m-2  vcenter-item""> Welcome <small>To Bay Bridge</small></h1>
     ");
                WriteLiteral(@"                       <h3  class=""m-2  vcenter-item""> Thank You For Your Trust</h3>
                            <!-- <img src=""../../dist/img/photo4.jpg"" class=""img-fluid"" alt=""...""> -->
                        </div>
                        </div>

                    </div><!-- /.row -->
                </div><!-- /.container-fluid -->
            </div>
            <!-- /.content-header -->

            <!-- Main content -->
            <div class=""content"">
                <div class=""container"">
                    <div class=""row"">
                        <div class=""col-lg-4"">
                            <div class=""card "">
                                <img src=""/dist/img/FileManager.jpg"" class=""card-img-top rounded-top"" style=""height:244px;""alt=""..."">
                                <div class=""card-body"">
                                    <h5 class="" text-center"">File Explorer</h5>
                                  
                                    <p class=""card-text"">
                     ");
                WriteLiteral(@"                   Sharing all the project files among all its parties and in one place to be easy to deal with them, and keep up with the project progress.
                                    </p>

                                   
                                </div>
                            </div>

                            <!-- /.card -->
                        </div>
                        <div class=""col-lg-4"">
                            <div class=""card"">
                                <img src=""/dist/img/Viewer.png"" class=""card-img-top rounded-top"" style=""height:244px;"" alt=""..."">

                                <div class=""card-body "">
                                    <h5 class="" text-center "">Files Viewer</h5>

                                    <p class=""card-text"">
                                        Display all files like PDF, Img, Videos, and also the IFC files to show the project models and navigate their progress.
                                    </p>

                ");
                WriteLiteral(@"                
                                </div>
                            </div>
                        </div>
                        <!-- /.card -->
                        <div class=""col-lg-4"">
                            <div class=""card"">
                                
                                <img src=""/dist/img/Task.jpg"" class=""card-img-top rounded-top "" style=""height:244px;"" alt=""..."">
                               
                                <div class=""card-body"">
                                    <h5  class="" text-center"">Assign Tasks</h5>

                                    <p class=""card-text"">
                                        Assign tasks for the project parties and also you can make teams with some required tasks and keep up with their progress.
                                    </p>

                                </div>
                            </div>

                            <!-- /.card -->
                        </div>
                       
");
                WriteLiteral(@"
                        <!-- /.col-md-6 -->
                    </div>
                    <!-- /.row -->
                </div><!-- /.container-fluid -->
            </div>
            <!-- /.content -->
        </div>
        <!-- /.content-wrapper -->

        <!-- Control Sidebar -->

        <!-- /.control-sidebar -->


    </div>
    <!-- ./wrapper -->

    <!-- REQUIRED SCRIPTS -->

    <!-- jQuery -->
    <script src=""../../plugins/jquery/jquery.min.js""></script>
    <!-- Bootstrap 4 -->
    <script src=""../../plugins/bootstrap/js/bootstrap.bundle.min.js""></script>
    <!-- AdminLTE App -->
    <script src=""../../dist/js/adminlte.min.js""></script>
    <!-- AdminLTE for demo purposes -->
    <script src=""../../dist/js/demo.js""></script>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n\n</html>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
