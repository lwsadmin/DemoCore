#pragma checksum "G:\杂项\Me\DemoCore\4.0.1\aspnet-core\src\DemoCore.Web.Mvc\Views\Shared\Components\SideBarNav\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3ad142484f5ea7f51520e7e0be85cb8f6b581076"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_SideBarNav_Default), @"mvc.1.0.view", @"/Views/Shared/Components/SideBarNav/Default.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/Components/SideBarNav/Default.cshtml", typeof(AspNetCore.Views_Shared_Components_SideBarNav_Default))]
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
#line 1 "G:\杂项\Me\DemoCore\4.0.1\aspnet-core\src\DemoCore.Web.Mvc\Views\Shared\Components\SideBarNav\Default.cshtml"
using Abp.Collections.Extensions;

#line default
#line hidden
#line 2 "G:\杂项\Me\DemoCore\4.0.1\aspnet-core\src\DemoCore.Web.Mvc\Views\Shared\Components\SideBarNav\Default.cshtml"
using DemoCore.Web.Views;

#line default
#line hidden
#line 3 "G:\杂项\Me\DemoCore\4.0.1\aspnet-core\src\DemoCore.Web.Mvc\Views\Shared\Components\SideBarNav\Default.cshtml"
using DemoCore.Web.Views.Shared.Components.SideBarNav;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3ad142484f5ea7f51520e7e0be85cb8f6b581076", @"/Views/Shared/Components/SideBarNav/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"59b606ade4b1b258816958d862bcbe91f3898c03", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_SideBarNav_Default : DemoCore.Web.Views.DemoCoreRazorPage<SideBarNavViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 5 "G:\杂项\Me\DemoCore\4.0.1\aspnet-core\src\DemoCore.Web.Mvc\Views\Shared\Components\SideBarNav\Default.cshtml"
  
    var calculateMenuUrl = new Func<string, string>((url) =>
    {
        if (string.IsNullOrEmpty(url))
        {
            return ApplicationPath;
        }

        if (UrlChecker.IsRooted(url))
        {
            return url;
        }

        return ApplicationPath + url;
    });

#line default
#line hidden
            BeginContext(459, 43, true);
            WriteLiteral("<div class=\"menu\">\r\n    <ul class=\"list\">\r\n");
            EndContext();
#line 23 "G:\杂项\Me\DemoCore\4.0.1\aspnet-core\src\DemoCore.Web.Mvc\Views\Shared\Components\SideBarNav\Default.cshtml"
         foreach (var menuItem in Model.MainMenu.Items)
        {

#line default
#line hidden
            BeginContext(570, 15, true);
            WriteLiteral("            <li");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 585, "\"", 653, 1);
