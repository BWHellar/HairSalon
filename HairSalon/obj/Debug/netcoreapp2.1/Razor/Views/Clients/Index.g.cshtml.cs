#pragma checksum "/Users/bwhellar/Desktop/HairSalon.Solution/HairSalon/Views/Clients/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "846ad571d39f7d8a903cceca8d6573a3d5ab496b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Clients_Index), @"mvc.1.0.view", @"/Views/Clients/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Clients/Index.cshtml", typeof(AspNetCore.Views_Clients_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"846ad571d39f7d8a903cceca8d6573a3d5ab496b", @"/Views/Clients/Index.cshtml")]
    public class Views_Clients_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 26, true);
            WriteLiteral("<h1>To Do List</h1>\n<ul>\n\n");
            EndContext();
#line 4 "/Users/bwhellar/Desktop/HairSalon.Solution/HairSalon/Views/Clients/Index.cshtml"
 if (Model.Count == 0)
{

#line default
#line hidden
            BeginContext(51, 30, true);
            WriteLiteral("  <p>You have no clients!</p>\n");
            EndContext();
#line 7 "/Users/bwhellar/Desktop/HairSalon.Solution/HairSalon/Views/Clients/Index.cshtml"
}

#line default
#line hidden
            BeginContext(83, 172, true);
            WriteLiteral("\n\n</ul>\n<a href=\"/clients/new\">Add a new client.</a>\n<form action=\"/clients/delete\" method=\"post\">\n  <button type=\"submit\" name=\"button\">Clear All clients</button>\n</form>\n");
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
