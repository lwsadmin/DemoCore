#pragma checksum "G:\杂项\Me\DemoCore\4.0.1\aspnet-core\src\DemoCore.Web.Mvc\Views\Shared\Components\TenantChange\_ChangeModal.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3635772700f5aec9bb72613839bd16dcffe10cbf"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_TenantChange__ChangeModal), @"mvc.1.0.view", @"/Views/Shared/Components/TenantChange/_ChangeModal.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/Components/TenantChange/_ChangeModal.cshtml", typeof(AspNetCore.Views_Shared_Components_TenantChange__ChangeModal))]
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
#line 1 "G:\杂项\Me\DemoCore\4.0.1\aspnet-core\src\DemoCore.Web.Mvc\Views\Shared\Components\TenantChange\_ChangeModal.cshtml"
using Abp.MultiTenancy;

#line default
#line hidden
#line 2 "G:\杂项\Me\DemoCore\4.0.1\aspnet-core\src\DemoCore.Web.Mvc\Views\Shared\Components\TenantChange\_ChangeModal.cshtml"
using DemoCore.Web.Models.Common.Modals;

#line default
#line hidden
#line 3 "G:\杂项\Me\DemoCore\4.0.1\aspnet-core\src\DemoCore.Web.Mvc\Views\Shared\Components\TenantChange\_ChangeModal.cshtml"
using DemoCore.Web.Views.Shared.Components.TenantChange;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3635772700f5aec9bb72613839bd16dcffe10cbf", @"/Views/Shared/Components/TenantChange/_ChangeModal.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"59b606ade4b1b258816958d862bcbe91f3898c03", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_TenantChange__ChangeModal : DemoCore.Web.Views.DemoCoreRazorPage<ChangeModalViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", new global::Microsoft.AspNetCore.Html.HtmlString("TenantChangeForm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("role", new global::Microsoft.AspNetCore.Html.HtmlString("form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-validation"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", "~/view-resources/Views/Shared/Components/TenantChange/_ChangeModal.js", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 5 "G:\杂项\Me\DemoCore\4.0.1\aspnet-core\src\DemoCore.Web.Mvc\Views\Shared\Components\TenantChange\_ChangeModal.cshtml"
  
    Layout = null;

#line default
#line hidden
            BeginContext(182, 102, false);
#line 8 "G:\杂项\Me\DemoCore\4.0.1\aspnet-core\src\DemoCore.Web.Mvc\Views\Shared\Components\TenantChange\_ChangeModal.cshtml"
Write(Html.Partial("~/Views/Shared/Modals/_ModalHeader.cshtml", new ModalHeaderViewModel(L("ChangeTenant"))));

#line default
#line hidden
            EndContext();
            BeginContext(284, 34, true);
            WriteLiteral("\r\n\r\n<div class=\"modal-body\">\r\n    ");
            EndContext();
            BeginContext(318, 501, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "34a9892f13d04b4ea548e780f7b0feb6", async() => {
                BeginContext(395, 158, true);
                WriteLiteral("\r\n        <div class=\"form-group form-float\">\r\n            <div class=\"form-line\">\r\n                <input class=\"form-control\" type=\"text\" name=\"TenancyName\"");
                EndContext();
                BeginWriteAttribute("maxlength", " maxlength=\"", 553, "\"", 600, 1);
#line 14 "G:\杂项\Me\DemoCore\4.0.1\aspnet-core\src\DemoCore.Web.Mvc\Views\Shared\Components\TenantChange\_ChangeModal.cshtml"
WriteAttributeValue("", 565, AbpTenantBase.MaxTenancyNameLength, 565, 35, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginWriteAttribute("value", " value=\"", 601, "\"", 627, 1);
#line 14 "G:\杂项\Me\DemoCore\4.0.1\aspnet-core\src\DemoCore.Web.Mvc\Views\Shared\Components\TenantChange\_ChangeModal.cshtml"
WriteAttributeValue("", 609, Model.TenancyName, 609, 18, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(628, 45, true);
                WriteLiteral(">\r\n                <label class=\"form-label\">");
                EndContext();
                BeginContext(674, 16, false);
#line 15 "G:\杂项\Me\DemoCore\4.0.1\aspnet-core\src\DemoCore.Web.Mvc\Views\Shared\Components\TenantChange\_ChangeModal.cshtml"
                                     Write(L("TenancyName"));

#line default
#line hidden
                EndContext();
                BeginContext(690, 79, true);
                WriteLiteral("</label>\r\n            </div>\r\n        </div>\r\n        <span class=\"help-block\">");
                EndContext();
                BeginContext(770, 29, false);
#line 18 "G:\杂项\Me\DemoCore\4.0.1\aspnet-core\src\DemoCore.Web.Mvc\Views\Shared\Components\TenantChange\_ChangeModal.cshtml"
                            Write(L("LeaveEmptyToSwitchToHost"));

#line default
#line hidden
                EndContext();
                BeginContext(799, 13, true);
                WriteLiteral("</span>\r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            BeginWriteTagHelperAttribute();
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("novalidate", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(819, 12, true);
            WriteLiteral("\r\n</div>\r\n\r\n");
            EndContext();
            BeginContext(832, 74, false);
#line 22 "G:\杂项\Me\DemoCore\4.0.1\aspnet-core\src\DemoCore.Web.Mvc\Views\Shared\Components\TenantChange\_ChangeModal.cshtml"
Write(Html.Partial("~/Views/Shared/Modals/_ModalFooterWithSaveAndCancel.cshtml"));

#line default
#line hidden
            EndContext();
            BeginContext(906, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            BeginContext(910, 119, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "91a1814a4f094d48ae76bf301e422622", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.Src = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
#line 24 "G:\杂项\Me\DemoCore\4.0.1\aspnet-core\src\DemoCore.Web.Mvc\Views\Shared\Components\TenantChange\_ChangeModal.cshtml"
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
            BeginContext(1029, 2, true);
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ChangeModalViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591