#line 25 "G:\杂项\Me\DemoCore\4.0.1\aspnet-core\src\DemoCore.Web.Mvc\Views\Shared\Components\SideBarNav\Default.cshtml"
WriteAttributeValue("", 593, Model.ActiveMenuItemName == menuItem.Name ? "active" : "", 593, 60, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(654, 3, true);
            WriteLiteral(">\r\n");
            EndContext();
#line 26 "G:\杂项\Me\DemoCore\4.0.1\aspnet-core\src\DemoCore.Web.Mvc\Views\Shared\Components\SideBarNav\Default.cshtml"
                 if (menuItem.Items.IsNullOrEmpty())
                {

#line default
#line hidden
            BeginContext(730, 22, true);
            WriteLiteral("                    <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 752, "\"", 790, 1);
#line 28 "G:\杂项\Me\DemoCore\4.0.1\aspnet-core\src\DemoCore.Web.Mvc\Views\Shared\Components\SideBarNav\Default.cshtml"
WriteAttributeValue("", 759, calculateMenuUrl(menuItem.Url), 759, 31, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(791, 3, true);
            WriteLiteral(">\r\n");
            EndContext();
#line 29 "G:\杂项\Me\DemoCore\4.0.1\aspnet-core\src\DemoCore.Web.Mvc\Views\Shared\Components\SideBarNav\Default.cshtml"
                         if (!string.IsNullOrWhiteSpace(menuItem.Icon))
                        {

#line default
#line hidden
            BeginContext(894, 54, true);
            WriteLiteral("                            <i class=\"material-icons\">");
            EndContext();
            BeginContext(949, 13, false);
#line 31 "G:\杂项\Me\DemoCore\4.0.1\aspnet-core\src\DemoCore.Web.Mvc\Views\Shared\Components\SideBarNav\Default.cshtml"
                                                 Write(menuItem.Icon);

#line default
#line hidden
            EndContext();
            BeginContext(962, 6, true);
            WriteLiteral("</i>\r\n");
            EndContext();
#line 32 "G:\杂项\Me\DemoCore\4.0.1\aspnet-core\src\DemoCore.Web.Mvc\Views\Shared\Components\SideBarNav\Default.cshtml"
                        }

#line default
#line hidden
            BeginContext(995, 30, true);
            WriteLiteral("                        <span>");
            EndContext();
            BeginContext(1026, 20, false);
#line 33 "G:\杂项\Me\DemoCore\4.0.1\aspnet-core\src\DemoCore.Web.Mvc\Views\Shared\Components\SideBarNav\Default.cshtml"
                         Write(menuItem.DisplayName);

#line default
#line hidden
            EndContext();
            BeginContext(1046, 35, true);
            WriteLiteral("</span>\r\n                    </a>\r\n");
            EndContext();
#line 35 "G:\杂项\Me\DemoCore\4.0.1\aspnet-core\src\DemoCore.Web.Mvc\Views\Shared\Components\SideBarNav\Default.cshtml"
                }
                else
                {

#line default
#line hidden
            BeginContext(1141, 72, true);
            WriteLiteral("                    <a href=\"javascript:void(0);\" class=\"menu-toggle\">\r\n");
            EndContext();
#line 39 "G:\杂项\Me\DemoCore\4.0.1\aspnet-core\src\DemoCore.Web.Mvc\Views\Shared\Components\SideBarNav\Default.cshtml"
                         if (!string.IsNullOrWhiteSpace(menuItem.Icon))
                        {

#line default
#line hidden
            BeginContext(1313, 54, true);
            WriteLiteral("                            <i class=\"material-icons\">");
            EndContext();
            BeginContext(1368, 13, false);
#line 41 "G:\杂项\Me\DemoCore\4.0.1\aspnet-core\src\DemoCore.Web.Mvc\Views\Shared\Components\SideBarNav\Default.cshtml"
                                                 Write(menuItem.Icon);

#line default
#line hidden
            EndContext();
            BeginContext(1381, 6, true);
            WriteLiteral("</i>\r\n");
            EndContext();
#line 42 "G:\杂项\Me\DemoCore\4.0.1\aspnet-core\src\DemoCore.Web.Mvc\Views\Shared\Components\SideBarNav\Default.cshtml"
                        }

#line default
#line hidden
            BeginContext(1414, 30, true);
            WriteLiteral("                        <span>");
            EndContext();
            BeginContext(1445, 20, false);
#line 43 "G:\杂项\Me\DemoCore\4.0.1\aspnet-core\src\DemoCore.Web.Mvc\Views\Shared\Components\SideBarNav\Default.cshtml"
                         Write(menuItem.DisplayName);

#line default
#line hidden
            EndContext();
            BeginContext(1465, 77, true);
            WriteLiteral("</span>\r\n                    </a>\r\n                    <ul class=\"ml-menu\">\r\n");
            EndContext();
#line 46 "G:\杂项\Me\DemoCore\4.0.1\aspnet-core\src\DemoCore.Web.Mvc\Views\Shared\Components\SideBarNav\Default.cshtml"
                         foreach (var subMenuItem in menuItem.Items)
                        {

#line default
#line hidden
            BeginContext(1639, 31, true);
            WriteLiteral("                            <li");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 1670, "\"", 1741, 1);
#line 48 "G:\杂项\Me\DemoCore\4.0.1\aspnet-core\src\DemoCore.Web.Mvc\Views\Shared\Components\SideBarNav\Default.cshtml"
WriteAttributeValue("", 1678, Model.ActiveMenuItemName == subMenuItem.Name ? "active" : "", 1678, 63, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1742, 3, true);
            WriteLiteral(">\r\n");
            EndContext();
#line 49 "G:\杂项\Me\DemoCore\4.0.1\aspnet-core\src\DemoCore.Web.Mvc\Views\Shared\Components\SideBarNav\Default.cshtml"
                                 if (subMenuItem.Items.IsNullOrEmpty())
                                {

#line default
#line hidden
            BeginContext(1853, 38, true);
            WriteLiteral("                                    <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1891, "\"", 1932, 1);
#line 51 "G:\杂项\Me\DemoCore\4.0.1\aspnet-core\src\DemoCore.Web.Mvc\Views\Shared\Components\SideBarNav\Default.cshtml"
WriteAttributeValue("", 1898, calculateMenuUrl(subMenuItem.Url), 1898, 34, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1933, 3, true);
            WriteLiteral(">\r\n");
            EndContext();
#line 52 "G:\杂项\Me\DemoCore\4.0.1\aspnet-core\src\DemoCore.Web.Mvc\Views\Shared\Components\SideBarNav\Default.cshtml"
                                         if (!string.IsNullOrWhiteSpace(subMenuItem.Icon))
                                        {

#line default
#line hidden
            BeginContext(2071, 70, true);
            WriteLiteral("                                            <i class=\"material-icons\">");
            EndContext();
            BeginContext(2142, 16, false);
#line 54 "G:\杂项\Me\DemoCore\4.0.1\aspnet-core\src\DemoCore.Web.Mvc\Views\Shared\Components\SideBarNav\Default.cshtml"
                                                                 Write(subMenuItem.Icon);

#line default
#line hidden
            EndContext();
            BeginContext(2158, 6, true);
            WriteLiteral("</i>\r\n");
            EndContext();
#line 55 "G:\杂项\Me\DemoCore\4.0.1\aspnet-core\src\DemoCore.Web.Mvc\Views\Shared\Components\SideBarNav\Default.cshtml"
                                        }

#line default
#line hidden
            BeginContext(2207, 46, true);
            WriteLiteral("                                        <span>");
            EndContext();
            BeginContext(2254, 23, false);
#line 56 "G:\杂项\Me\DemoCore\4.0.1\aspnet-core\src\DemoCore.Web.Mvc\Views\Shared\Components\SideBarNav\Default.cshtml"
                                         Write(subMenuItem.DisplayName);

#line default
#line hidden
            EndContext();
            BeginContext(2277, 51, true);
            WriteLiteral("</span>\r\n                                    </a>\r\n");
            EndContext();
#line 58 "G:\杂项\Me\DemoCore\4.0.1\aspnet-core\src\DemoCore.Web.Mvc\Views\Shared\Components\SideBarNav\Default.cshtml"
                                }
                                else
                                {

#line default
#line hidden
            BeginContext(2436, 88, true);
            WriteLiteral("                                    <a href=\"javascript:void(0);\" class=\"menu-toggle\">\r\n");
            EndContext();
#line 62 "G:\杂项\Me\DemoCore\4.0.1\aspnet-core\src\DemoCore.Web.Mvc\Views\Shared\Components\SideBarNav\Default.cshtml"
                                         if (!string.IsNullOrWhiteSpace(subMenuItem.Icon))
                                        {

#line default
#line hidden
            BeginContext(2659, 70, true);
            WriteLiteral("                                            <i class=\"material-icons\">");
            EndContext();
            BeginContext(2730, 16, false);
#line 64 "G:\杂项\Me\DemoCore\4.0.1\aspnet-core\src\DemoCore.Web.Mvc\Views\Shared\Components\SideBarNav\Default.cshtml"
                                                                 Write(subMenuItem.Icon);

#line default
#line hidden
            EndContext();
            BeginContext(2746, 6, true);
            WriteLiteral("</i>\r\n");
            EndContext();
#line 65 "G:\杂项\Me\DemoCore\4.0.1\aspnet-core\src\DemoCore.Web.Mvc\Views\Shared\Components\SideBarNav\Default.cshtml"
                                        }

#line default
#line hidden
            BeginContext(2795, 46, true);
            WriteLiteral("                                        <span>");
            EndContext();
            BeginContext(2842, 23, false);
#line 66 "G:\杂项\Me\DemoCore\4.0.1\aspnet-core\src\DemoCore.Web.Mvc\Views\Shared\Components\SideBarNav\Default.cshtml"
                                         Write(subMenuItem.DisplayName);

#line default
#line hidden
            EndContext();
            BeginContext(2865, 109, true);
            WriteLiteral("</span>\r\n                                    </a>\r\n                                    <ul class=\"ml-menu\">\r\n");
            EndContext();
#line 69 "G:\杂项\Me\DemoCore\4.0.1\aspnet-core\src\DemoCore.Web.Mvc\Views\Shared\Components\SideBarNav\Default.cshtml"
                                         foreach (var subSubMenuItem in subMenuItem.Items)
                                        {

#line default
#line hidden
            BeginContext(3109, 47, true);
            WriteLiteral("                                            <li");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 3156, "\"", 3230, 1);
#line 71 "G:\杂项\Me\DemoCore\4.0.1\aspnet-core\src\DemoCore.Web.Mvc\Views\Shared\Components\SideBarNav\Default.cshtml"
WriteAttributeValue("", 3164, Model.ActiveMenuItemName == subSubMenuItem.Name ? "active" : "", 3164, 66, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3231, 53, true);
            WriteLiteral(">\r\n                                                <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 3284, "\"", 3328, 1);
#line 72 "G:\杂项\Me\DemoCore\4.0.1\aspnet-core\src\DemoCore.Web.Mvc\Views\Shared\Components\SideBarNav\Default.cshtml"
WriteAttributeValue("", 3291, calculateMenuUrl(subSubMenuItem.Url), 3291, 37, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3329, 55, true);
            WriteLiteral(">\r\n                                                    ");
            EndContext();
            BeginContext(3385, 26, false);
#line 73 "G:\杂项\Me\DemoCore\4.0.1\aspnet-core\src\DemoCore.Web.Mvc\Views\Shared\Components\SideBarNav\Default.cshtml"
                                               Write(subSubMenuItem.DisplayName);

#line default
#line hidden
            EndContext();
            BeginContext(3411, 107, true);
            WriteLiteral("\r\n                                                </a>\r\n                                            </li>\r\n");
            EndContext();
#line 76 "G:\杂项\Me\DemoCore\4.0.1\aspnet-core\src\DemoCore.Web.Mvc\Views\Shared\Components\SideBarNav\Default.cshtml"
                                        }

#line default
#line hidden
            BeginContext(3561, 43, true);
            WriteLiteral("                                    </ul>\r\n");
            EndContext();
#line 78 "G:\杂项\Me\DemoCore\4.0.1\aspnet-core\src\DemoCore.Web.Mvc\Views\Shared\Components\SideBarNav\Default.cshtml"
                                }

#line default
#line hidden
            BeginContext(3639, 35, true);
            WriteLiteral("                            </li>\r\n");
            EndContext();
#line 80 "G:\杂项\Me\DemoCore\4.0.1\aspnet-core\src\DemoCore.Web.Mvc\Views\Shared\Components\SideBarNav\Default.cshtml"
                        }

#line default
#line hidden
            BeginContext(3701, 27, true);
            WriteLiteral("                    </ul>\r\n");
            EndContext();
#line 82 "G:\杂项\Me\DemoCore\4.0.1\aspnet-core\src\DemoCore.Web.Mvc\Views\Shared\Components\SideBarNav\Default.cshtml"
                }

#line default
#line hidden
            BeginContext(3747, 19, true);
            WriteLiteral("            </li>\r\n");
            EndContext();
#line 84 "G:\杂项\Me\DemoCore\4.0.1\aspnet-core\src\DemoCore.Web.Mvc\Views\Shared\Components\SideBarNav\Default.cshtml"
        }

#line default
#line hidden
            BeginContext(3777, 19, true);
            WriteLiteral("    </ul>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SideBarNavViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
