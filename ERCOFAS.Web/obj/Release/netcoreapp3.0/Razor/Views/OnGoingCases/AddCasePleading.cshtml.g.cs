#pragma checksum "C:\Projects\ERCOFAS\ercofas.web\ERCOFAS.Web\Views\OnGoingCases\AddCasePleading.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c06bd35d783d740aa4f4abb79c74a41488e332d0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_OnGoingCases_AddCasePleading), @"mvc.1.0.view", @"/Views/OnGoingCases/AddCasePleading.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c06bd35d783d740aa4f4abb79c74a41488e332d0", @"/Views/OnGoingCases/AddCasePleading.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"60f8273389c73ee67b936bf8b94df025c2d5af05", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_OnGoingCases_AddCasePleading : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/javascript"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/prefiling.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("names", "Development", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("names", "Staging,Production", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.EnvironmentTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_EnvironmentTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Projects\ERCOFAS\ercofas.web\ERCOFAS.Web\Views\OnGoingCases\AddCasePleading.cshtml"
  
    ViewData["Title"] = "Add Case/Pleading";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"row wrapper border-bottom white-bg page-heading\">\r\n    <div class=\"col-lg-10\">\r\n        <h2>New Case/Pleading</h2>\r\n        <ol class=\"breadcrumb\">\r\n            <li class=\"breadcrumb-item\">\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 274, "\"", 321, 1);
