#pragma checksum "F:\WebApplication2\WebApplication2\Views\Home\Components\Software\_ListView.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9e3d8a4c8cfceabf0af5579a68ad748798e8d2fd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Components_Software__ListView), @"mvc.1.0.view", @"/Views/Home/Components/Software/_ListView.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Components/Software/_ListView.cshtml", typeof(AspNetCore.Views_Home_Components_Software__ListView))]
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
#line 1 "F:\WebApplication2\WebApplication2\Views\_ViewImports.cshtml"
using WebApplication2;

#line default
#line hidden
#line 2 "F:\WebApplication2\WebApplication2\Views\_ViewImports.cshtml"
using WebApplication2.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9e3d8a4c8cfceabf0af5579a68ad748798e8d2fd", @"/Views/Home/Components/Software/_ListView.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6b36aee4455a440795f240a74431c307640c545e", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Components_Software__ListView : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<SoftwareModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(28, 15, true);
            WriteLiteral("\r\n\r\n<div>\r\n\r\n\r\n");
            EndContext();
#line 7 "F:\WebApplication2\WebApplication2\Views\Home\Components\Software\_ListView.cshtml"
     foreach (var s in @Model)
    {

#line default
#line hidden
            BeginContext(82, 31, true);
            WriteLiteral("        <label>\r\n\r\n            ");
            EndContext();
            BeginContext(114, 6, false);
#line 11 "F:\WebApplication2\WebApplication2\Views\Home\Components\Software\_ListView.cshtml"
       Write(s.Name);

#line default
#line hidden
            EndContext();
            BeginContext(120, 69, true);
            WriteLiteral("\r\n\r\n        </label>\r\n        <br />\r\n        <label>\r\n\r\n            ");
            EndContext();
            BeginContext(190, 8, false);
#line 17 "F:\WebApplication2\WebApplication2\Views\Home\Components\Software\_ListView.cshtml"
       Write(s.Family);

#line default
#line hidden
            EndContext();
            BeginContext(198, 69, true);
            WriteLiteral("  \r\n\r\n        </label>\r\n        <br />\r\n        <label>\r\n            ");
            EndContext();
            BeginContext(268, 8, false);
#line 22 "F:\WebApplication2\WebApplication2\Views\Home\Components\Software\_ListView.cshtml"
       Write(s.Namber);

#line default
#line hidden
            EndContext();
            BeginContext(276, 52, true);
            WriteLiteral("\r\n        </label>\r\n        <br />\r\n        <hr />\r\n");
            EndContext();
#line 26 "F:\WebApplication2\WebApplication2\Views\Home\Components\Software\_ListView.cshtml"

    }

#line default
#line hidden
            BeginContext(337, 10, true);
            WriteLiteral("\r\n\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<SoftwareModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591