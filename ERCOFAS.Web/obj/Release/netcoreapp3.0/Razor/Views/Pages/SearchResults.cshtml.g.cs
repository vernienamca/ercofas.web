#pragma checksum "C:\Projects\ERCOFAS\ercofas.web\ERCOFAS.Web\Views\Pages\SearchResults.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8475bc9861a16f99085a856b35843a60e7fbbdce"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Pages_SearchResults), @"mvc.1.0.view", @"/Views/Pages/SearchResults.cshtml")]
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
#line 1 "C:\Projects\ERCOFAS\ercofas.web\ERCOFAS.Web\Views\_ViewImports.cshtml"
using ASPNET_Core_3;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8475bc9861a16f99085a856b35843a60e7fbbdce", @"/Views/Pages/SearchResults.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"60f8273389c73ee67b936bf8b94df025c2d5af05", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Pages_SearchResults : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Projects\ERCOFAS\ercofas.web\ERCOFAS.Web\Views\Pages\SearchResults.cshtml"
  
    ViewData["Title"] = "SearchResults";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"row wrapper border-bottom white-bg page-heading\">\r\n    <div class=\"col-lg-9\">\r\n        <h2>\tSearch Page</h2>\r\n        <ol class=\"breadcrumb\">\r\n            <li class=\"breadcrumb-item\">\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 268, "\"", 315, 1);
#nullable restore
#line 11 "C:\Projects\ERCOFAS\ercofas.web\ERCOFAS.Web\Views\Pages\SearchResults.cshtml"
WriteAttributeValue("", 275, Url.Action("Dashboard_1", "Dashboards"), 275, 40, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">Home</a>
            </li>
            <li class=""breadcrumb-item"">
                Extra Pages
            </li>
            <li class=""active breadcrumb-item"">
                <strong>	Search Page</strong>
            </li>
        </ol>
    </div>
</div>
<div class=""wrapper wrapper-content animated fadeInRight"">
    <div class=""row"">
        <div class=""col-lg-12"">
            <div class=""ibox "">
                <div class=""ibox-content"">
                    <h2>
                        2,160 results found for: <span class=""text-navy"">“Admin Theme”</span>
                    </h2>
                    <small>Request time  (0.23 seconds)</small>

                    <div class=""search-form"">
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8475bc9861a16f99085a856b35843a60e7fbbdce5017", async() => {
                WriteLiteral(@"
                                    <div class=""input-group mb-3"">
                                        <input type=""text"" class=""form-control"" placeholder=""Admin Theme"" aria-label=""Admin Theme"" aria-describedby=""button-addon2"">
                                        <div class=""input-group-append"">
                                          <button class=""btn btn-primary"" type=""button"" id=""button-addon2"">Search</button>
                                        </div>
                                      </div>

                                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "action", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 33 "C:\Projects\ERCOFAS\ercofas.web\ERCOFAS.Web\Views\Pages\SearchResults.cshtml"
AddHtmlAttributeValue("", 1079, Url.Action("Dashboard_1", "Dashboards"), 1079, 40, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                    </div>
                    <div class=""hr-line-dashed""></div>
                    <div class=""search-result"">
                        <h3><a href=""#"">ERCOFAS IN+ Admin Theme</a></h3>
                        <a href=""#"" class=""search-link"">www.inspinia.com/inspinia</a>
                        <p>
                            Many desktop publishing packages and web page editors now use Lorem Ipsum as their default model text, and a search for 'lorem ipsum' will uncover many web sites
                            still in their infancy. Various versions have evolved over the years, sometimes by accident, sometimes on purpose (injected humour and the like).
                        </p>
                    </div>
                    <div class=""hr-line-dashed""></div>
                    <div class=""search-result"">
                        <h3><a href=""#"">WrapBootstrap - Bootstrap Themes & Templates</a></h3>
                        <a href=""#"" class=""search-link"">https://wrapbootstr");
            WriteLiteral(@"ap.com/‎</a>
                        <p>
                            WrapBootstrap is a marketplace for premium Bootstrap themes and templates. Impress your clients and visitors while using a single, rock-solid foundation.
                        </p>
                    </div>
                    <div class=""hr-line-dashed""></div>
                    <div class=""search-result"">
                        <h3><a href=""#"">WrapBootstrap | Facebook</a></h3>
                        <a href=""#"" class=""search-link"">https://www.facebook.com/wrapbootstrap‎</a>
                        <p>
                            WrapBootstrap. 13672 likes · 508 talking about this. Marketplace for premium Bootstrap themes and templates. https://wrapbootstrap.com/
                        </p>
                    </div>
                    <div class=""hr-line-dashed""></div>
                    <div class=""search-result"">
                        <h3><a href=""#"">Wrapbootstrap - Quora</a></h3>
                        <a hre");
            WriteLiteral(@"f=""#"" class=""search-link"">www.quora.com/Wrapbootstrap‎‎</a>
                        <p>
                            If you are familiar with using any other HTML/CSS themes or WordPress themes then you shouldn't have any problems. If you have some experience using the ...
                        </p>
                    </div>
                    <div class=""hr-line-dashed""></div>
                    <div class=""search-result"">
                        <h3><a href=""#"">Newspaper Template - Wrapbootstrap Free download ...</a></h3>
                        <a href=""#"" class=""search-link"">https://wrapbootstrap.com/‎‎</a>
                        <p>
                            What's black, white and red all over? The answer is Newspaper. A stylish magazine/news style theme inspired by black and white newsprint. The theme is.
                        </p>
                    </div>
                    <div class=""hr-line-dashed""></div>
                    <div class=""search-result"">
                   ");
            WriteLiteral(@"     <h3><a href=""#"">Admin Themes Wrapbootstrap</a></h3>
                        <a href=""#"" class=""search-link"">https://wrapbootstrap.com/themes/admin‎‎</a>
                        <p>
                            It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.
                        </p>
                    </div>
                    <div class=""hr-line-dashed""></div>
                    <div class=""text-center"">
                        <div class=""btn-group"">
                            <button class=""btn btn-white"" type=""button""><i class=""fa fa-chevron-left""></i></button>
                            <button class=""btn btn-white"">1</button>
                            <button class=""btn btn-white  active"">2</button>
                            <button class=""btn btn-white"">3</button>
                            <button class=""btn btn-wh");
            WriteLiteral(@"ite"">4</button>
                            <button class=""btn btn-white"">5</button>
                            <button class=""btn btn-white"">6</button>
                            <button class=""btn btn-white"">7</button>
                            <button class=""btn btn-white"" type=""button""><i class=""fa fa-chevron-right""></i> </button>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>


");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
