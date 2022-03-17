#pragma checksum "/Users/hyungseokcho/Projects/Mission12Final/Mission12Final/Views/Home/Appointments.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "99215eb0647d2f08cd62efd4dcdf6d18264db5b7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Appointments), @"mvc.1.0.view", @"/Views/Home/Appointments.cshtml")]
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
#line 1 "/Users/hyungseokcho/Projects/Mission12Final/Mission12Final/Views/_ViewImports.cshtml"
using Mission12Final;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/hyungseokcho/Projects/Mission12Final/Mission12Final/Views/_ViewImports.cshtml"
using Mission12Final.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"99215eb0647d2f08cd62efd4dcdf6d18264db5b7", @"/Views/Home/Appointments.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"531866e1be2c79378b3bf70872a44f1c6581fec7", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Appointments : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<AppointmentResponse>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-warning btn-sm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger btn-sm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 1 "/Users/hyungseokcho/Projects/Mission12Final/Mission12Final/Views/Home/Appointments.cshtml"
  
    ViewData["Title"] = "View Appointments";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
            WriteLiteral(@"
<h1>View Appointments</h1>

<table class=""table table-sm table-striped table-bordered"">
    <thead>
        <tr>
            <th>Date</th>
            <th>Name of Group</th>
            <th>Size of Group</th>
            <th>Email</th>
            <th>Phone</th>
            <th>Time</th>
        </tr>
    </thead>

    <tbody>

");
#nullable restore
#line 23 "/Users/hyungseokcho/Projects/Mission12Final/Mission12Final/Views/Home/Appointments.cshtml"
         if (Model?.Count() != 0)
        {
            // List the projects
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 26 "/Users/hyungseokcho/Projects/Mission12Final/Mission12Final/Views/Home/Appointments.cshtml"
             foreach (var b in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\n            <td>");
#nullable restore
#line 29 "/Users/hyungseokcho/Projects/Mission12Final/Mission12Final/Views/Home/Appointments.cshtml"
           Write(b.Date);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n            <td>");
#nullable restore
#line 30 "/Users/hyungseokcho/Projects/Mission12Final/Mission12Final/Views/Home/Appointments.cshtml"
           Write(b.GroupName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n            <td>");
#nullable restore
#line 31 "/Users/hyungseokcho/Projects/Mission12Final/Mission12Final/Views/Home/Appointments.cshtml"
           Write(b.GroupSize);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n            <td>");
#nullable restore
#line 32 "/Users/hyungseokcho/Projects/Mission12Final/Mission12Final/Views/Home/Appointments.cshtml"
           Write(b.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n            <td>");
#nullable restore
#line 33 "/Users/hyungseokcho/Projects/Mission12Final/Mission12Final/Views/Home/Appointments.cshtml"
           Write(b.Phone);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n");
#nullable restore
#line 34 "/Users/hyungseokcho/Projects/Mission12Final/Mission12Final/Views/Home/Appointments.cshtml"
             if (Int32.Parse(b.Time) < 13)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <td>");
#nullable restore
#line 36 "/Users/hyungseokcho/Projects/Mission12Final/Mission12Final/Views/Home/Appointments.cshtml"
               Write(b.Time);

#line default
#line hidden
#nullable disable
            WriteLiteral(" A.M.</td>\n");
#nullable restore
#line 37 "/Users/hyungseokcho/Projects/Mission12Final/Mission12Final/Views/Home/Appointments.cshtml"
            }
            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <td>");
#nullable restore
#line 40 "/Users/hyungseokcho/Projects/Mission12Final/Mission12Final/Views/Home/Appointments.cshtml"
                Write((Int32.Parse(b.Time)- 12).ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral(" P.M.</td>\n");
#nullable restore
#line 41 "/Users/hyungseokcho/Projects/Mission12Final/Mission12Final/Views/Home/Appointments.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            <td>\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "99215eb0647d2f08cd62efd4dcdf6d18264db5b78305", async() => {
                WriteLiteral("Edit");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-appId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 44 "/Users/hyungseokcho/Projects/Mission12Final/Mission12Final/Views/Home/Appointments.cshtml"
                                                                                               WriteLiteral(b.AppointmentId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["appId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-appId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["appId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n            </td>\n\n            <td>\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "99215eb0647d2f08cd62efd4dcdf6d18264db5b710846", async() => {
                WriteLiteral("Delete");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-appId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 48 "/Users/hyungseokcho/Projects/Mission12Final/Mission12Final/Views/Home/Appointments.cshtml"
                                                                                                WriteLiteral(b.AppointmentId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["appId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-appId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["appId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n            </td>\n        </tr>\n");
#nullable restore
#line 51 "/Users/hyungseokcho/Projects/Mission12Final/Mission12Final/Views/Home/Appointments.cshtml"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 51 "/Users/hyungseokcho/Projects/Mission12Final/Mission12Final/Views/Home/Appointments.cshtml"
             
        }
        else
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\n                <td colspan=\"5\" class=\"text-center\">No Book</td>\n            </tr>\n");
#nullable restore
#line 58 "/Users/hyungseokcho/Projects/Mission12Final/Mission12Final/Views/Home/Appointments.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </tbody>\n\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<AppointmentResponse>> Html { get; private set; }
    }
}
#pragma warning restore 1591
