#pragma checksum "C:\Users\shres\source\repos\ASP.NETmvc\Views\Home\PersonalDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d6ef5d90546a245eebb622c453aeb3cc61886146"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_PersonalDetails), @"mvc.1.0.view", @"/Views/Home/PersonalDetails.cshtml")]
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
#line 1 "C:\Users\shres\source\repos\ASP.NETmvc\Views\_ViewImports.cshtml"
using ASP.NETmvc;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\shres\source\repos\ASP.NETmvc\Views\_ViewImports.cshtml"
using ASP.NETmvc.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d6ef5d90546a245eebb622c453aeb3cc61886146", @"/Views/Home/PersonalDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4b7e2b1a5902cb6eeb3b3637aedc74dba98c3388", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_PersonalDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PersonalDetail>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\shres\source\repos\ASP.NETmvc\Views\Home\PersonalDetails.cshtml"
  
    ViewData["Title"] = "PersonalDetail";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Personal Detail</h1>\r\n<h2>Here is ");
#nullable restore
#line 8 "C:\Users\shres\source\repos\ASP.NETmvc\Views\Home\PersonalDetails.cshtml"
       Write(Html.DisplayFor(x => Model.FirstName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\'s details</h2>\r\n\r\n<table border=\"1\" class=\"table table-bordered\">\r\n    <tr>\r\n        <th>Particular</th>\r\n        <th>Details</th>\r\n    </tr>\r\n\r\n    <tr>\r\n        <td>");
#nullable restore
#line 17 "C:\Users\shres\source\repos\ASP.NETmvc\Views\Home\PersonalDetails.cshtml"
       Write(Html.DisplayNameFor(x => x.FirstName));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 18 "C:\Users\shres\source\repos\ASP.NETmvc\Views\Home\PersonalDetails.cshtml"
       Write(Html.DisplayFor(x => Model.FirstName));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    </tr>\r\n    <tr>\r\n        <td>");
#nullable restore
#line 21 "C:\Users\shres\source\repos\ASP.NETmvc\Views\Home\PersonalDetails.cshtml"
       Write(Html.DisplayNameFor(x => x.Address));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 22 "C:\Users\shres\source\repos\ASP.NETmvc\Views\Home\PersonalDetails.cshtml"
       Write(Html.DisplayFor(x => Model.Address));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    </tr>\r\n    <tr>\r\n        <td>");
#nullable restore
#line 25 "C:\Users\shres\source\repos\ASP.NETmvc\Views\Home\PersonalDetails.cshtml"
       Write(Html.DisplayNameFor(x => x.Age));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 26 "C:\Users\shres\source\repos\ASP.NETmvc\Views\Home\PersonalDetails.cshtml"
       Write(Html.DisplayFor(x => Model.Age));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    </tr>\r\n    <tr>\r\n        <td>");
#nullable restore
#line 29 "C:\Users\shres\source\repos\ASP.NETmvc\Views\Home\PersonalDetails.cshtml"
       Write(Html.DisplayNameFor(x => x.Occupation));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 30 "C:\Users\shres\source\repos\ASP.NETmvc\Views\Home\PersonalDetails.cshtml"
       Write(Html.DisplayFor(x => Model.Occupation));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    </tr>\r\n\r\n</table>\r\n\r\n");
#nullable restore
#line 35 "C:\Users\shres\source\repos\ASP.NETmvc\Views\Home\PersonalDetails.cshtml"
Write(Html.ActionLink("Back to Persons", "Persons", "Home", null, new { @class = "btn btn-secondary" }));

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PersonalDetail> Html { get; private set; }
    }
}
#pragma warning restore 1591
