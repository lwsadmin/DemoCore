#pragma checksum "G:\杂项\Me\DemoCore\4.0.1\aspnet-core\src\DemoCore.Web.Mvc\Views\Account\Register.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cc317d46d251018adef6c85051d64e6e803ac919"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_Register), @"mvc.1.0.view", @"/Views/Account/Register.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Account/Register.cshtml", typeof(AspNetCore.Views_Account_Register))]
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
#line 1 "G:\杂项\Me\DemoCore\4.0.1\aspnet-core\src\DemoCore.Web.Mvc\Views\Account\Register.cshtml"
using Abp.Authorization.Users;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cc317d46d251018adef6c85051d64e6e803ac919", @"/Views/Account/Register.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"59b606ade4b1b258816958d862bcbe91f3898c03", @"/Views/_ViewImports.cshtml")]
    public class Views_Account_Register : DemoCore.Web.Views.DemoCoreRazorPage<DemoCore.Web.Models.Account.RegisterViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", "~/view-resources/Views/Account/Login.css", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("names", "Development", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", "~/view-resources/Views/Account/Login.min.css", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("names", "Staging,Production", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", "~/view-resources/Views/Account/Register.js", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", "~/view-resources/Views/Account/Register.min.js", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Login", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-default waves-effect"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("RegisterForm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Register", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_11 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.EnvironmentTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_EnvironmentTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.LinkTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_LinkTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "G:\杂项\Me\DemoCore\4.0.1\aspnet-core\src\DemoCore.Web.Mvc\Views\Account\Register.cshtml"
  
    ViewBag.DisableTopBar = true;

#line default
#line hidden
            DefineSection("Styles", async() => {
                BeginContext(146, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(152, 162, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("environment", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f24a2d13c1f941c5928143a48b13f5e8", async() => {
                    BeginContext(185, 10, true);
                    WriteLiteral("\r\n        ");
                    EndContext();
                    BeginContext(195, 99, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "c67f7d873dd844219355fe474e48a2d7", async() => {
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_LinkTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LinkTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LinkTagHelper);
                    __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_LinkTagHelper.Href = (string)__tagHelperAttribute_1.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
#line 9 "G:\杂项\Me\DemoCore\4.0.1\aspnet-core\src\DemoCore.Web.Mvc\Views\Account\Register.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_LinkTagHelper.AppendVersion = true;

#line default
#line hidden
                    __tagHelperExecutionContext.AddTagHelperAttribute("asp-append-version", __Microsoft_AspNetCore_Mvc_TagHelpers_LinkTagHelper.AppendVersion, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    EndContext();
                    BeginContext(294, 6, true);
                    WriteLiteral("\r\n    ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_EnvironmentTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.EnvironmentTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_EnvironmentTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_EnvironmentTagHelper.Names = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(314, 8, true);
                WriteLiteral("\r\n\r\n    ");
                EndContext();
                BeginContext(322, 173, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("environment", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "12cc0ad39ca845a6b6d47a8d3d3ed4ba", async() => {
                    BeginContext(362, 10, true);
                    WriteLiteral("\r\n        ");
                    EndContext();
                    BeginContext(372, 103, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "fb3f8883dc7d48749b6e6184f8094543", async() => {
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_LinkTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LinkTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LinkTagHelper);
                    __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_LinkTagHelper.Href = (string)__tagHelperAttribute_3.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
#line 13 "G:\杂项\Me\DemoCore\4.0.1\aspnet-core\src\DemoCore.Web.Mvc\Views\Account\Register.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_LinkTagHelper.AppendVersion = true;

#line default
#line hidden
                    __tagHelperExecutionContext.AddTagHelperAttribute("asp-append-version", __Microsoft_AspNetCore_Mvc_TagHelpers_LinkTagHelper.AppendVersion, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    EndContext();
                    BeginContext(475, 6, true);
                    WriteLiteral("\r\n    ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_EnvironmentTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.EnvironmentTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_EnvironmentTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_EnvironmentTagHelper.Names = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(495, 2, true);
                WriteLiteral("\r\n");
                EndContext();
            }
            );
            DefineSection("Scripts", async() => {
                BeginContext(517, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(523, 155, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("environment", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "528175a998c1461d9c2b6b19e4558192", async() => {
                    BeginContext(556, 10, true);
                    WriteLiteral("\r\n        ");
                    EndContext();
                    BeginContext(566, 92, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1001de768f26470c9ac0c8275c3a7ce1", async() => {
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.Src = (string)__tagHelperAttribute_5.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
#line 18 "G:\杂项\Me\DemoCore\4.0.1\aspnet-core\src\DemoCore.Web.Mvc\Views\Account\Register.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.AppendVersion = true;

#line default
#line hidden
                    __tagHelperExecutionContext.AddTagHelperAttribute("asp-append-version", __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.AppendVersion, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    EndContext();
                    BeginContext(658, 6, true);
                    WriteLiteral("\r\n    ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_EnvironmentTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.EnvironmentTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_EnvironmentTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_EnvironmentTagHelper.Names = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(678, 8, true);
                WriteLiteral("\r\n\r\n    ");
                EndContext();
                BeginContext(686, 166, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("environment", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "499810d06f6f4a4b90b39848c8f661d3", async() => {
                    BeginContext(726, 10, true);
                    WriteLiteral("\r\n        ");
                    EndContext();
                    BeginContext(736, 96, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6b7f8b4f376346958f9bb07fd673b686", async() => {
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.Src = (string)__tagHelperAttribute_6.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
#line 22 "G:\杂项\Me\DemoCore\4.0.1\aspnet-core\src\DemoCore.Web.Mvc\Views\Account\Register.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.AppendVersion = true;

#line default
#line hidden
                    __tagHelperExecutionContext.AddTagHelperAttribute("asp-append-version", __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.AppendVersion, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    EndContext();
                    BeginContext(832, 6, true);
                    WriteLiteral("\r\n    ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_EnvironmentTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.EnvironmentTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_EnvironmentTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_EnvironmentTagHelper.Names = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(852, 2, true);
                WriteLiteral("\r\n");
                EndContext();
            }
            );
            BeginContext(857, 52, true);
            WriteLiteral("<div class=\"card\">\r\n    <div class=\"body\">\r\n        ");
            EndContext();
            BeginContext(909, 2701, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0cfb2094a587475fa072557357beb6da", async() => {
                BeginContext(969, 38, true);
                WriteLiteral("\r\n            <h4 class=\"text-center\">");
                EndContext();
                BeginContext(1008, 13, false);
#line 28 "G:\杂项\Me\DemoCore\4.0.1\aspnet-core\src\DemoCore.Web.Mvc\Views\Account\Register.cshtml"
                               Write(L("Register"));

#line default
#line hidden
                EndContext();
                BeginContext(1021, 9, true);
                WriteLiteral("</h4>\r\n\r\n");
                EndContext();
#line 30 "G:\杂项\Me\DemoCore\4.0.1\aspnet-core\src\DemoCore.Web.Mvc\Views\Account\Register.cshtml"
             if (@ViewBag.ErrorMessage != null)
            {

#line default
#line hidden
                BeginContext(1094, 100, true);
                WriteLiteral("                <div class=\"alert alert-danger\">\r\n                    <i class=\"fa fa-warning\"></i> ");
                EndContext();
                BeginContext(1195, 20, false);
#line 33 "G:\杂项\Me\DemoCore\4.0.1\aspnet-core\src\DemoCore.Web.Mvc\Views\Account\Register.cshtml"
                                             Write(ViewBag.ErrorMessage);

#line default
#line hidden
                EndContext();
                BeginContext(1215, 26, true);
                WriteLiteral("\r\n                </div>\r\n");
                EndContext();
#line 35 "G:\杂项\Me\DemoCore\4.0.1\aspnet-core\src\DemoCore.Web.Mvc\Views\Account\Register.cshtml"
            }

#line default
#line hidden
                BeginContext(1256, 57, true);
                WriteLiteral("\r\n            <input type=\"hidden\" name=\"IsExternalLogin\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1313, "\"", 1354, 1);
#line 37 "G:\杂项\Me\DemoCore\4.0.1\aspnet-core\src\DemoCore.Web.Mvc\Views\Account\Register.cshtml"
WriteAttributeValue("", 1321, Model.IsExternalLogin.ToString(), 1321, 33, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1355, 68, true);
                WriteLiteral(" />\r\n            <input type=\"hidden\" name=\"ExternalLoginAuthSchema\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1423, "\"", 1461, 1);
#line 38 "G:\杂项\Me\DemoCore\4.0.1\aspnet-core\src\DemoCore.Web.Mvc\Views\Account\Register.cshtml"
WriteAttributeValue("", 1431, Model.ExternalLoginAuthSchema, 1431, 30, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1462, 168, true);
                WriteLiteral(" />\r\n\r\n            <div class=\"form-group form-float\">\r\n                <div class=\"form-line\">\r\n                    <input type=\"text\" class=\"form-control\" name=\"Name\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1630, "\"", 1649, 1);
#line 42 "G:\杂项\Me\DemoCore\4.0.1\aspnet-core\src\DemoCore.Web.Mvc\Views\Account\Register.cshtml"
WriteAttributeValue("", 1638, Model.Name, 1638, 11, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1650, 9, true);
                WriteLiteral(" required");
                EndContext();
                BeginWriteAttribute("maxlength", " maxlength=\"", 1659, "\"", 1697, 1);
#line 42 "G:\杂项\Me\DemoCore\4.0.1\aspnet-core\src\DemoCore.Web.Mvc\Views\Account\Register.cshtml"
WriteAttributeValue("", 1671, AbpUserBase.MaxNameLength, 1671, 26, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1698, 49, true);
                WriteLiteral(">\r\n                    <label class=\"form-label\">");
                EndContext();
                BeginContext(1748, 9, false);
#line 43 "G:\杂项\Me\DemoCore\4.0.1\aspnet-core\src\DemoCore.Web.Mvc\Views\Account\Register.cshtml"
                                         Write(L("Name"));

#line default
#line hidden
                EndContext();
                BeginContext(1757, 220, true);
                WriteLiteral("</label>\r\n                </div>\r\n            </div>\r\n\r\n            <div class=\"form-group form-float\">\r\n                <div class=\"form-line\">\r\n                    <input type=\"text\" class=\"form-control\" name=\"Surname\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1977, "\"", 1999, 1);
#line 49 "G:\杂项\Me\DemoCore\4.0.1\aspnet-core\src\DemoCore.Web.Mvc\Views\Account\Register.cshtml"
WriteAttributeValue("", 1985, Model.Surname, 1985, 14, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2000, 9, true);
                WriteLiteral(" required");
                EndContext();
                BeginWriteAttribute("maxlength", " maxlength=\"", 2009, "\"", 2050, 1);
#line 49 "G:\杂项\Me\DemoCore\4.0.1\aspnet-core\src\DemoCore.Web.Mvc\Views\Account\Register.cshtml"
WriteAttributeValue("", 2021, AbpUserBase.MaxSurnameLength, 2021, 29, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2051, 49, true);
                WriteLiteral(">\r\n                    <label class=\"form-label\">");
                EndContext();
                BeginContext(2101, 12, false);
#line 50 "G:\杂项\Me\DemoCore\4.0.1\aspnet-core\src\DemoCore.Web.Mvc\Views\Account\Register.cshtml"
                                         Write(L("Surname"));

#line default
#line hidden
                EndContext();
                BeginContext(2113, 226, true);
                WriteLiteral("</label>\r\n                </div>\r\n            </div>\r\n\r\n            <div class=\"form-group form-float\">\r\n                <div class=\"form-line\">\r\n                    <input type=\"email\" class=\"form-control\" name=\"EmailAddress\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 2339, "\"", 2366, 1);
#line 56 "G:\杂项\Me\DemoCore\4.0.1\aspnet-core\src\DemoCore.Web.Mvc\Views\Account\Register.cshtml"
WriteAttributeValue("", 2347, Model.EmailAddress, 2347, 19, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2367, 9, true);
                WriteLiteral(" required");
                EndContext();
                BeginWriteAttribute("maxlength", " maxlength=\"", 2376, "\"", 2422, 1);
#line 56 "G:\杂项\Me\DemoCore\4.0.1\aspnet-core\src\DemoCore.Web.Mvc\Views\Account\Register.cshtml"
WriteAttributeValue("", 2388, AbpUserBase.MaxEmailAddressLength, 2388, 34, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2423, 49, true);
                WriteLiteral(">\r\n                    <label class=\"form-label\">");
                EndContext();
                BeginContext(2473, 17, false);
#line 57 "G:\杂项\Me\DemoCore\4.0.1\aspnet-core\src\DemoCore.Web.Mvc\Views\Account\Register.cshtml"
                                         Write(L("EmailAddress"));

#line default
#line hidden
                EndContext();
                BeginContext(2490, 221, true);
                WriteLiteral("</label>\r\n                </div>\r\n            </div>\r\n\r\n            <div class=\"form-group form-float\">\r\n                <div class=\"form-line\">\r\n                    <input type=\"text\" class=\"form-control\" name=\"UserName\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 2711, "\"", 2734, 1);
#line 63 "G:\杂项\Me\DemoCore\4.0.1\aspnet-core\src\DemoCore.Web.Mvc\Views\Account\Register.cshtml"
WriteAttributeValue("", 2719, Model.UserName, 2719, 15, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2735, 9, true);
                WriteLiteral(" required");
                EndContext();
                BeginWriteAttribute("maxlength", " maxlength=\"", 2744, "\"", 2786, 1);
#line 63 "G:\杂项\Me\DemoCore\4.0.1\aspnet-core\src\DemoCore.Web.Mvc\Views\Account\Register.cshtml"
WriteAttributeValue("", 2756, AbpUserBase.MaxUserNameLength, 2756, 30, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2787, 49, true);
                WriteLiteral(">\r\n                    <label class=\"form-label\">");
                EndContext();
                BeginContext(2837, 13, false);
#line 64 "G:\杂项\Me\DemoCore\4.0.1\aspnet-core\src\DemoCore.Web.Mvc\Views\Account\Register.cshtml"
                                         Write(L("UserName"));

#line default
#line hidden
                EndContext();
                BeginContext(2850, 234, true);
                WriteLiteral("</label>\r\n                </div>\r\n            </div>\r\n\r\n            <div class=\"form-group form-float\">\r\n                <div class=\"form-line\">\r\n                    <input type=\"password\" class=\"form-control\" name=\"Password\" required");
                EndContext();
                BeginWriteAttribute("maxlength", " maxlength=\"", 3084, "\"", 3131, 1);
#line 70 "G:\杂项\Me\DemoCore\4.0.1\aspnet-core\src\DemoCore.Web.Mvc\Views\Account\Register.cshtml"
WriteAttributeValue("", 3096, AbpUserBase.MaxPlainPasswordLength, 3096, 35, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(3132, 49, true);
                WriteLiteral(">\r\n                    <label class=\"form-label\">");
                EndContext();
                BeginContext(3182, 13, false);
#line 71 "G:\杂项\Me\DemoCore\4.0.1\aspnet-core\src\DemoCore.Web.Mvc\Views\Account\Register.cshtml"
                                         Write(L("Password"));

#line default
#line hidden
                EndContext();
                BeginContext(3195, 160, true);
                WriteLiteral("</label>\r\n                </div>\r\n            </div>\r\n            \r\n            <div class=\"row\">\r\n                <div class=\"col-xs-12\">\r\n                    ");
                EndContext();
                BeginContext(3355, 74, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3240bc49a71f40e8b0d3b1d1c5f9d879", async() => {
                    BeginContext(3416, 9, false);
#line 77 "G:\杂项\Me\DemoCore\4.0.1\aspnet-core\src\DemoCore.Web.Mvc\Views\Account\Register.cshtml"
                                                                           Write(L("Back"));

#line default
#line hidden
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_7.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(3429, 97, true);
                WriteLiteral("\r\n                    <button id=\"RegisterButton\" class=\"btn bg-pink waves-effect\" type=\"submit\">");
                EndContext();
                BeginContext(3527, 13, false);
#line 78 "G:\杂项\Me\DemoCore\4.0.1\aspnet-core\src\DemoCore.Web.Mvc\Views\Account\Register.cshtml"
                                                                                          Write(L("Register"));

#line default
#line hidden
                EndContext();
                BeginContext(3540, 63, true);
                WriteLiteral("</button>\r\n                </div>\r\n            </div>\r\n        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_10.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_10);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_11.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_11);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3610, 22, true);
            WriteLiteral("\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DemoCore.Web.Models.Account.RegisterViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
