#pragma checksum "G:\杂项\Me\DemoCore\4.0.1\aspnet-core\src\DemoCore.Web.Mvc\Views\About\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2af00c16eace57eef249c1348c73d3f07e0e7354"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_About_Index), @"mvc.1.0.view", @"/Views/About/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/About/Index.cshtml", typeof(AspNetCore.Views_About_Index))]
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
#line 1 "G:\杂项\Me\DemoCore\4.0.1\aspnet-core\src\DemoCore.Web.Mvc\Views\_ViewImports.cshtml"
using Abp.Localization;

#line default
#line hidden
#line 1 "G:\杂项\Me\DemoCore\4.0.1\aspnet-core\src\DemoCore.Web.Mvc\Views\About\Index.cshtml"
using DemoCore.Web.Startup;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2af00c16eace57eef249c1348c73d3f07e0e7354", @"/Views/About/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"59b606ade4b1b258816958d862bcbe91f3898c03", @"/Views/_ViewImports.cshtml")]
    public class Views_About_Index : DemoCore.Web.Views.DemoCoreRazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "G:\杂项\Me\DemoCore\4.0.1\aspnet-core\src\DemoCore.Web.Mvc\Views\About\Index.cshtml"
  
    ViewBag.CurrentPageName = "Abount"; // The menu item will be active for this page.

#line default
#line hidden
            BeginContext(124, 4938, true);
            WriteLiteral(@"
<div class=""row clearfix"">
    <div class=""col-lg-12 col-md-12 col-sm-12 col-xs-12"">
        <div class=""card"">
            <div class=""header"">
                <h2>
                    About This Template
                </h2>
            </div>
            <div class=""body"">
                <p>
                    This is a simple startup template based on ASP.NET Boilerplate framework and Module Zero.
                    If you need an enterprise startup project, check <a href=""http://aspnetzero.com?ref=abptmpl"" target=""_blank"">ASP.NET ZERO</a>.
                </p>

                <h3>What is ASP.NET Boilerplate?</h3>

                <p>
                    ASP.NET Boilerplate is an application framework built on latest <strong>ASP.NET Core</strong> framework.
                    It makes easy to use authorization, dependency injection, validation, exception handling, localization, logging, caching, background jobs and so on.
                    It's built on already familiar tools ");
            WriteLiteral(@"like Entity Framework, AutoMapper, Castle Windsor...
                </p>

                <p>
                    ASP.NET Boilerplate implements <strong>NLayer architecture</strong> (Domain, Application, Infrastructure and Presentation Layers)
                    and <strong>Domain Driven Design</strong> (Entities, Repositories, Domain/Application Services, DTO's...).
                    Also implements and provides a good infrastructure to implement common software development <strong>best practices</strong>.
                </p>
                
                <h3>What is Module Zero?</h3>

                <p>
                    ASP.NET Boilerplate framework is designed to be independent of any database
                    schema and to be as generic as possible. Therefore, It leaves some concepts
                    <strong>abstract</strong> and <strong>optional</strong> (like audit logging, permission and setting stores)
                    which requires some <strong>data store</strong>");
            WriteLiteral(@".
                </p>
                <p>
                    <strong>Module Zero </strong>implements all fundamental concepts of ASP.NET
                    Boilerplate framework such as <a href=""http://www.aspnetboilerplate.com/Pages/Documents/Zero/Tenant-Management"">tenant management</a> (<strong>multi-tenancy</strong>),
                    <a href=""http://www.aspnetboilerplate.com/Pages/Documents/Zero/Role-Management"">
                        role management
                    </a>, <a href=""http://www.aspnetboilerplate.com/Pages/Documents/Zero/User-Management"">user management</a>,
                    <a href=""http://www.aspnetboilerplate.com/Pages/Documents/Authorization"">authorization</a> (<a href=""http://www.aspnetboilerplate.com/Pages/Documents/Zero/Permission-Management"">
                        permission management
                    </a>),
                    <a href=""http://www.aspnetboilerplate.com/Pages/Documents/Setting-Management"">setting management</a>, <a href=""http://www.aspn");
            WriteLiteral(@"etboilerplate.com/Pages/Documents/Zero/Language-Management"">
                        language management
                    </a>, <a href=""http://www.aspnetboilerplate.com/Pages/Documents/Audit-Logging"">audit logging</a>
                    and so on.
                </p>
                <p>
                    Module-Zero defines entities and implements <strong>domain logic</strong>
                    (domain layer) and leaves application and presentation layers to you.
                </p>

                <h4>Based on Microsoft ASP.NET Core Identity</h4>

                <p>
                    Module Zero is based on Microsoft's
                    <a href=""https://docs.microsoft.com/en-us/aspnet/core/security/authentication/identity"" target=""_blank"">ASP.NET Core Identity</a> library.
                    It extends user and role managers and implements user and role stores using generic repositories.
                </p>

                <h3>Documentation</h3>
                
      ");
            WriteLiteral(@"          <ul>
                    <li>
                        <a href=""https://www.aspnetboilerplate.com/Pages/Documents/Zero/Startup-Template-Core"">Documentation for this template</a>
                    </li>
                    <li>
                        <a href=""http://www.aspnetboilerplate.com/Pages/Documents"">ASP.NET Boilerplate documentation</a> 
                    </li>
                </ul>

                <h3>Source code</h3>

                <p>
                    This template is developed open source on Github. You can contribute to the template. 
                    <a href=""https://github.com/aspnetboilerplate/module-zero-core-template"" target=""_blank"">https://github.com/aspnetboilerplate/module-zero-core-template</a>
                </p>
            </div>
        </div>
    </div>
</div>
");
            EndContext();
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