#pragma checksum "C:\Users\Vernie Namca\Desktop\My Files\BusyBee\Projects\ERCOFAS\ERCOFAS.Web\ERCOFAS.Web\Views\Shared\_Navigation.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "43b0415c4f9964d793383d11f5c9afae7bc970b7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Navigation), @"mvc.1.0.view", @"/Views/Shared/_Navigation.cshtml")]
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
#line 1 "C:\Users\Vernie Namca\Desktop\My Files\BusyBee\Projects\ERCOFAS\ERCOFAS.Web\ERCOFAS.Web\Views\_ViewImports.cshtml"
using ASPNET_Core_3;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"43b0415c4f9964d793383d11f5c9afae7bc970b7", @"/Views/Shared/_Navigation.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"60f8273389c73ee67b936bf8b94df025c2d5af05", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared__Navigation : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("image"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("rounded-circle"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Images/a9.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<nav class=""navbar-default navbar-static-side"" role=""navigation"">
    <div class=""sidebar-collapse"">
        <ul class=""nav metismenu"" id=""side-menu"">
            <li class=""nav-header"">
                <div class=""dropdown profile-element"">
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "43b0415c4f9964d793383d11f5c9afae7bc970b74386", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                    <a data-toggle=""dropdown"" class=""dropdown-toggle"" href=""#"">
                        <span class=""block m-t-xs font-bold"">Angel Lacson</span>
                        <span class=""text-muted text-xs block"">Company Staff <b class=""caret""></b></span>
                    </a>
                    <ul class=""dropdown-menu animated fadeInRight m-t-xs"" style=""position: absolute; top: 91px; left: 0px; will-change: top, left;"">
                        <li><a class=""dropdown-item""");
            BeginWriteAttribute("href", " href=\"", 831, "\"", 872, 1);
#nullable restore
#line 12 "C:\Users\Vernie Namca\Desktop\My Files\BusyBee\Projects\ERCOFAS\ERCOFAS.Web\ERCOFAS.Web\Views\Shared\_Navigation.cshtml"
WriteAttributeValue("", 838, Url.Action("Profile", "AppViews"), 838, 34, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Profile</a></li>\r\n                        <li><a class=\"dropdown-item\"");
            BeginWriteAttribute("href", " href=\"", 944, "\"", 986, 1);
#nullable restore
#line 13 "C:\Users\Vernie Namca\Desktop\My Files\BusyBee\Projects\ERCOFAS\ERCOFAS.Web\ERCOFAS.Web\Views\Shared\_Navigation.cshtml"
WriteAttributeValue("", 951, Url.Action("Contacts", "AppViews"), 951, 35, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Contacts</a></li>\r\n                        <li><a class=\"dropdown-item\"");
            BeginWriteAttribute("href", " href=\"", 1059, "\"", 1097, 1);
#nullable restore
#line 14 "C:\Users\Vernie Namca\Desktop\My Files\BusyBee\Projects\ERCOFAS\ERCOFAS.Web\ERCOFAS.Web\Views\Shared\_Navigation.cshtml"
WriteAttributeValue("", 1066, Url.Action("Inbox", "Mailbox"), 1066, 31, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Mailbox</a></li>\r\n                        <li class=\"dropdown-divider\"></li>\r\n                        <li><a class=\"dropdown-item\"");
            BeginWriteAttribute("href", " href=\"", 1229, "\"", 1265, 1);
#nullable restore
#line 16 "C:\Users\Vernie Namca\Desktop\My Files\BusyBee\Projects\ERCOFAS\ERCOFAS.Web\ERCOFAS.Web\Views\Shared\_Navigation.cshtml"
WriteAttributeValue("", 1236, Url.Action("Login", "Pages"), 1236, 29, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Logout</a></li>\r\n                    </ul>\r\n                </div>\r\n                <div class=\"logo-element\">\r\n                    <img class=\"logo\"");
            BeginWriteAttribute("src", " src=\"", 1416, "\"", 1461, 1);
#nullable restore
#line 20 "C:\Users\Vernie Namca\Desktop\My Files\BusyBee\Projects\ERCOFAS\ERCOFAS.Web\ERCOFAS.Web\Views\Shared\_Navigation.cshtml"
WriteAttributeValue("", 1422, Url.Content("~/images/logo/65x65.png"), 1422, 39, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"ERC-OFAS\">\r\n                </div>\r\n            </li>\r\n            <li");
            BeginWriteAttribute("class", " class=\"", 1538, "\"", 1586, 1);
#nullable restore
#line 23 "C:\Users\Vernie Namca\Desktop\My Files\BusyBee\Projects\ERCOFAS\ERCOFAS.Web\ERCOFAS.Web\Views\Shared\_Navigation.cshtml"
WriteAttributeValue("", 1546, Url.Action("Dashboard_1", "Dashboards"), 1546, 40, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 1608, "\"", 1655, 1);
#nullable restore
#line 24 "C:\Users\Vernie Namca\Desktop\My Files\BusyBee\Projects\ERCOFAS\ERCOFAS.Web\ERCOFAS.Web\Views\Shared\_Navigation.cshtml"
WriteAttributeValue("", 1615, Url.Action("Dashboard_1", "Dashboards"), 1615, 40, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                    <i class=\"fa fa-th-large\"></i>\r\n                    <span class=\"nav-label\" data-i18n=\"nav.dashboard\">Dashboard <span class=\"label label-warning float-right\">12</span></span>\r\n                </a>\r\n            </li>\r\n            <li");
            BeginWriteAttribute("class", " class=\"", 1911, "\"", 1959, 1);
#nullable restore
#line 29 "C:\Users\Vernie Namca\Desktop\My Files\BusyBee\Projects\ERCOFAS\ERCOFAS.Web\ERCOFAS.Web\Views\Shared\_Navigation.cshtml"
WriteAttributeValue("", 1919, Html.IsSelected(controller: "Hearings"), 1919, 40, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 1981, "\"", 2019, 1);
#nullable restore
#line 30 "C:\Users\Vernie Namca\Desktop\My Files\BusyBee\Projects\ERCOFAS\ERCOFAS.Web\ERCOFAS.Web\Views\Shared\_Navigation.cshtml"
WriteAttributeValue("", 1988, Url.Action("Index", "Layouts"), 1988, 31, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><i class=\"fa fa-newspaper-o\"></i> <span class=\"nav-label\" data-i18n=\"nav.layouts\">Hearings</span> </a>\r\n            </li>\r\n            <li");
            BeginWriteAttribute("class", " class=\"", 2159, "\"", 2206, 1);
#nullable restore
#line 32 "C:\Users\Vernie Namca\Desktop\My Files\BusyBee\Projects\ERCOFAS\ERCOFAS.Web\ERCOFAS.Web\Views\Shared\_Navigation.cshtml"
WriteAttributeValue("", 2167, Html.IsSelected(controller: "Layouts"), 2167, 39, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 2228, "\"", 2266, 1);
#nullable restore
#line 33 "C:\Users\Vernie Namca\Desktop\My Files\BusyBee\Projects\ERCOFAS\ERCOFAS.Web\ERCOFAS.Web\Views\Shared\_Navigation.cshtml"
WriteAttributeValue("", 2235, Url.Action("Index", "Layouts"), 2235, 31, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><i class=\"fa fa-briefcase\"></i> <span class=\"nav-label\" data-i18n=\"nav.layouts\">On-Going Cases</span> </a>\r\n            </li>\r\n            <li");
            BeginWriteAttribute("class", " class=\"", 2410, "\"", 2457, 1);
#nullable restore
#line 35 "C:\Users\Vernie Namca\Desktop\My Files\BusyBee\Projects\ERCOFAS\ERCOFAS.Web\ERCOFAS.Web\Views\Shared\_Navigation.cshtml"
WriteAttributeValue("", 2418, Html.IsSelected(controller: "Metrics"), 2418, 39, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 2479, "\"", 2517, 1);
#nullable restore
#line 36 "C:\Users\Vernie Namca\Desktop\My Files\BusyBee\Projects\ERCOFAS\ERCOFAS.Web\ERCOFAS.Web\Views\Shared\_Navigation.cshtml"
WriteAttributeValue("", 2486, Url.Action("Index", "Metrics"), 2486, 31, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><i class=\"fa fa-tasks\"></i> <span class=\"nav-label\" data-i18n=\"nav.metrics\">Transactions</span> </a>\r\n            </li>\r\n            <li");
            BeginWriteAttribute("class", " class=\"", 2655, "\"", 2702, 1);
#nullable restore
#line 38 "C:\Users\Vernie Namca\Desktop\My Files\BusyBee\Projects\ERCOFAS\ERCOFAS.Web\ERCOFAS.Web\Views\Shared\_Navigation.cshtml"
WriteAttributeValue("", 2663, Html.IsSelected(controller: "Widgets"), 2663, 39, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 2724, "\"", 2762, 1);
#nullable restore
#line 39 "C:\Users\Vernie Namca\Desktop\My Files\BusyBee\Projects\ERCOFAS\ERCOFAS.Web\ERCOFAS.Web\Views\Shared\_Navigation.cshtml"
WriteAttributeValue("", 2731, Url.Action("Index", "Widgets"), 2731, 31, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><i class=\"fa fa-bookmark\"></i> <span class=\"nav-label\" data-i18n=\"nav.widgets\">Knowledge Based</span> </a>\r\n            </li>\r\n            <li");
            BeginWriteAttribute("class", " class=\"", 2906, "\"", 2960, 1);
#nullable restore
#line 41 "C:\Users\Vernie Namca\Desktop\My Files\BusyBee\Projects\ERCOFAS\ERCOFAS.Web\ERCOFAS.Web\Views\Shared\_Navigation.cshtml"
WriteAttributeValue("", 2914, Html.IsSelected(controller: "UserManagement"), 2914, 46, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 2982, "\"", 3029, 1);
#nullable restore
#line 42 "C:\Users\Vernie Namca\Desktop\My Files\BusyBee\Projects\ERCOFAS\ERCOFAS.Web\ERCOFAS.Web\Views\Shared\_Navigation.cshtml"
WriteAttributeValue("", 2989, Url.Action("Dashboard_1", "Dashboards"), 2989, 40, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><i class=\"fa fa-users\"></i> <span class=\"nav-label\" data-i18n=\"nav.dashboard\">User Management</span> <span class=\"fa arrow\"></span></a>\r\n                <ul");
            BeginWriteAttribute("class", " class=\"", 3187, "\"", 3287, 4);
            WriteAttributeValue("", 3195, "nav", 3195, 3, true);
            WriteAttributeValue(" ", 3198, "nav-second-level", 3199, 17, true);
            WriteAttributeValue(" ", 3215, "collapse", 3216, 9, true);
#nullable restore
#line 43 "C:\Users\Vernie Namca\Desktop\My Files\BusyBee\Projects\ERCOFAS\ERCOFAS.Web\ERCOFAS.Web\Views\Shared\_Navigation.cshtml"
WriteAttributeValue(" ", 3224, Html.IsSelected(controller: "UserManagement", cssClass: "in"), 3225, 62, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                    <li");
            BeginWriteAttribute("class", " class=\"", 3314, "\"", 3361, 1);
#nullable restore
#line 44 "C:\Users\Vernie Namca\Desktop\My Files\BusyBee\Projects\ERCOFAS\ERCOFAS.Web\ERCOFAS.Web\Views\Shared\_Navigation.cshtml"
WriteAttributeValue("", 3322, Html.IsSelected(action: "Dashboard_1"), 3322, 39, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><a");
            BeginWriteAttribute("href", " href=\"", 3365, "\"", 3412, 1);
#nullable restore
#line 44 "C:\Users\Vernie Namca\Desktop\My Files\BusyBee\Projects\ERCOFAS\ERCOFAS.Web\ERCOFAS.Web\Views\Shared\_Navigation.cshtml"
WriteAttributeValue("", 3372, Url.Action("Dashboard_1", "Dashboards"), 3372, 40, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Pages</a></li>\r\n                    <li");
            BeginWriteAttribute("class", " class=\"", 3453, "\"", 3500, 1);
#nullable restore
#line 45 "C:\Users\Vernie Namca\Desktop\My Files\BusyBee\Projects\ERCOFAS\ERCOFAS.Web\ERCOFAS.Web\Views\Shared\_Navigation.cshtml"
WriteAttributeValue("", 3461, Html.IsSelected(action: "Dashboard_2"), 3461, 39, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><a");
            BeginWriteAttribute("href", " href=\"", 3504, "\"", 3551, 1);
#nullable restore
#line 45 "C:\Users\Vernie Namca\Desktop\My Files\BusyBee\Projects\ERCOFAS\ERCOFAS.Web\ERCOFAS.Web\Views\Shared\_Navigation.cshtml"
WriteAttributeValue("", 3511, Url.Action("Dashboard_2", "Dashboards"), 3511, 40, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Roles</a></li>\r\n                    <li");
            BeginWriteAttribute("class", " class=\"", 3592, "\"", 3639, 1);
#nullable restore
#line 46 "C:\Users\Vernie Namca\Desktop\My Files\BusyBee\Projects\ERCOFAS\ERCOFAS.Web\ERCOFAS.Web\Views\Shared\_Navigation.cshtml"
WriteAttributeValue("", 3600, Html.IsSelected(action: "Dashboard_5"), 3600, 39, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><a");
            BeginWriteAttribute("href", " href=\"", 3643, "\"", 3690, 1);
#nullable restore
#line 46 "C:\Users\Vernie Namca\Desktop\My Files\BusyBee\Projects\ERCOFAS\ERCOFAS.Web\ERCOFAS.Web\Views\Shared\_Navigation.cshtml"
WriteAttributeValue("", 3650, Url.Action("Dashboard_5", "Dashboards"), 3650, 40, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Users</a></li>\r\n                    <li");
            BeginWriteAttribute("class", " class=\"", 3731, "\"", 3778, 1);
#nullable restore
#line 47 "C:\Users\Vernie Namca\Desktop\My Files\BusyBee\Projects\ERCOFAS\ERCOFAS.Web\ERCOFAS.Web\Views\Shared\_Navigation.cshtml"
WriteAttributeValue("", 3739, Html.IsSelected(action: "Dashboard_3"), 3739, 39, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><a");
            BeginWriteAttribute("href", " href=\"", 3782, "\"", 3829, 1);
#nullable restore
#line 47 "C:\Users\Vernie Namca\Desktop\My Files\BusyBee\Projects\ERCOFAS\ERCOFAS.Web\ERCOFAS.Web\Views\Shared\_Navigation.cshtml"
WriteAttributeValue("", 3789, Url.Action("Dashboard_3", "Dashboards"), 3789, 40, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">User Roles</a></li>\r\n                    <li");
            BeginWriteAttribute("class", " class=\"", 3875, "\"", 3924, 1);
#nullable restore
#line 48 "C:\Users\Vernie Namca\Desktop\My Files\BusyBee\Projects\ERCOFAS\ERCOFAS.Web\ERCOFAS.Web\Views\Shared\_Navigation.cshtml"
WriteAttributeValue("", 3883, Html.IsSelected(action: "Dashboard_4_1"), 3883, 41, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><a");
            BeginWriteAttribute("href", " href=\"", 3928, "\"", 3977, 1);
#nullable restore
#line 48 "C:\Users\Vernie Namca\Desktop\My Files\BusyBee\Projects\ERCOFAS\ERCOFAS.Web\ERCOFAS.Web\Views\Shared\_Navigation.cshtml"
WriteAttributeValue("", 3935, Url.Action("Dashboard_4_1", "Dashboards"), 3935, 42, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Page Access</a></li>\r\n                </ul>\r\n            </li>\r\n            <li");
            BeginWriteAttribute("class", " class=\"", 4058, "\"", 4106, 1);
#nullable restore
#line 51 "C:\Users\Vernie Namca\Desktop\My Files\BusyBee\Projects\ERCOFAS\ERCOFAS.Web\ERCOFAS.Web\Views\Shared\_Navigation.cshtml"
WriteAttributeValue("", 4066, Html.IsSelected(controller: "Settings"), 4066, 40, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 4128, "\"", 4167, 1);
#nullable restore
#line 52 "C:\Users\Vernie Namca\Desktop\My Files\BusyBee\Projects\ERCOFAS\ERCOFAS.Web\ERCOFAS.Web\Views\Shared\_Navigation.cshtml"
WriteAttributeValue("", 4135, Url.Action("Index", "Settings"), 4135, 32, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><i class=\"fa fa-cog\"></i> <span class=\"nav-label\" data-i18n=\"nav.widgets\">Settings</span> </a>\r\n            </li>\r\n        </ul>\r\n    </div>\r\n</nav>");
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