#pragma checksum "D:\amozesh\asp\projhe\eefa-seram\2609\WebApplication2\Views\Shared\Components\UserDetail\UserDetail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "67f878d6800cdaa2be327398ad57097220ee8d71"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_UserDetail_UserDetail), @"mvc.1.0.view", @"/Views/Shared/Components/UserDetail/UserDetail.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/Components/UserDetail/UserDetail.cshtml", typeof(AspNetCore.Views_Shared_Components_UserDetail_UserDetail))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"67f878d6800cdaa2be327398ad57097220ee8d71", @"/Views/Shared/Components/UserDetail/UserDetail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6b36aee4455a440795f240a74431c307640c545e", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_UserDetail_UserDetail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WebApplication2.Models.ViewModels.UserDetailViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 5, true);
            WriteLiteral(" \r\n\r\n");
            EndContext();
            BeginContext(67, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 5 "D:\amozesh\asp\projhe\eefa-seram\2609\WebApplication2\Views\Shared\Components\UserDetail\UserDetail.cshtml"
  
    ViewData["Title"] = "Details";
    Layout = null;

#line default
#line hidden
            BeginContext(132, 112, true);
            WriteLiteral("\r\n<h1>?????????????? ??????????</h1>\r\n\r\n<div>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(245, 38, false);
#line 16 "D:\amozesh\asp\projhe\eefa-seram\2609\WebApplication2\Views\Shared\Components\UserDetail\UserDetail.cshtml"
       Write(Html.DisplayNameFor(model => model.Id));

#line default
#line hidden
            EndContext();
            BeginContext(283, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(345, 34, false);
#line 19 "D:\amozesh\asp\projhe\eefa-seram\2609\WebApplication2\Views\Shared\Components\UserDetail\UserDetail.cshtml"
       Write(Html.DisplayFor(model => model.Id));

#line default
#line hidden
            EndContext();
            BeginContext(379, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(440, 41, false);
#line 22 "D:\amozesh\asp\projhe\eefa-seram\2609\WebApplication2\Views\Shared\Components\UserDetail\UserDetail.cshtml"
       Write(Html.DisplayNameFor(model => model.Email));

#line default
#line hidden
            EndContext();
            BeginContext(481, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(543, 37, false);
#line 25 "D:\amozesh\asp\projhe\eefa-seram\2609\WebApplication2\Views\Shared\Components\UserDetail\UserDetail.cshtml"
       Write(Html.DisplayFor(model => model.Email));

#line default
#line hidden
            EndContext();
            BeginContext(580, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(641, 40, false);
#line 28 "D:\amozesh\asp\projhe\eefa-seram\2609\WebApplication2\Views\Shared\Components\UserDetail\UserDetail.cshtml"
       Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(681, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(743, 36, false);
#line 31 "D:\amozesh\asp\projhe\eefa-seram\2609\WebApplication2\Views\Shared\Components\UserDetail\UserDetail.cshtml"
       Write(Html.DisplayFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(779, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(840, 44, false);
#line 34 "D:\amozesh\asp\projhe\eefa-seram\2609\WebApplication2\Views\Shared\Components\UserDetail\UserDetail.cshtml"
       Write(Html.DisplayNameFor(model => model.LastName));

#line default
#line hidden
            EndContext();
            BeginContext(884, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(946, 40, false);
#line 37 "D:\amozesh\asp\projhe\eefa-seram\2609\WebApplication2\Views\Shared\Components\UserDetail\UserDetail.cshtml"
       Write(Html.DisplayFor(model => model.LastName));

#line default
#line hidden
            EndContext();
            BeginContext(986, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1047, 47, false);
#line 40 "D:\amozesh\asp\projhe\eefa-seram\2609\WebApplication2\Views\Shared\Components\UserDetail\UserDetail.cshtml"
       Write(Html.DisplayNameFor(model => model.PhoneNumber));

#line default
#line hidden
            EndContext();
            BeginContext(1094, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1156, 43, false);
#line 43 "D:\amozesh\asp\projhe\eefa-seram\2609\WebApplication2\Views\Shared\Components\UserDetail\UserDetail.cshtml"
       Write(Html.DisplayFor(model => model.PhoneNumber));

#line default
#line hidden
            EndContext();
            BeginContext(1199, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1260, 43, false);
#line 46 "D:\amozesh\asp\projhe\eefa-seram\2609\WebApplication2\Views\Shared\Components\UserDetail\UserDetail.cshtml"
       Write(Html.DisplayNameFor(model => model.Address));

#line default
#line hidden
            EndContext();
            BeginContext(1303, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1365, 39, false);
#line 49 "D:\amozesh\asp\projhe\eefa-seram\2609\WebApplication2\Views\Shared\Components\UserDetail\UserDetail.cshtml"
       Write(Html.DisplayFor(model => model.Address));

#line default
#line hidden
            EndContext();
            BeginContext(1404, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1465, 39, false);
#line 52 "D:\amozesh\asp\projhe\eefa-seram\2609\WebApplication2\Views\Shared\Components\UserDetail\UserDetail.cshtml"
       Write(Html.DisplayNameFor(model => model.Job));

#line default
#line hidden
            EndContext();
            BeginContext(1504, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1566, 35, false);
#line 55 "D:\amozesh\asp\projhe\eefa-seram\2609\WebApplication2\Views\Shared\Components\UserDetail\UserDetail.cshtml"
       Write(Html.DisplayFor(model => model.Job));

#line default
#line hidden
            EndContext();
            BeginContext(1601, 38, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebApplication2.Models.ViewModels.UserDetailViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
