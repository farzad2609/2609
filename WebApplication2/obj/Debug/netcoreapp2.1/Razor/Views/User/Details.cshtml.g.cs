#pragma checksum "D:\amozesh\asp\projhe\eefa-seram\2609\WebApplication2\Views\User\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6746c967d148e81179d7560107812e47c200ee00"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_Details), @"mvc.1.0.view", @"/Views/User/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/User/Details.cshtml", typeof(AspNetCore.Views_User_Details))]
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
#line 1 "D:\amozesh\asp\projhe\eefa-seram\2609\WebApplication2\Views\_ViewImports.cshtml"
using WebApplication2;

#line default
#line hidden
#line 2 "D:\amozesh\asp\projhe\eefa-seram\2609\WebApplication2\Views\_ViewImports.cshtml"
using WebApplication2.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6746c967d148e81179d7560107812e47c200ee00", @"/Views/User/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6b36aee4455a440795f240a74431c307640c545e", @"/Views/_ViewImports.cshtml")]
    public class Views_User_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "D:\amozesh\asp\projhe\eefa-seram\2609\WebApplication2\Views\User\Details.cshtml"
  
    ViewData["Title"] = "Details";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(92, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            BeginContext(97, 72, false);
#line 8 "D:\amozesh\asp\projhe\eefa-seram\2609\WebApplication2\Views\User\Details.cshtml"
Write(await Component.InvokeAsync("UserDetail", new { Id = (long)ViewBag.Id }));

#line default
#line hidden
            EndContext();
            BeginContext(169, 4, true);
            WriteLiteral("\r\n\r\n");
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
