#pragma checksum "G:\杂项\Me\DemoCore\4.0.1\aspnet-core\src\DemoCore.Web.Mvc\Areas\GoodsManage\Views\Category\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6a6e717d397d23d864e392b0333bb21e9eb41146"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_GoodsManage_Views_Category_List), @"mvc.1.0.view", @"/Areas/GoodsManage/Views/Category/List.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/GoodsManage/Views/Category/List.cshtml", typeof(AspNetCore.Areas_GoodsManage_Views_Category_List))]
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
#line 1 "G:\杂项\Me\DemoCore\4.0.1\aspnet-core\src\DemoCore.Web.Mvc\Areas\_ViewImports.cshtml"
using Abp.Localization;

#line default
#line hidden
#line 1 "G:\杂项\Me\DemoCore\4.0.1\aspnet-core\src\DemoCore.Web.Mvc\Areas\GoodsManage\Views\Category\List.cshtml"
using DemoCore.Web.Startup;

#line default
#line hidden
#line 2 "G:\杂项\Me\DemoCore\4.0.1\aspnet-core\src\DemoCore.Web.Mvc\Areas\GoodsManage\Views\Category\List.cshtml"
using DemoCore.GoodsManage.Dto;

#line default
#line hidden
#line 3 "G:\杂项\Me\DemoCore\4.0.1\aspnet-core\src\DemoCore.Web.Mvc\Areas\GoodsManage\Views\Category\List.cshtml"
using DemoCore.Authorization;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6a6e717d397d23d864e392b0333bb21e9eb41146", @"/Areas/GoodsManage/Views/Category/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"59b606ade4b1b258816958d862bcbe91f3898c03", @"/Areas/_ViewImports.cshtml")]
    public class Areas_GoodsManage_Views_Category_List : DemoCore.Web.Views.DemoCoreRazorPage<List<CategoryListDto>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/view-resources/Views/GoodsManage/Categroy/list.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", new global::Microsoft.AspNetCore.Html.HtmlString("CreateForm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("role", new global::Microsoft.AspNetCore.Html.HtmlString("form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-validation"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 5 "G:\杂项\Me\DemoCore\4.0.1\aspnet-core\src\DemoCore.Web.Mvc\Areas\GoodsManage\Views\Category\List.cshtml"
  
    ViewBag.CurrentPageName = "GoodsCategory"; // The menu item will be active for this page.
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(272, 75, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7b787bc61f324f509a131f4cf8522250", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(347, 193, true);
            WriteLiteral("\r\n<div class=\"row clearfix\">\r\n    <div class=\"col-lg-12 col-md-12 col-sm-12 col-xs-12\">\r\n        <div class=\"card\">\r\n            <div class=\"header\">\r\n                <h2>\r\n                    ");
            EndContext();
            BeginContext(541, 18, false);
#line 15 "G:\杂项\Me\DemoCore\4.0.1\aspnet-core\src\DemoCore.Web.Mvc\Areas\GoodsManage\Views\Category\List.cshtml"
               Write(L("GoodsCategory"));

#line default
#line hidden
            EndContext();
            BeginContext(559, 594, true);
            WriteLiteral(@"
                </h2>
                <ul class=""header-dropdown m-r--5"">
                    <li class=""dropdown"">
                        <a href=""javascript:void(0);"" class=""dropdown-toggle"" data-toggle=""dropdown"" role=""button"" aria-haspopup=""true"" aria-expanded=""false"">
                            <i class=""material-icons"">more_vert</i>
                        </a>
                        <ul class=""dropdown-menu pull-right"">
                            <li><a id=""RefreshButton"" href=""javascript:void(0);"" class=""waves-effect waves-block""><i class=""material-icons"">refresh</i>");
            EndContext();
            BeginContext(1154, 12, false);
#line 23 "G:\杂项\Me\DemoCore\4.0.1\aspnet-core\src\DemoCore.Web.Mvc\Areas\GoodsManage\Views\Category\List.cshtml"
                                                                                                                                                  Write(L("Refresh"));

#line default
#line hidden
            EndContext();
            BeginContext(1166, 291, true);
            WriteLiteral(@"</a></li>
                        </ul>
                    </li>
                </ul>
            </div>
            <div class=""body table-responsive"">
                <table class=""table"">
                    <thead>
                        <tr>
                            <th>");
            EndContext();
            BeginContext(1458, 10, false);
#line 32 "G:\杂项\Me\DemoCore\4.0.1\aspnet-core\src\DemoCore.Web.Mvc\Areas\GoodsManage\Views\Category\List.cshtml"
                           Write(L("Title"));

#line default
#line hidden
            EndContext();
            BeginContext(1468, 39, true);
            WriteLiteral("</th>\r\n                            <th>");
            EndContext();
            BeginContext(1508, 12, false);
#line 33 "G:\杂项\Me\DemoCore\4.0.1\aspnet-core\src\DemoCore.Web.Mvc\Areas\GoodsManage\Views\Category\List.cshtml"
                           Write(L("Tenants"));

#line default
#line hidden
            EndContext();
            BeginContext(1520, 39, true);
            WriteLiteral("</th>\r\n                            <th>");
            EndContext();
            BeginContext(1560, 9, false);
#line 34 "G:\杂项\Me\DemoCore\4.0.1\aspnet-core\src\DemoCore.Web.Mvc\Areas\GoodsManage\Views\Category\List.cshtml"
                           Write(L("Memo"));

#line default
#line hidden
            EndContext();
            BeginContext(1569, 39, true);
            WriteLiteral("</th>\r\n                            <th>");
            EndContext();
            BeginContext(1609, 17, false);
#line 35 "G:\杂项\Me\DemoCore\4.0.1\aspnet-core\src\DemoCore.Web.Mvc\Areas\GoodsManage\Views\Category\List.cshtml"
                           Write(L("CreationTime"));

#line default
#line hidden
            EndContext();
            BeginContext(1626, 39, true);
            WriteLiteral("</th>\r\n                            <th>");
            EndContext();
            BeginContext(1666, 12, false);
#line 36 "G:\杂项\Me\DemoCore\4.0.1\aspnet-core\src\DemoCore.Web.Mvc\Areas\GoodsManage\Views\Category\List.cshtml"
                           Write(L("Operate"));

#line default
#line hidden
            EndContext();
            BeginContext(1678, 97, true);
            WriteLiteral("</th>\r\n                        </tr>\r\n                    </thead>\r\n                    <tbody>\r\n");
            EndContext();
#line 40 "G:\杂项\Me\DemoCore\4.0.1\aspnet-core\src\DemoCore.Web.Mvc\Areas\GoodsManage\Views\Category\List.cshtml"
                         foreach (var item in Model)
                        {

#line default
#line hidden
            BeginContext(1856, 70, true);
            WriteLiteral("                            <tr>\r\n                                <td>");
            EndContext();
            BeginContext(1927, 10, false);
#line 43 "G:\杂项\Me\DemoCore\4.0.1\aspnet-core\src\DemoCore.Web.Mvc\Areas\GoodsManage\Views\Category\List.cshtml"
                               Write(item.Title);

#line default
#line hidden
            EndContext();
            BeginContext(1937, 43, true);
            WriteLiteral("</td>\r\n                                <td>");
            EndContext();
            BeginContext(1981, 13, false);
#line 44 "G:\杂项\Me\DemoCore\4.0.1\aspnet-core\src\DemoCore.Web.Mvc\Areas\GoodsManage\Views\Category\List.cshtml"
                               Write(item.TenantId);

#line default
#line hidden
            EndContext();
            BeginContext(1994, 43, true);
            WriteLiteral("</td>\r\n                                <th>");
            EndContext();
            BeginContext(2038, 9, false);
#line 45 "G:\杂项\Me\DemoCore\4.0.1\aspnet-core\src\DemoCore.Web.Mvc\Areas\GoodsManage\Views\Category\List.cshtml"
                               Write(item.Memo);

#line default
#line hidden
            EndContext();
            BeginContext(2047, 43, true);
            WriteLiteral("</th>\r\n                                <th>");
            EndContext();
            BeginContext(2091, 17, false);
#line 46 "G:\杂项\Me\DemoCore\4.0.1\aspnet-core\src\DemoCore.Web.Mvc\Areas\GoodsManage\Views\Category\List.cshtml"
                               Write(item.CreationTime);

#line default
#line hidden
            EndContext();
            BeginContext(2108, 512, true);
            WriteLiteral(@"</th>
                                <td class=""dropdown"">
                                    <a href=""#"" class=""dropdown-toggle"" data-toggle=""dropdown"" role=""button"" aria-haspopup=""true"" aria-expanded=""false"">
                                        <i class=""material-icons"">menu</i>
                                    </a>
                                    <ul class=""dropdown-menu pull-right"">
                                        <li><a href=""#"" class=""waves-effect waves-block edit"" data-id=""");
            EndContext();
            BeginContext(2621, 7, false);
#line 52 "G:\杂项\Me\DemoCore\4.0.1\aspnet-core\src\DemoCore.Web.Mvc\Areas\GoodsManage\Views\Category\List.cshtml"
                                                                                                  Write(item.Id);

#line default
#line hidden
            EndContext();
            BeginContext(2628, 81, true);
            WriteLiteral("\" data-toggle=\"modal\" data-target=\"#EditModal\"><i class=\"material-icons\">edit</i>");
            EndContext();
            BeginContext(2710, 9, false);
#line 52 "G:\杂项\Me\DemoCore\4.0.1\aspnet-core\src\DemoCore.Web.Mvc\Areas\GoodsManage\Views\Category\List.cshtml"
                                                                                                                                                                                           Write(L("Edit"));

#line default
#line hidden
            EndContext();
            BeginContext(2719, 11, true);
            WriteLiteral("</a></li>\r\n");
            EndContext();
#line 53 "G:\杂项\Me\DemoCore\4.0.1\aspnet-core\src\DemoCore.Web.Mvc\Areas\GoodsManage\Views\Category\List.cshtml"
                                         if (IsGranted("GoodsCategory.Delete"))
                                        {

#line default
#line hidden
            BeginContext(2854, 159, true);
            WriteLiteral("                                            <li>\r\n                                                <a href=\"#\" class=\"waves-effect waves-block delete\" data-id=\"");
            EndContext();
            BeginContext(3014, 7, false);
#line 56 "G:\杂项\Me\DemoCore\4.0.1\aspnet-core\src\DemoCore.Web.Mvc\Areas\GoodsManage\Views\Category\List.cshtml"
                                                                                                        Write(item.Id);

#line default
#line hidden
            EndContext();
            BeginContext(3021, 13, true);
            WriteLiteral("\" data-name=\"");
            EndContext();
            BeginContext(3035, 10, false);
#line 56 "G:\杂项\Me\DemoCore\4.0.1\aspnet-core\src\DemoCore.Web.Mvc\Areas\GoodsManage\Views\Category\List.cshtml"
                                                                                                                             Write(item.Title);

#line default
#line hidden
            EndContext();
            BeginContext(3045, 98, true);
            WriteLiteral("\">\r\n                                                    <i class=\"material-icons\">delete_sweep</i>");
            EndContext();
            BeginContext(3144, 11, false);
#line 57 "G:\杂项\Me\DemoCore\4.0.1\aspnet-core\src\DemoCore.Web.Mvc\Areas\GoodsManage\Views\Category\List.cshtml"
                                                                                         Write(L("Delete"));

#line default
#line hidden
            EndContext();
            BeginContext(3155, 107, true);
            WriteLiteral("\r\n                                                </a>\r\n                                            </li>\r\n");
            EndContext();
#line 60 "G:\杂项\Me\DemoCore\4.0.1\aspnet-core\src\DemoCore.Web.Mvc\Areas\GoodsManage\Views\Category\List.cshtml"
                                        }

#line default
#line hidden
            BeginContext(3305, 119, true);
            WriteLiteral("\r\n                                    </ul>\r\n                                </td>\r\n                            </tr>\r\n");
            EndContext();
#line 65 "G:\杂项\Me\DemoCore\4.0.1\aspnet-core\src\DemoCore.Web.Mvc\Areas\GoodsManage\Views\Category\List.cshtml"
                        }

#line default
#line hidden
            BeginContext(3451, 687, true);
            WriteLiteral(@"                    </tbody>
                </table>
                <button type=""button"" class=""btn btn-primary btn-circle waves-effect waves-circle waves-float pull-right"" data-toggle=""modal"" data-target=""#CreateModal"">
                    <i class=""material-icons"">add</i>
                </button>
            </div>
        </div>
    </div>
</div>
<div class=""modal fade"" id=""CreateModal"" tabindex=""-1"" role=""dialog"" aria-labelledby=""CreateModalLabel"" data-backdrop=""static"">
    <div class=""modal-dialog"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h4 class=""modal-title"">
                    <span>");
            EndContext();
            BeginContext(4139, 11, false);
#line 80 "G:\杂项\Me\DemoCore\4.0.1\aspnet-core\src\DemoCore.Web.Mvc\Areas\GoodsManage\Views\Category\List.cshtml"
                     Write(L("Create"));

#line default
#line hidden
            EndContext();
            BeginContext(4150, 106, true);
            WriteLiteral("</span>\r\n                </h4>\r\n            </div>\r\n            <div class=\"modal-body\">\r\n                ");
            EndContext();
            BeginContext(4256, 1568, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8c7eea62de80434ba26615f01434ed99", async() => {
                BeginContext(4341, 444, true);
                WriteLiteral(@"
                    <div class=""row clearfix"">
                        <div class=""col-sm-12"">
                            <div class=""form-group form-float"">
                                <div class=""form-line"">
                                    <input id=""Title"" type=""text"" name=""Title"" required maxlength=""20"" minlength=""2"" class=""validate form-control"">
                                    <label for=""Title"" class=""form-label"">");
                EndContext();
                BeginContext(4786, 10, false);
#line 90 "G:\杂项\Me\DemoCore\4.0.1\aspnet-core\src\DemoCore.Web.Mvc\Areas\GoodsManage\Views\Category\List.cshtml"
                                                                     Write(L("Title"));

#line default
#line hidden
                EndContext();
                BeginContext(4796, 540, true);
                WriteLiteral(@"</label>
                                </div>
                            </div>
                        </div>
                    </div>
                    <div class=""row"">
                        <div class=""col-sm-12"">
                            <div class=""form-group form-float"">
                                <div class=""form-line"">
                                    <textarea id=""Memo"" name=""Memo"" class=""validate form-control""></textarea>
                                    <label for=""Memo"" class=""form-label"">");
                EndContext();
                BeginContext(5337, 9, false);
#line 100 "G:\杂项\Me\DemoCore\4.0.1\aspnet-core\src\DemoCore.Web.Mvc\Areas\GoodsManage\Views\Category\List.cshtml"
                                                                    Write(L("Memo"));

#line default
#line hidden
                EndContext();
                BeginContext(5346, 300, true);
                WriteLiteral(@"</label>
                                </div>
                            </div>
                        </div>
                    </div>

                    <div class=""modal-footer"">
                        <button type=""button"" class=""btn btn-default waves-effect"" data-dismiss=""modal"">");
                EndContext();
                BeginContext(5647, 11, false);
#line 107 "G:\杂项\Me\DemoCore\4.0.1\aspnet-core\src\DemoCore.Web.Mvc\Areas\GoodsManage\Views\Category\List.cshtml"
                                                                                                   Write(L("Cancel"));

#line default
#line hidden
                EndContext();
                BeginContext(5658, 94, true);
                WriteLiteral("</button>\r\n                        <button type=\"submit\" class=\"btn btn-primary waves-effect\">");
                EndContext();
                BeginContext(5753, 9, false);
#line 108 "G:\杂项\Me\DemoCore\4.0.1\aspnet-core\src\DemoCore.Web.Mvc\Areas\GoodsManage\Views\Category\List.cshtml"
                                                                              Write(L("Save"));

#line default
#line hidden
                EndContext();
                BeginContext(5762, 55, true);
                WriteLiteral("</button>\r\n                    </div>\r\n                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            BeginWriteTagHelperAttribute();
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("novalidate", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(5824, 56, true);
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<CategoryListDto>> Html { get; private set; }
    }
}
#pragma warning restore 1591
