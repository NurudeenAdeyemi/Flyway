#pragma checksum "C:\Users\nurudeen\source\repos\FlywayAirlines\Views\Booking\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "09950d3f329395c3117c6060c5966d9416592b40"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Booking_Edit), @"mvc.1.0.view", @"/Views/Booking/Edit.cshtml")]
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
#line 1 "C:\Users\nurudeen\source\repos\FlywayAirlines\Views\Booking\Edit.cshtml"
using FlywayAirlines;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"09950d3f329395c3117c6060c5966d9416592b40", @"/Views/Booking/Edit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cd3da09681a92d676175a223911230588ccb5d32", @"/Views/_ViewImports.cshtml")]
    public class Views_Booking_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Booking>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Booking", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n<caption>Update Booking</caption>\r\n<hr />\r\n<div class=\"row\">\r\n    <div class=\"col-md-5\">\r\n\r\n\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "09950d3f329395c3117c6060c5966d9416592b404651", async() => {
                WriteLiteral("\r\n            <input type=\"hidden\" name=\"id\"");
                BeginWriteAttribute("value", " value=\"", 207, "\"", 229, 1);
#nullable restore
#line 11 "C:\Users\nurudeen\source\repos\FlywayAirlines\Views\Booking\Edit.cshtml"
WriteAttributeValue("", 215, Model.getId(), 215, 14, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n\r\n            <div class=\"form-row\">\r\n                <div class=\"form-group col-md-6\">\r\n                    <label class=\"control-label\">Booking Number</label>\r\n                    <input class=\"form-control\" name=\"bookingNumber\"");
                BeginWriteAttribute("value", " value=\"", 465, "\"", 498, 1);
#nullable restore
#line 16 "C:\Users\nurudeen\source\repos\FlywayAirlines\Views\Booking\Edit.cshtml"
WriteAttributeValue("", 473, Model.getBookingNumber(), 473, 25, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" type=\"text\" />\r\n                </div>\r\n\r\n                <div class=\"form-group col-md-6\">\r\n                    <label class=\"control-label\">Booking Date</label>\r\n                    <input class=\"form-control\" name=\"bookingDate\"");
                BeginWriteAttribute("value", " value=\"", 730, "\"", 761, 1);
#nullable restore
#line 21 "C:\Users\nurudeen\source\repos\FlywayAirlines\Views\Booking\Edit.cshtml"
WriteAttributeValue("", 738, Model.getBookingDate(), 738, 23, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" type=""date"" />
                </div>
            </div>

            <div class=""form-row"">
                <div class=""form-group col-md-6"">
                    <label class=""control-label"">Booking Type</label>
                    <input class=""form-control"" name=""bookingType""");
                BeginWriteAttribute("value", " value=\"", 1049, "\"", 1080, 1);
#nullable restore
#line 28 "C:\Users\nurudeen\source\repos\FlywayAirlines\Views\Booking\Edit.cshtml"
WriteAttributeValue("", 1057, Model.getBookingType(), 1057, 23, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" type=\"text\" />\r\n                </div>\r\n\r\n                <div class=\"form-group col-md-6\">\r\n                    <label class=\"control-label\">Seat Number</label>\r\n                    <input class=\"form-control\" name=\"seatNumber\"");
                BeginWriteAttribute("value", " value=\"", 1310, "\"", 1340, 1);
#nullable restore
#line 33 "C:\Users\nurudeen\source\repos\FlywayAirlines\Views\Booking\Edit.cshtml"
WriteAttributeValue("", 1318, Model.getSeatNumber(), 1318, 22, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" type=""number"" />
                </div>
            </div>

            <div class=""form-row"">
                <div class=""form-group col-md-6"">
                    <label class=""control-label"">Flight Id</label>
                    <input class=""form-control"" name=""flightid""");
                BeginWriteAttribute("value", " value=\"", 1624, "\"", 1652, 1);
#nullable restore
#line 40 "C:\Users\nurudeen\source\repos\FlywayAirlines\Views\Booking\Edit.cshtml"
WriteAttributeValue("", 1632, Model.getFlightid(), 1632, 20, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" type=\"number\" />\r\n                </div>\r\n                <div class=\"form-group col-md-6\">\r\n                    <label class=\"control-label\">Passenger Id</label>\r\n                    <input class=\"form-control\" name=\"passengerid\"");
                BeginWriteAttribute("value", " value=\"", 1884, "\"", 1915, 1);
#nullable restore
#line 44 "C:\Users\nurudeen\source\repos\FlywayAirlines\Views\Booking\Edit.cshtml"
WriteAttributeValue("", 1892, Model.getPassengerid(), 1892, 23, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" type=\"number\" />\r\n                </div>\r\n            </div>\r\n\r\n            <div class=\"form-group\">\r\n                <button type=\"submit\" class=\"btn btn-primary\">Update</button>\r\n            </div>\r\n        ");
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "09950d3f329395c3117c6060c5966d9416592b4010624", async() => {
                WriteLiteral("Back to Booking List");
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
            WriteLiteral("</p>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Booking> Html { get; private set; }
    }
}
#pragma warning restore 1591
