#pragma checksum "C:\Projects\Nurudeen\Flyway\Views\Booking\Display.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1d8c085129bef8135f65c9b0a17278963892012f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Booking_Display), @"mvc.1.0.view", @"/Views/Booking/Display.cshtml")]
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
#line 2 "C:\Projects\Nurudeen\Flyway\Views\_ViewImports.cshtml"
using FlywayAirlines.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Projects\Nurudeen\Flyway\Views\Booking\Display.cshtml"
using FlywayAirlines;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1d8c085129bef8135f65c9b0a17278963892012f", @"/Views/Booking/Display.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cd3da09681a92d676175a223911230588ccb5d32", @"/Views/_ViewImports.cshtml")]
    public class Views_Booking_Display : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Booking>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Booking", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<caption>List of Bookings</caption>



<hr />

<table class=""table  table-bordered table-striped table table-dark table-hover"">

    <thead>
        <tr>
            <th>Id</th>
            <th>Booking Number</th>
            <th>Booking Date</th>
            <th>Booking Type</th>
            <th>Seat Number</th>
            <th>Flight ID</th>
            <th>View</th>
            <th>Edit</th>
            <th>Delete</th>

        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 27 "C:\Projects\Nurudeen\Flyway\Views\Booking\Display.cshtml"
         foreach (Booking booking in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td> ");
#nullable restore
#line 30 "C:\Projects\Nurudeen\Flyway\Views\Booking\Display.cshtml"
                Write(booking.getId());

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                <td> ");
#nullable restore
#line 31 "C:\Projects\Nurudeen\Flyway\Views\Booking\Display.cshtml"
                Write(booking.getBookingNumber());

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                <td> ");
#nullable restore
#line 32 "C:\Projects\Nurudeen\Flyway\Views\Booking\Display.cshtml"
                Write(booking.getBookingDate().ToLongDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                <td> ");
#nullable restore
#line 33 "C:\Projects\Nurudeen\Flyway\Views\Booking\Display.cshtml"
                Write(booking.getBookingType());

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                <td> ");
#nullable restore
#line 34 "C:\Projects\Nurudeen\Flyway\Views\Booking\Display.cshtml"
                Write(booking.getSeatNumber());

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                <td> ");
#nullable restore
#line 35 "C:\Projects\Nurudeen\Flyway\Views\Booking\Display.cshtml"
                Write(booking.getFlightid());

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                <td> <a");
            BeginWriteAttribute("href", " href=\"", 965, "\"", 1005, 2);
            WriteAttributeValue("", 972, "/booking/Details/", 972, 17, true);
#nullable restore
#line 36 "C:\Projects\Nurudeen\Flyway\Views\Booking\Display.cshtml"
WriteAttributeValue("", 989, booking.getId(), 989, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Details</a> </td>\r\n                <td> <a");
            BeginWriteAttribute("href", " href=\"", 1049, "\"", 1086, 2);
            WriteAttributeValue("", 1056, "/booking/Edit/", 1056, 14, true);
#nullable restore
#line 37 "C:\Projects\Nurudeen\Flyway\Views\Booking\Display.cshtml"
WriteAttributeValue("", 1070, booking.getId(), 1070, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Edit</a> </td>\r\n                <td> <a");
            BeginWriteAttribute("href", " href=\"", 1127, "\"", 1166, 2);
            WriteAttributeValue("", 1134, "/booking/Delete/", 1134, 16, true);
#nullable restore
#line 38 "C:\Projects\Nurudeen\Flyway\Views\Booking\Display.cshtml"
WriteAttributeValue("", 1150, booking.getId(), 1150, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Delete</a> </td>\r\n            </tr>\r\n");
#nullable restore
#line 40 "C:\Projects\Nurudeen\Flyway\Views\Booking\Display.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n<p>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1d8c085129bef8135f65c9b0a17278963892012f7797", async() => {
                WriteLiteral("Add new Booking");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</p>\r\n<div class=\"progress\">\r\n    <div class=\"progress-bar progress-bar-striped progress-bar-animated\" role=\"progressbar\" aria-valuenow=\"75\" aria-valuemin=\"0\" aria-valuemax=\"100\" style=\"width: 25%\"></div>\r\n</div>\r\n\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Booking>> Html { get; private set; }
    }
}
#pragma warning restore 1591
