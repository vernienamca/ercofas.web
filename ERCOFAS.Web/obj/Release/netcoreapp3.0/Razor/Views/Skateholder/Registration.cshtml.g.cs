#pragma checksum "C:\Projects\ERCOFAS\ercofas.web\ERCOFAS.Web\Views\Skateholder\Registration.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9efdf1dc82208dc3d4476ebeaf433febcb46fe12"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Skateholder_Registration), @"mvc.1.0.view", @"/Views/Skateholder/Registration.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9efdf1dc82208dc3d4476ebeaf433febcb46fe12", @"/Views/Skateholder/Registration.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"60f8273389c73ee67b936bf8b94df025c2d5af05", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Skateholder_Registration : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("role", new global::Microsoft.AspNetCore.Html.HtmlString("form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Projects\ERCOFAS\ercofas.web\ERCOFAS.Web\Views\Skateholder\Registration.cshtml"
  
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<!DOCTYPE html>
<html>
<meta name=""viewport"" content=""width=device-width, initial-scale=1.0"">
<link href=""//maxcdn.bootstrapcdn.com/bootstrap/3.3.0/css/bootstrap.min.css"" rel=""stylesheet"" id=""bootstrap-css"">
<style type=""text/css"">
    body {
        background-image: url(""/images/background/abstract-vector.webp"");
        background-repeat: no-repeat;
        background-size: auto;
        margin-top: 30px;
    }

    .stepwizard-step p {
        margin-top: 0px;
        color: #666;
    }

    .stepwizard-row {
        display: table-row;
    }

    .stepwizard {
        display: table;
        width: 100%;
        position: relative;
    }

    .stepwizard-step button[disabled] {
        /*opacity: 1 !important;
        filter: alpha(opacity=100) !important;*/
    }

    .stepwizard .btn.disabled, .stepwizard .btn[disabled], .stepwizard fieldset[disabled] .btn {
        opacity: 1 !important;
        color: #bbb;
    }

    .stepwizard-row:before {
        top: 14px;");
            WriteLiteral(@"
        bottom: 0;
        position: absolute;
        content: "" "";
        width: 100%;
        height: 1px;
        background-color: #ccc;
        z-index: 0;
    }

    .stepwizard-step {
        display: table-cell;
        text-align: center;
        position: relative;
    }

    .btn-circle {
        width: 30px;
        height: 30px;
        text-align: center;
        padding: 6px 0;
        font-size: 12px;
        line-height: 1.428571429;
        border-radius: 15px;
    }

   .panel-primary>.panel-heading {
        background-color: #4c66b0;
        border-color: #4c66b0;
    }

    .btn-success {
        background-color: #4c66b0;
        border-color: #4c66b0;
    }

    .stepwizard h3 {
        font-size: 20px;
        font-weight: normal;
    }
</style>
<script src=""//maxcdn.bootstrapcdn.com/bootstrap/3.3.0/js/bootstrap.min.js""></script>
<script src=""//cdnjs.cloudflare.com/ajax/libs/jquery/3.2.1/jquery.min.js""></script>
<script type=""text/javascri");
            WriteLiteral(@"pt"">
        $(document).ready(function () {

        var navListItems = $('div.setup-panel div a'),
            allWells = $('.setup-content'),
            allNextBtn = $('.nextBtn');

        allWells.hide();

        navListItems.click(function (e) {
            e.preventDefault();
            var $target = $($(this).attr('href')),
                $item = $(this);

            if (!$item.hasClass('disabled')) {
                navListItems.removeClass('btn-success').addClass('btn-default');
                $item.addClass('btn-success');
                allWells.hide();
                $target.show();
                $target.find('input:eq(0)').focus();
            }
        });

        allNextBtn.click(function () {
            var curStep = $(this).closest("".setup-content""),
                curStepBtn = curStep.attr(""id""),
                nextStepWizard = $('div.setup-panel div a[href=""#' + curStepBtn + '""]').parent().next().children(""a""),
                curInputs = curStep.fi");
            WriteLiteral(@"nd(""input[type='text'],input[type='url']""),
                isValid = true;

            $("".form-group"").removeClass(""has-error"");
            for (var i = 0; i < curInputs.length; i++) {
                if (!curInputs[i].validity.valid) {
                    isValid = false;
                    $(curInputs[i]).closest("".form-group"").addClass(""has-error"");
                }
            }

            if (isValid) nextStepWizard.removeAttr('disabled').trigger('click');
        });

        $('div.setup-panel div a.btn-success').trigger('click');
    });
</script>
");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9efdf1dc82208dc3d4476ebeaf433febcb46fe127585", async() => {
                WriteLiteral(@"
    <div class=""container"">
        <div class=""stepwizard"">
            <div class=""stepwizard-row setup-panel"">
                <div class=""stepwizard-step col-xs-3"">
                    <a href=""#step-1"" type=""button"" class=""btn btn-success btn-circle"">1</a>
                    <h3>Type/Class of RER</h3>
                </div>
                <div class=""stepwizard-step col-xs-3"">
                    <a href=""#step-2"" type=""button"" class=""btn btn-default btn-circle"" disabled=""disabled"">2</a>
                    <h3>Individual Person Form</h3>
                </div>
                <div class=""stepwizard-step col-xs-3"">
                    <a href=""#step-3"" type=""button"" class=""btn btn-default btn-circle"" disabled=""disabled"">3</a>
                    <h3>Send Files</h3>
                </div>
                <div class=""stepwizard-step col-xs-3"">
                    <a href=""#step-4"" type=""button"" class=""btn btn-default btn-circle"" disabled=""disabled"">4</a>
                    <h3>Verific");
                WriteLiteral("ation Process</h3>\r\n                </div>\r\n            </div>\r\n        </div>\r\n\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9efdf1dc82208dc3d4476ebeaf433febcb46fe129043", async() => {
                    WriteLiteral(@"
            <div class=""panel panel-primary setup-content"" id=""step-1"">
                <div class=""panel-heading"">
                    <h3 class=""panel-title"">Type/Class of RER</h3>
                </div>
                <div class=""panel-body"">
                     <h3>
                            <i class=""fa fa-flickr""></i> 
                            Step 1 - Type of RER <span class=""text-danger font-bold"">*</span>
                        </h3>
                        <div class=""form-group"">
                            <div>
                                <label>
                                    <input type=""radio"" class=""individual-radio"" checked=""checked"" value=""option1"" name=""rer-types""> 
                                    Individual (<i>Consumers</i>)
                                </label>
                            </div>
                            <div>
                                <label>
                                    <input type=""radio"" class=""juridical-rad");
                    WriteLiteral(@"io"" value=""option2"" id=""optionsRadios2"" name=""rer-types""> 
                                    Juridical Entity (<i>DU, TransCo, GenCo, RES, QTP, Counsel, Gov't Agency</i>)
                                </label>
                            </div>
                        </div>

                    <div class=""form-group"">
                        <label class=""control-label"">First Name</label>
                        <input maxlength=""100"" type=""text"" required=""required"" class=""form-control"" placeholder=""Enter First Name"" />
                    </div>
                    <div class=""form-group"">
                        <label class=""control-label"">Last Name</label>
                        <input maxlength=""100"" type=""text"" required=""required"" class=""form-control"" placeholder=""Enter Last Name"" />
                    </div>
                    <button class=""btn btn-primary nextBtn pull-right"" type=""button"">Next</button>
                </div>
            </div>

            <div class=""panel");
                    WriteLiteral(@" panel-primary setup-content"" id=""step-2"">
                <div class=""panel-heading"">
                    <h3 class=""panel-title"">Individual Person Form</h3>
                </div>
                <div class=""panel-body"">
                    <div class=""form-group"">
                        <label class=""control-label"">Company Name</label>
                        <input maxlength=""200"" type=""text"" required=""required"" class=""form-control"" placeholder=""Enter Company Name"" />
                    </div>
                    <div class=""form-group"">
                        <label class=""control-label"">Company Address</label>
                        <input maxlength=""200"" type=""text"" required=""required"" class=""form-control"" placeholder=""Enter Company Address"" />
                    </div>
                    <button class=""btn btn-primary nextBtn pull-right"" type=""button"">Next</button>
                </div>
            </div>

            <div class=""panel panel-primary setup-content"" id=""step-3"">");
                    WriteLiteral(@"
                <div class=""panel-heading"">
                    <h3 class=""panel-title"">Schedule</h3>
                </div>
                <div class=""panel-body"">
                    <div class=""form-group"">
                        <label class=""control-label"">Company Name</label>
                        <input maxlength=""200"" type=""text"" required=""required"" class=""form-control"" placeholder=""Enter Company Name"" />
                    </div>
                    <div class=""form-group"">
                        <label class=""control-label"">Company Address</label>
                        <input maxlength=""200"" type=""text"" required=""required"" class=""form-control"" placeholder=""Enter Company Address"" />
                    </div>
                    <button class=""btn btn-primary nextBtn pull-right"" type=""button"">Next</button>
                </div>
            </div>

            <div class=""panel panel-primary setup-content"" id=""step-4"">
                <div class=""panel-heading"">
           ");
                    WriteLiteral(@"         <h3 class=""panel-title"">Cargo</h3>
                </div>
                <div class=""panel-body"">
                    <div class=""form-group"">
                        <label class=""control-label"">Company Name</label>
                        <input maxlength=""200"" type=""text"" required=""required"" class=""form-control"" placeholder=""Enter Company Name"" />
                    </div>
                    <div class=""form-group"">
                        <label class=""control-label"">Company Address</label>
                        <input maxlength=""200"" type=""text"" required=""required"" class=""form-control"" placeholder=""Enter Company Address"" />
                    </div>
                    <button class=""btn btn-success pull-right"" type=""submit"">Finish!</button>
                </div>
            </div>
        ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    </div>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>\r\n");
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