#nullable restore
#line 9 "C:\Projects\ERCOFAS\ercofas.web\ERCOFAS.Web\Views\OnGoingCases\AddCasePleading.cshtml"
WriteAttributeValue("", 281, Url.Action("Dashboard_1", "Dashboards"), 281, 40, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">Dashboard</a>
            </li>
            <li class=""breadcrumb-item"">
                Case/Pleadings
            </li>
            <li class=""active breadcrumb-item"">
                <strong>Add Case/Pleading</strong>
            </li>
        </ol>
    </div>
    <div class=""col-lg-2""></div>
</div>
<div id=""pleading-content"" class=""wrapper wrapper-content"">
    <div class=""row"">
        <div class=""col-lg-12"">
            <div class=""tabs-container"">
                <ul class=""nav nav-tabs"" role=""tablist"">
                    <li><a class=""nav-link active"" data-toggle=""tab"" href=""#tab-1"">General</a></li>
                    <li>
                        <a class=""nav-link"" data-toggle=""tab"" href=""#tab-2"">
                            Uploaded Documents ( <span class=""tab-count"">3</span> )
                        </a>
                    </li>
                </ul>
                <div class=""tab-content"">
                    <div role=""tabpanel"" id=""tab-1"" class=""tab-pane active"">");
            WriteLiteral(@"
                        <div class=""panel-body"">
                            <p>
                                <mark><i>All fields with red asterisk ( <span class=""text-danger font-bold"">*</span> ) are required to fill.</i></mark>
                            </p>
                            <div class=""row"">
                                <div class=""col-lg-12"">
                                    <div class=""alert alert-success alert-dismissable"">
                                        <button data-type=""success"" aria-hidden=""true"" class=""close"" type=""button"">??</button>
                                        <strong>Success!</strong> Your have been successfully filed a case/pleading.
                                    </div>
                                    <div class=""alert alert-danger alert-dismissable"">
                                        <button data-type=""danger"" aria-hidden=""true"" class=""close"" type=""button"">??</button>
                                        <strong>Error!</s");
            WriteLiteral(@"trong> <span class=""danger-text""></span>
                                    </div>
                                    <div class=""row"">
                                        <div class=""col-lg-6"">
                                            <div class=""form-group"">
                                                <label>Subject of Request <span class=""text-danger font-bold"">*</span></label>
                                                <input type=""text"" class=""form-control subject-request-text"">
                                            </div>
                                        </div>
                                        <div class=""col-lg-6"">
                                            <div class=""form-group"">
                                                <label>Full Name <span class=""text-danger font-bold"">*</span></label>
                                                <input type=""text"" class=""form-control full-name-text"" value=""Angel Lacson"" readonly>
                      ");
            WriteLiteral(@"                      </div>
                                        </div>
                                    </div>
                                    <div class=""row"">
                                        <div class=""col-lg-6"">
                                            <div class=""form-group"">
                                                <label>Case Type <span class=""text-danger font-bold"">*</span></label>
                                                <select class=""form-control m-b case-type-select"" name=""case-type"">
                                                </select>
                                            </div>
                                        </div>
                                        <div class=""col-lg-6"">
                                            <div class=""form-group"">
                                                <label>Case Nature <span class=""text-danger font-bold"">*</span></label>
                                                <select class=""");
            WriteLiteral(@"form-control m-b case-nature-select"" name=""case-nature"">
                                                </select>
                                            </div>
                                        </div>
                                    </div>
                                    <div class=""row"">
                                        <div class=""col-lg-12"">
                                            <div class=""form-group"">
                                                <label>Remarks </label>
                                                <textarea rows=""2"" cols=""50"" class=""form-control remarks-text""></textarea>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                                <div class=""col-lg-12"">
                                    <div class=""form-group"">
                                        <label>
                        ");
            WriteLiteral(@"                    <input type=""checkbox"" class=""authorized-check""> I the sender, declare that I am the duly authorized representative to undertake the pre-filing process.
                                        </label>
                                        <br />
                                        <label>
                                            <input type=""checkbox"" class=""complete-check""> I hereby declare that the documents submitted are complete and true copies of the original documents.
                                        </label>
                                        <br />
                                        <label>
                                            <input type=""checkbox"" class=""policies-check""> I agree to the terms and policies of the Energy Regulatory Commission.
                                        </label>
                                    </div>
                                </div>
                            </div>
                            <");
            WriteLiteral(@"div class=""hr-line-dashed""></div>

                            <div class=""form-group row"">
                                <div class=""col-sm-4 col-sm-offset-2"">
                                    <button class=""btn btn-info btn-md save-changes"" type=""submit"">
                                        <i class=""fa fa-thumbs-o-up""></i> File Case
                                    </button>
                                    <button");
            BeginWriteAttribute("onclick", " onclick=\"", 6909, "\"", 6979, 3);
            WriteAttributeValue("", 6919, "location.href=\'", 6919, 15, true);
#nullable restore
#line 111 "C:\Projects\ERCOFAS\ercofas.web\ERCOFAS.Web\Views\OnGoingCases\AddCasePleading.cshtml"
WriteAttributeValue("", 6934, Url.Action("CasePleadings", "OnGoingCases"), 6934, 44, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 6978, "\'", 6978, 1, true);
            EndWriteAttribute();
            WriteLiteral(@" class=""btn btn-white btn-md"" type=""submit"">
                                        <i class=""fa fa-times""></i> Close
                                    </button>
                                </div>
                            </div>
                        </div>
                    </div>
                    <div role=""tabpanel"" id=""tab-2"" class=""tab-pane"">
                        <div class=""panel-body"">
                            <div class=""theme-experttipimportant mntl-sc-block money-sc-block-callout mntl-sc-block-callout mntl-block"" data-tracking-id=""mntl-sc-block-callout"" data-tracking-container=""true"">
                                <h4><i class=""fa fa-edit""></i> Note:</h4>
                                <div class=""mntl-sc-block-callout-body mntl-text-block"">
                                    <p class=""font-italic""><mark>Please ensure that the filenames of the soft/electronic copies of the applications/petitions, annexes, other supporting documents, pre-filing requirements are ");
            WriteLiteral(@"the same as the document title.</mark></p>
                                </div>
                            </div>
                            <div class=""row"">
                                <div class=""col-lg-12"">
                                    <div class=""form-group has-success row"">
                                        <div class=""col-sm-2"">
                                            <button id=""add-role-button"" type=""button"" class=""btn btn-info"">
                                                <i class=""fa fa-plus""></i> Add
                                            </button>
                                        </div>
                                        <div class=""col-sm-10"">
                                            <div class=""input-group"">
                                                <input id=""search-role-text"" type=""text"" class=""form-control"" placeholder=""Search uploaded documents here..."">
                                                <span class=""input-gr");
            WriteLiteral(@"oup-append"">
                                                    <button id=""search-role-button"" type=""button"" class=""btn btn-info"">Search</button>
                                                </span>
                                            </div>
                                        </div>
                                    </div>

                                    <table class=""table table-striped mt-3"">
                                        <thead>
                                            <tr>
                                                <th>Document Name</th>
                                                <th class=""text-center"">Required</th>
                                                <th>Upload File</th>
                                                <th class=""text-center"">Action</th>
                                            </tr>
                                        </thead>
                                        <tbody>
                              ");
            WriteLiteral(@"              <tr>
                                                <td>Scanned Copy of Certification or Authorization of your Company</td>
                                                <td class=""text-center"">YES</td>
                                                <td>
                                                    <input type=""file"" id=""myFile"" name=""filename"">
                                                </td>
                                                <td class=""text-center"">
                                                    <button type=""button"" class=""btn btn-md btn-danger remove-btn""><i class=""fa fa-times""></i> Remove</button>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td>Company or Goverment Issued Identification Cards (IDs)</td>
                                                <td class=""text-center"">YES</td>
      ");
            WriteLiteral(@"                                          <td>
                                                    <input type=""file"" id=""myFile"" name=""filename"">
                                                </td>
                                                <td class=""text-center"">
                                                    <button type=""button"" class=""btn btn-md btn-danger remove-btn""><i class=""fa fa-times""></i> Remove</button>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td>Barangay Clearance</td>
                                                <td class=""text-center"">NO</td>
                                                <td>
                                                    <input type=""file"" id=""myFile"" name=""filename"">
                                                </td>
                                                <td class=""tex");
            WriteLiteral(@"t-center"">
                                                    <button type=""button"" class=""btn btn-md btn-danger remove-btn""><i class=""fa fa-times""></i> Remove</button>
                                                </td>
                                            </tr>
                                        </tbody>
                                    </table>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>

");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("environment", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c06bd35d783d740aa4f4abb79c74a41488e332d018897", async() => {
                    WriteLiteral("\r\n    ");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c06bd35d783d740aa4f4abb79c74a41488e332d019175", async() => {
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                    __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                    __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    WriteLiteral("\r\n");
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
                WriteLiteral("\r\n");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("environment", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c06bd35d783d740aa4f4abb79c74a41488e332d021391", async() => {
                    WriteLiteral("\r\n    ");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c06bd35d783d740aa4f4abb79c74a41488e332d021669", async() => {
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                    __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                    __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    WriteLiteral("\r\n");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_EnvironmentTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.EnvironmentTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_EnvironmentTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_EnvironmentTagHelper.Names = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
            }
            );
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
