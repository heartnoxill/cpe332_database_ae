#pragma checksum "C:\Users\computer\Desktop\CPE332\webapp_1\MyWebMVC\Views\Showdata\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "25b86eba7502f1471ecbc4beb475bc16261a51ae"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Showdata_Index), @"mvc.1.0.view", @"/Views/Showdata/Index.cshtml")]
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
#line 1 "C:\Users\computer\Desktop\CPE332\webapp_1\MyWebMVC\Views\_ViewImports.cshtml"
using MyWebMVC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\computer\Desktop\CPE332\webapp_1\MyWebMVC\Views\_ViewImports.cshtml"
using MyWebMVC.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"25b86eba7502f1471ecbc4beb475bc16261a51ae", @"/Views/Showdata/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ae7f5a7cd5c5cfe8fd5dd72291f0db68b672918b", @"/Views/_ViewImports.cshtml")]
    public class Views_Showdata_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<h2>Show Data</h2>\r\n<table>\r\n    <tr>\r\n        <th>ID</th>\r\n        <th>Title</th>\r\n        <th>Amount</th>\r\n    </tr>\r\n\r\n");
#nullable restore
#line 14 "C:\Users\computer\Desktop\CPE332\webapp_1\MyWebMVC\Views\Showdata\Index.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 17 "C:\Users\computer\Desktop\CPE332\webapp_1\MyWebMVC\Views\Showdata\Index.cshtml"
           Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 18 "C:\Users\computer\Desktop\CPE332\webapp_1\MyWebMVC\Views\Showdata\Index.cshtml"
           Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 19 "C:\Users\computer\Desktop\CPE332\webapp_1\MyWebMVC\Views\Showdata\Index.cshtml"
           Write(item.Amount);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n");
#nullable restore
#line 21 "C:\Users\computer\Desktop\CPE332\webapp_1\MyWebMVC\Views\Showdata\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\r\n");
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
