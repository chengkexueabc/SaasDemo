#pragma checksum "C:\Users\Administrator\source\repos\QuestionExchange\QuestionExchange\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bc3a3127bea710997390ea1b11fc2635fec95989"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\Administrator\source\repos\QuestionExchange\QuestionExchange\Views\_ViewImports.cshtml"
using QuestionExchange;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Administrator\source\repos\QuestionExchange\QuestionExchange\Views\_ViewImports.cshtml"
using QuestionExchange.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bc3a3127bea710997390ea1b11fc2635fec95989", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aa503d22eb313bfce8f98ff3f5e5a1cebeda3240", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<QuestionListViewModel>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(" \r\n");
#nullable restore
#line 4 "C:\Users\Administrator\source\repos\QuestionExchange\QuestionExchange\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral(" \r\n<div class=\"row\">\r\n    <div class=\"col-md-12\">\r\n        <h1>Welcome to <strong>");
#nullable restore
#line 10 "C:\Users\Administrator\source\repos\QuestionExchange\QuestionExchange\Views\Home\Index.cshtml"
                          Write(Tenant.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong></h1>\r\n        <h3>");
#nullable restore
#line 11 "C:\Users\Administrator\source\repos\QuestionExchange\QuestionExchange\Views\Home\Index.cshtml"
       Write(Tenant.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n    </div>\r\n</div>\r\n \r\n<div class=\"row\">\r\n    <div class=\"col-md-12\">\r\n        <h4>Popular questions</h4>\r\n        <ul>\r\n");
#nullable restore
#line 19 "C:\Users\Administrator\source\repos\QuestionExchange\QuestionExchange\Views\Home\Index.cshtml"
             foreach (var question in Model.Questions)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <li>");
#nullable restore
#line 21 "C:\Users\Administrator\source\repos\QuestionExchange\QuestionExchange\Views\Home\Index.cshtml"
               Write(question.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n");
#nullable restore
#line 22 "C:\Users\Administrator\source\repos\QuestionExchange\QuestionExchange\Views\Home\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </ul>\r\n    </div>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public Tenant Tenant { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<QuestionListViewModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591