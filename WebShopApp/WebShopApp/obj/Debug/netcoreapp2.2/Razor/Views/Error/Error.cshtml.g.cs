#pragma checksum "D:\CODE GYM\WebShopStudy\WebShopApp\WebShopApp\Views\Error\Error.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0d35abddb9a69950c34f590d317907475e6c291a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Error_Error), @"mvc.1.0.view", @"/Views/Error/Error.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Error/Error.cshtml", typeof(AspNetCore.Views_Error_Error))]
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
#line 1 "D:\CODE GYM\WebShopStudy\WebShopApp\WebShopApp\Views\_ViewImports.cshtml"
using WebShopApp;

#line default
#line hidden
#line 2 "D:\CODE GYM\WebShopStudy\WebShopApp\WebShopApp\Views\_ViewImports.cshtml"
using WebShopApp.Models;

#line default
#line hidden
#line 3 "D:\CODE GYM\WebShopStudy\WebShopApp\WebShopApp\Views\_ViewImports.cshtml"
using WebShopApp.ViewModels;

#line default
#line hidden
#line 4 "D:\CODE GYM\WebShopStudy\WebShopApp\WebShopApp\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0d35abddb9a69950c34f590d317907475e6c291a", @"/Views/Error/Error.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"92f21af9d72f4cf84778e835f2bb18d5c9372882", @"/Views/_ViewImports.cshtml")]
    public class Views_Error_Error : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "D:\CODE GYM\WebShopStudy\WebShopApp\WebShopApp\Views\Error\Error.cshtml"
 if (ViewBag.ErrorTitle == null)
{

#line default
#line hidden
            BeginContext(37, 197, true);
            WriteLiteral("    <h3>\r\n        An occured while processing your request.\r\n        The support team is notified and we are working on the fix\r\n    </h3>\r\n    <h5>Please contact us on pragim@pragimtech.com</h5>\r\n");
            EndContext();
#line 8 "D:\CODE GYM\WebShopStudy\WebShopApp\WebShopApp\Views\Error\Error.cshtml"
}
else
{

#line default
#line hidden
            BeginContext(246, 28, true);
            WriteLiteral("    <h1 class=\"text-danger\">");
            EndContext();
            BeginContext(275, 18, false);
#line 11 "D:\CODE GYM\WebShopStudy\WebShopApp\WebShopApp\Views\Error\Error.cshtml"
                       Write(ViewBag.ErrorTitle);

#line default
#line hidden
            EndContext();
            BeginContext(293, 35, true);
            WriteLiteral("</h1>\r\n    <h6 class=\"text-danger\">");
            EndContext();
            BeginContext(329, 20, false);
#line 12 "D:\CODE GYM\WebShopStudy\WebShopApp\WebShopApp\Views\Error\Error.cshtml"
                       Write(ViewBag.ErrorMessage);

#line default
#line hidden
            EndContext();
            BeginContext(349, 7, true);
            WriteLiteral("</h6>\r\n");
            EndContext();
#line 13 "D:\CODE GYM\WebShopStudy\WebShopApp\WebShopApp\Views\Error\Error.cshtml"
}

#line default
#line hidden
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