#pragma checksum "/Users/bwhellar/Desktop/HairSalon.Solution/HairSalon/Views/Stylist/Show.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "62466ee6d683f749f8a4a7b73dc51d153f19651e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Stylist_Show), @"mvc.1.0.view", @"/Views/Stylist/Show.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Stylist/Show.cshtml", typeof(AspNetCore.Views_Stylist_Show))]
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
#line 2 "/Users/bwhellar/Desktop/HairSalon.Solution/HairSalon/Views/Stylist/Show.cshtml"
using HairSalon.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"62466ee6d683f749f8a4a7b73dc51d153f19651e", @"/Views/Stylist/Show.cshtml")]
    public class Views_Stylist_Show : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(26, 6, true);
            WriteLiteral("\n\n<h3>");
            EndContext();
            BeginContext(33, 10, false);
#line 5 "/Users/bwhellar/Desktop/HairSalon.Solution/HairSalon/Views/Stylist/Show.cshtml"
Write(Model.Name);

#line default
#line hidden
            EndContext();
            BeginContext(43, 20, true);
            WriteLiteral("</h3>\n\n<div>\n  <form");
            EndContext();
            BeginWriteAttribute("action", " action=\"", 63, "\"", 81, 1);
#line 8 "/Users/bwhellar/Desktop/HairSalon.Solution/HairSalon/Views/Stylist/Show.cshtml"
WriteAttributeValue("", 72, Model.Id, 72, 9, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(82, 182, true);
            WriteLiteral(" method=\"post\">\n  <label for=\"clientName\">Add Client</label>\n  <input type=\"text\" name=\"clientName\"/>\n  <button type=\"submit\">Add</button>\n  </form>\n</div>\n\n\n<h2>Current Clients<h2>\n");
            EndContext();
#line 17 "/Users/bwhellar/Desktop/HairSalon.Solution/HairSalon/Views/Stylist/Show.cshtml"
 foreach (Client client in @Model.GetClients())
{


#line default
#line hidden
            BeginContext(315, 6, true);
            WriteLiteral("  <h3>");
            EndContext();
            BeginContext(322, 11, false);
#line 20 "/Users/bwhellar/Desktop/HairSalon.Solution/HairSalon/Views/Stylist/Show.cshtml"
 Write(client.Name);

#line default
#line hidden
            EndContext();
            BeginContext(333, 6, true);
            WriteLiteral("</h3>\n");
            EndContext();
#line 21 "/Users/bwhellar/Desktop/HairSalon.Solution/HairSalon/Views/Stylist/Show.cshtml"

}

#line default
#line hidden
            BeginContext(342, 78, true);
            WriteLiteral("\n<form action=\"/\" method=\"get\">\n  <button type=\"submit\">Home</button>\n</form>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
