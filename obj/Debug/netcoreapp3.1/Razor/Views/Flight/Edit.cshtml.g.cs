#pragma checksum "C:\Users\nurudeen\source\repos\FlywayAirlines\Views\Flight\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "be648253fe0ffebf832415f2d9b78fc8dfa9caa3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Flight_Edit), @"mvc.1.0.view", @"/Views/Flight/Edit.cshtml")]
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
#line 2 "C:\Users\nurudeen\source\repos\FlywayAirlines\Views\_ViewImports.cshtml"
using FlywayAirlines.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\nurudeen\source\repos\FlywayAirlines\Views\Flight\Edit.cshtml"
using FlywayAirlines;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"be648253fe0ffebf832415f2d9b78fc8dfa9caa3", @"/Views/Flight/Edit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cd3da09681a92d676175a223911230588ccb5d32", @"/Views/_ViewImports.cshtml")]
    public class Views_Flight_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Flight>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Flight", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Display", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<caption>Update Flight</caption>\r\n<hr />\r\n\r\n<div class=\"row\">\r\n    <div class=\"col-md-5\">\r\n\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "be648253fe0ffebf832415f2d9b78fc8dfa9caa34642", async() => {
                WriteLiteral("\r\n            <input type=\"hidden\" name=\"id\"");
                BeginWriteAttribute("value", " value=\"", 205, "\"", 227, 1);
#nullable restore
#line 11 "C:\Users\nurudeen\source\repos\FlywayAirlines\Views\Flight\Edit.cshtml"
WriteAttributeValue("", 213, Model.getId(), 213, 14, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n\r\n            <div class=\"form-group\">\r\n                <label class=\"control-label\">Flight Number</label>\r\n                <input class=\"form-control\" name=\"flightNumber\"");
                BeginWriteAttribute("value", " value=\"", 404, "\"", 436, 1);
#nullable restore
#line 15 "C:\Users\nurudeen\source\repos\FlywayAirlines\Views\Flight\Edit.cshtml"
WriteAttributeValue("", 412, Model.getFlightNumber(), 412, 24, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" type=\"number\" />\r\n            </div>\r\n\r\n            <div class=\"form-group\">\r\n                <label class=\"control-label\">Aicraft ID</label>\r\n                <input class=\"form-control\" name=\"aircraftid\"");
                BeginWriteAttribute("value", " value=\"", 642, "\"", 672, 1);
#nullable restore
#line 20 "C:\Users\nurudeen\source\repos\FlywayAirlines\Views\Flight\Edit.cshtml"
WriteAttributeValue("", 650, Model.getAircraftid(), 650, 22, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" type=\"number\" />\r\n            </div>\r\n\r\n            <div class=\"form-group\">\r\n                <label class=\"control-label\">From</label>\r\n                <input class=\"form-control\" name=\"takeOfPoint\"");
                BeginWriteAttribute("value", " value=\"", 873, "\"", 904, 1);
#nullable restore
#line 25 "C:\Users\nurudeen\source\repos\FlywayAirlines\Views\Flight\Edit.cshtml"
WriteAttributeValue("", 881, Model.getTakeOfPoint(), 881, 23, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" type=\"text\" />\r\n            </div>\r\n\r\n\r\n\r\n            <div class=\"form-group\">\r\n                <label class=\"control-label\">Destination</label>\r\n                <input class=\"form-control\" name=\"destination\"");
                BeginWriteAttribute("value", " value=\"", 1114, "\"", 1145, 1);
#nullable restore
#line 32 "C:\Users\nurudeen\source\repos\FlywayAirlines\Views\Flight\Edit.cshtml"
WriteAttributeValue("", 1122, Model.getDestination(), 1122, 23, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" type=\"text\" />\r\n            </div>\r\n\r\n\r\n            <div class=\"form-group\">\r\n                <label class=\"control-label\">Flight Time</label>\r\n                <input class=\"form-control\" name=\"takeOfTime\"");
                BeginWriteAttribute("value", " value=\"", 1352, "\"", 1382, 1);
#nullable restore
#line 38 "C:\Users\nurudeen\source\repos\FlywayAirlines\Views\Flight\Edit.cshtml"
WriteAttributeValue("", 1360, Model.getTakeOfTime(), 1360, 22, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" type=\"datetime-local\" />\r\n            </div>\r\n\r\n            <div class=\"form-group\">\r\n                <label class=\"control-label\">Landing Time</label>\r\n                <input class=\"form-control\" name=\"landingTime\"");
                BeginWriteAttribute("value", " value=\"", 1599, "\"", 1630, 1);
#nullable restore
#line 43 "C:\Users\nurudeen\source\repos\FlywayAirlines\Views\Flight\Edit.cshtml"
WriteAttributeValue("", 1607, Model.getLandingTime(), 1607, 23, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" type=\"datetime-local\" />\r\n            </div>\r\n\r\n            <div class=\"form-group\">\r\n                <label class=\"control-label\">Flight Price</label>\r\n                <input class=\"form-control\" name=\"flightPrice\"");
                BeginWriteAttribute("value", " value=\"", 1847, "\"", 1878, 1);
#nullable restore
#line 48 "C:\Users\nurudeen\source\repos\FlywayAirlines\Views\Flight\Edit.cshtml"
WriteAttributeValue("", 1855, Model.getFlightPrice(), 1855, 23, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" type=\"number\" />\r\n            </div>\r\n\r\n            <div class=\"form-group\">\r\n                <button type=\"submit\" class=\"btn btn-primary\">Update</button>\r\n\r\n            </div>\r\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n</div>\r\n<p>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "be648253fe0ffebf832415f2d9b78fc8dfa9caa310932", async() => {
                WriteLiteral("Back to Flight List");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</p>\r\n\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 62 "C:\Users\nurudeen\source\repos\FlywayAirlines\Views\Flight\Edit.cshtml"
      await Html.RenderPartialAsync("_ValidationScriptsPartial");

#line default
#line hidden
#nullable disable
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Flight> Html { get; private set; }
    }
}
#pragma warning restore 1591
