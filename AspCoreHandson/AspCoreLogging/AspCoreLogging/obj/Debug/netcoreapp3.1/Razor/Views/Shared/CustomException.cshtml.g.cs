#pragma checksum "C:\Users\swetha\source\repos\AspCoreLogging\AspCoreLogging\Views\Shared\CustomException.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8566a7c73d723b21e7028b8f710afc26424a5522"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_CustomException), @"mvc.1.0.view", @"/Views/Shared/CustomException.cshtml")]
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
#line 1 "C:\Users\swetha\source\repos\AspCoreLogging\AspCoreLogging\Views\_ViewImports.cshtml"
using AspCoreLogging;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\swetha\source\repos\AspCoreLogging\AspCoreLogging\Views\_ViewImports.cshtml"
using AspCoreLogging.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8566a7c73d723b21e7028b8f710afc26424a5522", @"/Views/Shared/CustomException.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e1928994ae5930275078c4a77da730d428dd714c", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_CustomException : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\swetha\source\repos\AspCoreLogging\AspCoreLogging\Views\Shared\CustomException.cshtml"
   ViewData["Title"] = "CustomError";
    Exception ex = ViewData["HandleException"] as Exception; 

#line default
#line hidden
#nullable disable
            WriteLiteral("<h1>");
#nullable restore
#line 4 "C:\Users\swetha\source\repos\AspCoreLogging\AspCoreLogging\Views\Shared\CustomException.cshtml"
Write(ex.Message);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n<div>");
#nullable restore
#line 5 "C:\Users\swetha\source\repos\AspCoreLogging\AspCoreLogging\Views\Shared\CustomException.cshtml"
Write(ex.StackTrace);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
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
