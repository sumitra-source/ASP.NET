#pragma checksum "C:\Users\shres\Desktop\ASP.NET-master\ASP.NET-master\ERPractical\ERPractical\Views\Student\Students.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c5a2356c04be211ec689c9905b10b35ef0702e30"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Student_Students), @"mvc.1.0.view", @"/Views/Student/Students.cshtml")]
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
#line 1 "C:\Users\shres\Desktop\ASP.NET-master\ASP.NET-master\ERPractical\ERPractical\Views\_ViewImports.cshtml"
using ERPractical;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\shres\Desktop\ASP.NET-master\ASP.NET-master\ERPractical\ERPractical\Views\_ViewImports.cshtml"
using ERPractical.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c5a2356c04be211ec689c9905b10b35ef0702e30", @"/Views/Student/Students.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"35a30166626864dc26215aab56f87491bf23949f", @"/Views/_ViewImports.cshtml")]
    public class Views_Student_Students : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<StudentModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\n");
#nullable restore
#line 3 "C:\Users\shres\Desktop\ASP.NET-master\ASP.NET-master\ERPractical\ERPractical\Views\Student\Students.cshtml"
  
    ViewData["Title"] = "Students";
    int studentCounter = 1;

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<h1>Students</h1>\n\n<p>\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c5a2356c04be211ec689c9905b10b35ef0702e303796", async() => {
                WriteLiteral("Create New");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n</p>\n<table class=\"table\">\n    <thead>\n        <tr>\n            <th>\n                SN\n            </th>\n            <th>\n                ");
#nullable restore
#line 20 "C:\Users\shres\Desktop\ASP.NET-master\ASP.NET-master\ERPractical\ERPractical\Views\Student\Students.cshtml"
           Write(Html.DisplayNameFor(model => model.StudentName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th>\n                ");
#nullable restore
#line 23 "C:\Users\shres\Desktop\ASP.NET-master\ASP.NET-master\ERPractical\ERPractical\Views\Student\Students.cshtml"
           Write(Html.DisplayNameFor(model => model.Address));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th>\n                ");
#nullable restore
#line 26 "C:\Users\shres\Desktop\ASP.NET-master\ASP.NET-master\ERPractical\ERPractical\Views\Student\Students.cshtml"
           Write(Html.DisplayNameFor(model => model.Batch));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th>\n                ");
#nullable restore
#line 29 "C:\Users\shres\Desktop\ASP.NET-master\ASP.NET-master\ERPractical\ERPractical\Views\Student\Students.cshtml"
           Write(Html.DisplayNameFor(model => model.ContactNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th></th>\n        </tr>\n    </thead>\n    <tbody>\n");
#nullable restore
#line 35 "C:\Users\shres\Desktop\ASP.NET-master\ASP.NET-master\ERPractical\ERPractical\Views\Student\Students.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\n            <td>\n                ");
#nullable restore
#line 38 "C:\Users\shres\Desktop\ASP.NET-master\ASP.NET-master\ERPractical\ERPractical\Views\Student\Students.cshtml"
           Write(studentCounter);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n            <td>\n                ");
#nullable restore
#line 41 "C:\Users\shres\Desktop\ASP.NET-master\ASP.NET-master\ERPractical\ERPractical\Views\Student\Students.cshtml"
           Write(Html.DisplayFor(modelItem => item.StudentName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n            <td>\n                ");
#nullable restore
#line 44 "C:\Users\shres\Desktop\ASP.NET-master\ASP.NET-master\ERPractical\ERPractical\Views\Student\Students.cshtml"
           Write(Html.DisplayFor(modelItem => item.Address));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n            <td>\n                ");
#nullable restore
#line 47 "C:\Users\shres\Desktop\ASP.NET-master\ASP.NET-master\ERPractical\ERPractical\Views\Student\Students.cshtml"
           Write(Html.DisplayFor(modelItem => item.Batch));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n            <td>\n                ");
#nullable restore
#line 50 "C:\Users\shres\Desktop\ASP.NET-master\ASP.NET-master\ERPractical\ERPractical\Views\Student\Students.cshtml"
           Write(Html.DisplayFor(modelItem => item.ContactNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n            <td>\n                ");
#nullable restore
#line 53 "C:\Users\shres\Desktop\ASP.NET-master\ASP.NET-master\ERPractical\ERPractical\Views\Student\Students.cshtml"
           Write(Html.ActionLink("Edit", "Edit", new { studentId = item.StudentId }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\n                ");
#nullable restore
#line 54 "C:\Users\shres\Desktop\ASP.NET-master\ASP.NET-master\ERPractical\ERPractical\Views\Student\Students.cshtml"
           Write(Html.ActionLink("Details", "Details", new { studentId = item.StudentId }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\n                ");
#nullable restore
#line 55 "C:\Users\shres\Desktop\ASP.NET-master\ASP.NET-master\ERPractical\ERPractical\Views\Student\Students.cshtml"
           Write(Html.ActionLink("Delete", "Delete", new { studentId = item.StudentId }));

#line default
#line hidden
#nullable disable
            WriteLiteral("|\n                ");
#nullable restore
#line 56 "C:\Users\shres\Desktop\ASP.NET-master\ASP.NET-master\ERPractical\ERPractical\Views\Student\Students.cshtml"
           Write(Html.ActionLink("Marks", "StudentMarks","Mark", new { studentId = item.StudentId }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n        </tr>\n");
#nullable restore
#line 59 "C:\Users\shres\Desktop\ASP.NET-master\ASP.NET-master\ERPractical\ERPractical\Views\Student\Students.cshtml"
        studentCounter++;
}

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\n</table>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<StudentModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
