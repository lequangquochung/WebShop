#pragma checksum "D:\CODE GYM\WebShopStudy\WebShopApp\WebShopApp\Views\Products\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f70efd8b4d2914bcbadffcf8cb458f34530edbf7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Products_Details), @"mvc.1.0.view", @"/Views/Products/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Products/Details.cshtml", typeof(AspNetCore.Views_Products_Details))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f70efd8b4d2914bcbadffcf8cb458f34530edbf7", @"/Views/Products/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"92f21af9d72f4cf84778e835f2bb18d5c9372882", @"/Views/_ViewImports.cshtml")]
    public class Views_Products_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WebShopApp.Models.Product>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
            BeginContext(34, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "D:\CODE GYM\WebShopStudy\WebShopApp\WebShopApp\Views\Products\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(79, 465, true);
            WriteLiteral(@"
<h1>Details</h1>

<div>
    <h4>Product</h4>
    <hr />
   
</div>

<div class=""container bgwhite p-t-35 p-b-80"">
    <div class=""flex-w flex-sb"">
        <div class=""w-size13 p-t-30 respon5"">
            <div class=""wrap-slick3 flex-sb flex-w"">
                <div class=""slick3"">
                    <div class=""item-slick3"" data-thumb=""images/thumb-item-02.jpg"">
                        <div class=""wrap-pic-w"">
                            <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 544, "\"", 565, 1);
#line 22 "D:\CODE GYM\WebShopStudy\WebShopApp\WebShopApp\Views\Products\Details.cshtml"
WriteAttributeValue("", 550, Model.ImageUrl, 550, 15, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(566, 268, true);
            WriteLiteral(@" alt=""IMG-PRODUCT"">
                        </div>
                    </div>
                </div>
            </div>
        </div>

        <div class=""w-size14 p-t-30 respon5"">
            <h4 class=""product-detail-name m-text16 p-b-13"">
                ");
            EndContext();
            BeginContext(835, 10, false);
#line 31 "D:\CODE GYM\WebShopStudy\WebShopApp\WebShopApp\Views\Products\Details.cshtml"
           Write(Model.Name);

#line default
#line hidden
            EndContext();
            BeginContext(845, 60, true);
            WriteLiteral("\r\n            </h4>\r\n            <div>\r\n                <h4>");
            EndContext();
            BeginContext(906, 22, false);
#line 34 "D:\CODE GYM\WebShopStudy\WebShopApp\WebShopApp\Views\Products\Details.cshtml"
               Write(Model.ShortDescription);

#line default
#line hidden
            EndContext();
            BeginContext(928, 82, true);
            WriteLiteral("</h4>\r\n            </div>\r\n\r\n            <span class=\"m-text17\">\r\n                ");
            EndContext();
            BeginContext(1011, 11, false);
#line 38 "D:\CODE GYM\WebShopStudy\WebShopApp\WebShopApp\Views\Products\Details.cshtml"
           Write(Model.Price);

#line default
#line hidden
            EndContext();
            BeginContext(1022, 1741, true);
            WriteLiteral(@"
            </span>


            <div class=""flex-r-m flex-w p-t-10"">
                <div class=""w-size16 flex-m flex-w"">
                    <div class=""flex-w bo5 of-hidden m-r-22 m-t-10 m-b-10"">
                        <button class=""btn-num-product-down color1 flex-c-m size7 bg8 eff2"">
                            <i class=""fs-12 fa fa-minus"" aria-hidden=""true""></i>
                        </button>

                        <input class=""size8 m-text18 t-center num-product"" type=""number"" name=""num-product"" value=""1"">

                        <button class=""btn-num-product-up color1 flex-c-m size7 bg8 eff2"">
                            <i class=""fs-12 fa fa-plus"" aria-hidden=""true""></i>
                        </button>
                    </div>

                    <div class=""btn-addcart-product-detail size9 trans-0-4 m-t-10 m-b-10"">
                        <!-- Button -->
                        <button class=""flex-c-m sizefull bg1 bo-rad-23 hov1 s-text1 trans-0-4"">
             ");
            WriteLiteral(@"               Add to Cart
                        </button>
                    </div>
                </div>
            </div>
        </div>

        <!--  -->
        <div class=""wrap-dropdown-content bo6 p-t-15 p-b-14 active-dropdown-content"">
            <h5 class=""js-toggle-dropdown-content flex-sb-m cs-pointer m-text19 color0-hov trans-0-4"">
                Description
                <i class=""down-mark fs-12 color1 fa fa-minus dis-none"" aria-hidden=""true""></i>
                <i class=""up-mark fs-12 color1 fa fa-plus"" aria-hidden=""true""></i>
            </h5>

            <div class=""dropdown-content dis-none p-t-15 p-b-23"">
                <p class=""s-text8"">
                    ");
            EndContext();
            BeginContext(2764, 21, false);
#line 76 "D:\CODE GYM\WebShopStudy\WebShopApp\WebShopApp\Views\Products\Details.cshtml"
               Write(Model.LongDescription);

#line default
#line hidden
            EndContext();
            BeginContext(2785, 104, true);
            WriteLiteral("\r\n                </p>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\t</div>\r\n\r\n\r\n<div>\r\n    ");
            EndContext();
            BeginContext(2889, 61, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f70efd8b4d2914bcbadffcf8cb458f34530edbf78935", async() => {
                BeginContext(2942, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 86 "D:\CODE GYM\WebShopStudy\WebShopApp\WebShopApp\Views\Products\Details.cshtml"
                           WriteLiteral(Model.ProductId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2950, 8, true);
            WriteLiteral(" |\r\n    ");
            EndContext();
            BeginContext(2958, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f70efd8b4d2914bcbadffcf8cb458f34530edbf711260", async() => {
                BeginContext(2980, 12, true);
                WriteLiteral("Back to List");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2996, 10, true);
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebShopApp.Models.Product> Html { get; private set; }
    }
}
#pragma warning restore 1591
