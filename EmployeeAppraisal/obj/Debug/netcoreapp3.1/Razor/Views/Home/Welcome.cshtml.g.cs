#pragma checksum "C:\Users\yasir.yaqoob\source\repos\EmployeeAppraisal\EmployeeAppraisal\Views\Home\Welcome.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8943e84cc1ffe5977e3a609c01abc3ccc6627d60"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Welcome), @"mvc.1.0.view", @"/Views/Home/Welcome.cshtml")]
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
#line 1 "C:\Users\yasir.yaqoob\source\repos\EmployeeAppraisal\EmployeeAppraisal\Views\_ViewImports.cshtml"
using EmployeeAppraisal;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\yasir.yaqoob\source\repos\EmployeeAppraisal\EmployeeAppraisal\Views\_ViewImports.cshtml"
using EmployeeAppraisal.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8943e84cc1ffe5977e3a609c01abc3ccc6627d60", @"/Views/Home/Welcome.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"85831ef6f9fe232705c4dc3fdc5e44b70dafb35e", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Welcome : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Employee>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/twitter-bootstrap/incadeaimg.png "), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("rounded-circle"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("110"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", new global::Microsoft.AspNetCore.Html.HtmlString("90"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("nav-link font-weight-bold text"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddEmployee", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AppraiselForm", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CreateAppraisal", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("dropdown-item"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Logout", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DeleteEmp", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_11 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger btn-sm rounded-0"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_12 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("title", new global::Microsoft.AspNetCore.Html.HtmlString("Delete"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_13 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_14 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "appdetails", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!--<nav class=\"justify-content-lg-start bg-light\">-->\r\n");
            WriteLiteral(@"
<!--<div class=""collapse navbar-collapse"" id=""navbarNav"" >
        <ul class=""navbar-nav"">
            <li class=""nav-item dropdown"">
                <a class=""nav-link dropdown-toggle"" href=""#"" id=""userDropdown"" role=""button"" data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false"">
                    <img src=""https://via.placeholder.com/30x30"" alt=""User Logo""> John Doe
                </a>
                <div class=""dropdown-menu dropdown-menu-right"" aria-labelledby=""userDropdown"">
                    <a class=""dropdown-item"" href=""#"">Profile</a>
                    <a class=""dropdown-item"" href=""#"">Settings</a>
                    <div class=""dropdown-divider""></div>
                    <a class=""dropdown-item"" href=""#"">Logout</a>
                </div>
            </li>
        </ul>
    </div>
</div>

</nav>-->

");
            WriteLiteral("<a href=\"C:\\Users\\yasir.yaqoob\\source\\repos\\EmployeeAppraisal\\EmployeeAppraisal\\appsettings.json\"></a>\r\n<nav class=\"navbar navbar-expand-md navbar-dark bg-secondary\">\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "8943e84cc1ffe5977e3a609c01abc3ccc6627d609519", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    <div class=\"collapse navbar-collapse \" id=\"navbarNav\">\r\n        <ul class=\"navbar-nav mr-auto \">\r\n\r\n");
#nullable restore
#line 31 "C:\Users\yasir.yaqoob\source\repos\EmployeeAppraisal\EmployeeAppraisal\Views\Home\Welcome.cshtml"
             if (User.Claims.ToList()[2].Value == "HR")
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <li class=\"nav-item active \">\r\n\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8943e84cc1ffe5977e3a609c01abc3ccc6627d6011270", async() => {
                WriteLiteral("Add Employee ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </li>\r\n");
            WriteLiteral("                <li class=\"nav-item active \">\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8943e84cc1ffe5977e3a609c01abc3ccc6627d6012643", async() => {
                WriteLiteral("AppraisalDetails");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </li>\r\n");
#nullable restore
#line 41 "C:\Users\yasir.yaqoob\source\repos\EmployeeAppraisal\EmployeeAppraisal\Views\Home\Welcome.cshtml"

            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 44 "C:\Users\yasir.yaqoob\source\repos\EmployeeAppraisal\EmployeeAppraisal\Views\Home\Welcome.cshtml"
             if (User.Claims.ToList()[2].Value == "Manager")
            {

                

#line default
#line hidden
#nullable disable
            WriteLiteral("                <li class=\"nav-item active \">\r\n\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8943e84cc1ffe5977e3a609c01abc3ccc6627d6014528", async() => {
                WriteLiteral("Add Appraisal ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </li>\r\n");
#nullable restore
#line 52 "C:\Users\yasir.yaqoob\source\repos\EmployeeAppraisal\EmployeeAppraisal\Views\Home\Welcome.cshtml"

            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 55 "C:\Users\yasir.yaqoob\source\repos\EmployeeAppraisal\EmployeeAppraisal\Views\Home\Welcome.cshtml"
             if (User.Claims.ToList()[2].Value != "HR" && User.Claims.ToList()[2].Value != "Manager")
            {


            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"



        </ul>
        <ul class=""navbar-nav bg-black"">
            <li class=""nav-item dropdown"">
                <a class=""nav-link dropdown-toggle font-weight-bold"" href=""#"" id=""userDropdown"" role=""button"" data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false"" icon=""person"">
                    <svg xmlns=""http://www.w3.org/2000/svg"" width=""40"" height=""50"" fill=""currentColor"" class=""bi bi-person-circle"" viewBox=""0 0 16 16"">
                        <path d=""M11 6a3 3 0 1 1-6 0 3 3 0 0 1 6 0z"" />
                        <path fill-rule=""evenodd"" d=""M0 8a8 8 0 1 1 16 0A8 8 0 0 1 0 8zm8-7a7 7 0 0 0-5.468 11.37C3.242 11.226 4.805 10 8 10s4.757 1.225 5.468 2.37A7 7 0 0 0 8 1z"" />
                    </svg> ");
#nullable restore
#line 71 "C:\Users\yasir.yaqoob\source\repos\EmployeeAppraisal\EmployeeAppraisal\Views\Home\Welcome.cshtml"
                      Write(User.Identity.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </a>\r\n                <div class=\"dropdown-menu dropdown-menu-right bg-black\" aria-labelledby=\"userDropdown\">\r\n");
            WriteLiteral("                    <div class=\"dropdown-divider\"></div>\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8943e84cc1ffe5977e3a609c01abc3ccc6627d6017664", async() => {
                WriteLiteral("Logout");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_9.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </div>\r\n            </li>\r\n        </ul>\r\n    </div>\r\n</nav>\r\n\r\n\r\n");
#nullable restore
#line 85 "C:\Users\yasir.yaqoob\source\repos\EmployeeAppraisal\EmployeeAppraisal\Views\Home\Welcome.cshtml"
  
    if (ViewBag.data != null)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        <table class=""table"">
            <thead class=""thead-dark"">
                <tr>
                    <th scope=""col"">Name</th>
                    <th scope=""col"">Designation</th>
                    <th scope=""col"">Manager ID</th>
                    <th scope=""col"">Email</th>
                    <th scope=""col"">Action</th>
                </tr>
            </thead>
            <tbody>



");
#nullable restore
#line 102 "C:\Users\yasir.yaqoob\source\repos\EmployeeAppraisal\EmployeeAppraisal\Views\Home\Welcome.cshtml"
                 foreach (var item in ViewBag.data)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <th scope=\"row\">");
#nullable restore
#line 105 "C:\Users\yasir.yaqoob\source\repos\EmployeeAppraisal\EmployeeAppraisal\Views\Home\Welcome.cshtml"
                                   Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                        <td>");
#nullable restore
#line 106 "C:\Users\yasir.yaqoob\source\repos\EmployeeAppraisal\EmployeeAppraisal\Views\Home\Welcome.cshtml"
                       Write(item.Designation);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 107 "C:\Users\yasir.yaqoob\source\repos\EmployeeAppraisal\EmployeeAppraisal\Views\Home\Welcome.cshtml"
                       Write(item.MID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 108 "C:\Users\yasir.yaqoob\source\repos\EmployeeAppraisal\EmployeeAppraisal\Views\Home\Welcome.cshtml"
                       Write(item.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</td>
                        <td>
                            <!-- Call to action buttons -->
                            <ul class=""list-inline m-0"">
                                <li class=""list-inline-item"">
                                    <button class=""btn btn-primary btn-sm rounded-0"" type=""button"" data-toggle=""tooltip"" data-placement=""top"" title=""edit""><i class=""fa fa-table""></i>Edit</button>
                                </li>
                                <li class=""list-inline-item"">
                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8943e84cc1ffe5977e3a609c01abc3ccc6627d6021744", async() => {
                WriteLiteral("Delete");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_10.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_10);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_11);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_12);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_13.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_13);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 116 "C:\Users\yasir.yaqoob\source\repos\EmployeeAppraisal\EmployeeAppraisal\Views\Home\Welcome.cshtml"
                                                                                                                                             WriteLiteral(item.EID);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                </li>\r\n                            </ul>\r\n                        </td>\r\n                    </tr>\r\n");
#nullable restore
#line 121 "C:\Users\yasir.yaqoob\source\repos\EmployeeAppraisal\EmployeeAppraisal\Views\Home\Welcome.cshtml"

                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\r\n        </table>\r\n");
#nullable restore
#line 125 "C:\Users\yasir.yaqoob\source\repos\EmployeeAppraisal\EmployeeAppraisal\Views\Home\Welcome.cshtml"
    }
    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <h1 class=\"bg-info justify-content-xxl-center\">Employee List Is Empty</h1>\r\n");
#nullable restore
#line 129 "C:\Users\yasir.yaqoob\source\repos\EmployeeAppraisal\EmployeeAppraisal\Views\Home\Welcome.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"


<div class=""row"">
    <div class=""col-sm-4"" style=""height:100%;"">
        <div class=""card"" style=""width: 30rem; height:max-content; background-color:moccasin"">
            <div class=""form-group"">
                <h5 class=""card-title"">New Appraisal</h5>
");
#nullable restore
#line 139 "C:\Users\yasir.yaqoob\source\repos\EmployeeAppraisal\EmployeeAppraisal\Views\Home\Welcome.cshtml"
                 if (User.Claims.ToList()[2].Value == "Manager")
                {



                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 144 "C:\Users\yasir.yaqoob\source\repos\EmployeeAppraisal\EmployeeAppraisal\Views\Home\Welcome.cshtml"
                     if (ViewBag.app != null)
                    {
                        foreach (var item in ViewBag.app)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <p> You created One Appraisal for <b>Employee Id ");
#nullable restore
#line 148 "C:\Users\yasir.yaqoob\source\repos\EmployeeAppraisal\EmployeeAppraisal\Views\Home\Welcome.cshtml"
                                                                        Write(item.EmployeeID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b> <a> know more</a> </p>\r\n");
#nullable restore
#line 149 "C:\Users\yasir.yaqoob\source\repos\EmployeeAppraisal\EmployeeAppraisal\Views\Home\Welcome.cshtml"
                        }
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <p>No appraisal exists..</p>\r\n");
#nullable restore
#line 154 "C:\Users\yasir.yaqoob\source\repos\EmployeeAppraisal\EmployeeAppraisal\Views\Home\Welcome.cshtml"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 154 "C:\Users\yasir.yaqoob\source\repos\EmployeeAppraisal\EmployeeAppraisal\Views\Home\Welcome.cshtml"
                     

                }



                

#line default
#line hidden
#nullable disable
#nullable restore
#line 161 "C:\Users\yasir.yaqoob\source\repos\EmployeeAppraisal\EmployeeAppraisal\Views\Home\Welcome.cshtml"
                 if (User.Claims.ToList()[2].Value != "HR" && User.Claims.ToList()[2].Value != "Manager")
                {
                    if (ViewBag.emp != null)
                    {

                        foreach (var item in ViewBag.emp)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <p> You Manager has created One Appraisal for <b>Employee Id ");
#nullable restore
#line 168 "C:\Users\yasir.yaqoob\source\repos\EmployeeAppraisal\EmployeeAppraisal\Views\Home\Welcome.cshtml"
                                                                                    Write(item.EmployeeID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b> ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8943e84cc1ffe5977e3a609c01abc3ccc6627d6028422", async() => {
                WriteLiteral(" know more");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_14.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_14);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_13.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_13);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 168 "C:\Users\yasir.yaqoob\source\repos\EmployeeAppraisal\EmployeeAppraisal\Views\Home\Welcome.cshtml"
                                                                                                                                                                 WriteLiteral(item.AppraisalID);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" </p>\r\n");
#nullable restore
#line 169 "C:\Users\yasir.yaqoob\source\repos\EmployeeAppraisal\EmployeeAppraisal\Views\Home\Welcome.cshtml"
                        }

                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <p>Np Appraisal Form Here</p>\r\n");
#nullable restore
#line 175 "C:\Users\yasir.yaqoob\source\repos\EmployeeAppraisal\EmployeeAppraisal\Views\Home\Welcome.cshtml"
                    }

                }

                

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            </div>
        </div>
    </div>

    <div class=""col-sm-4"">
        <div class=""card"" style=""width: 30rem; height:max-content; background-color:teal;"">
            <div class=""form-group"">
                <h5 class=""card-title"">Created Appraisal</h5>
                <p class=""card-text""><a href=""#"">Clcik Here</a></p>
");
            WriteLiteral(@"            </div>
        </div>
    </div>

    <div class=""col-sm-4"">
        <div class=""card"" style=""width: 30rem; height:max-content; background-color:dimgray;"">
            <div class=""form-group"">
                <h5 class=""card-title"">Pending Appraisal</h5>

");
#nullable restore
#line 199 "C:\Users\yasir.yaqoob\source\repos\EmployeeAppraisal\EmployeeAppraisal\Views\Home\Welcome.cshtml"
                 if (User.Claims.ToList()[2].Value == "Manager")
                {



                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 204 "C:\Users\yasir.yaqoob\source\repos\EmployeeAppraisal\EmployeeAppraisal\Views\Home\Welcome.cshtml"
                     if (ViewBag.pen != null)
                    {
                        foreach (var item in ViewBag.pen)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <p>  <b>Employee Id ");
#nullable restore
#line 208 "C:\Users\yasir.yaqoob\source\repos\EmployeeAppraisal\EmployeeAppraisal\Views\Home\Welcome.cshtml"
                                           Write(item.EmployeeID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b> has submitted one appraisal form <a> know more</a> </p>\r\n");
#nullable restore
#line 209 "C:\Users\yasir.yaqoob\source\repos\EmployeeAppraisal\EmployeeAppraisal\Views\Home\Welcome.cshtml"
                        }
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <p>No appraisal exists..</p>\r\n");
#nullable restore
#line 214 "C:\Users\yasir.yaqoob\source\repos\EmployeeAppraisal\EmployeeAppraisal\Views\Home\Welcome.cshtml"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 214 "C:\Users\yasir.yaqoob\source\repos\EmployeeAppraisal\EmployeeAppraisal\Views\Home\Welcome.cshtml"
                     

                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 218 "C:\Users\yasir.yaqoob\source\repos\EmployeeAppraisal\EmployeeAppraisal\Views\Home\Welcome.cshtml"
                 if (User.Claims.ToList()[2].Value != "HR" && User.Claims.ToList()[2].Value != "Manager")
                {
                    if (ViewBag.cr != null)
                    {

                        foreach (var item in ViewBag.cr)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <p> You have and pending Appraisal for <b>Employee Id ");
#nullable restore
#line 225 "C:\Users\yasir.yaqoob\source\repos\EmployeeAppraisal\EmployeeAppraisal\Views\Home\Welcome.cshtml"
                                                                             Write(item.EmployeeID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b> ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8943e84cc1ffe5977e3a609c01abc3ccc6627d6035020", async() => {
                WriteLiteral(" know more");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_14.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_14);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_13.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_13);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 225 "C:\Users\yasir.yaqoob\source\repos\EmployeeAppraisal\EmployeeAppraisal\Views\Home\Welcome.cshtml"
                                                                                                                                                          WriteLiteral(item.AppraisalID);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" </p>\r\n");
#nullable restore
#line 226 "C:\Users\yasir.yaqoob\source\repos\EmployeeAppraisal\EmployeeAppraisal\Views\Home\Welcome.cshtml"
                        }

                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <p>No pending Appraisal Form Here</p>\r\n");
#nullable restore
#line 232 "C:\Users\yasir.yaqoob\source\repos\EmployeeAppraisal\EmployeeAppraisal\Views\Home\Welcome.cshtml"
                    }

                }
                

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n        </div>\r\n    </div>\r\n\r\n</div>\r\n   \r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Employee>> Html { get; private set; }
    }
}
#pragma warning restore 1591
