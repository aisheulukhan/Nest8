#pragma checksum "C:\Users\HP\Desktop\New folder (2)\Nest8\Nest5\Nest3\TaskNest\TaskNest\Views\Product\Cart.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "777391552af49eac1c510ea1afb15363e19dc0d5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_Cart), @"mvc.1.0.view", @"/Views/Product/Cart.cshtml")]
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
#line 1 "C:\Users\HP\Desktop\New folder (2)\Nest8\Nest5\Nest3\TaskNest\TaskNest\Views\_ViewImports.cshtml"
using TaskNest;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\HP\Desktop\New folder (2)\Nest8\Nest5\Nest3\TaskNest\TaskNest\Views\_ViewImports.cshtml"
using TaskNest.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\HP\Desktop\New folder (2)\Nest8\Nest5\Nest3\TaskNest\TaskNest\Views\_ViewImports.cshtml"
using TaskNest.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"777391552af49eac1c510ea1afb15363e19dc0d5", @"/Views/Product/Cart.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6c6bf3f5a72dc5107c9286c90c61434473c6e4ea", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_Cart : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<BasketItemsVM>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("#"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Product", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Remove", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-body"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\HP\Desktop\New folder (2)\Nest8\Nest5\Nest3\TaskNest\TaskNest\Views\Product\Cart.cshtml"
  
    ViewData["Title"] = "Cart";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""page-header breadcrumb-wrap"">
    <div class=""container"">
        <div class=""breadcrumb"">
            <a href=""index.html"" rel=""nofollow""><i class=""fi-rs-home mr-5""></i>Home</a>
            <span></span> Shop
            <span></span> Cart
        </div>
    </div>
</div>
<div class=""container mb-80 mt-50"">
    <div class=""row"">
        <div class=""col-lg-8 mb-40"">
            <h1 class=""heading-2 mb-10"">Your Cart</h1>
            <div class=""d-flex justify-content-between"">
                <h6 class=""text-body"">There are <span class=""text-brand"">3</span> products in your cart</h6>
                <h6 class=""text-body""><a href=""#"" class=""text-muted""><i class=""fi-rs-trash mr-5""></i>Clear Cart</a></h6>
            </div>
        </div>
    </div>
    <div class=""row"">
        <div class=""col-lg-12"">
");
#nullable restore
#line 27 "C:\Users\HP\Desktop\New folder (2)\Nest8\Nest5\Nest3\TaskNest\TaskNest\Views\Product\Cart.cshtml"
             if (Model.Count >0)
            {


#line default
#line hidden
#nullable disable
            WriteLiteral(@"            <div class=""table-responsive shopping-summery"">
                <table class=""table table-wishlist"">
                    <thead>
                        <tr class=""main-heading"">
                            <th scope=""col"" colspan=""2"">Product</th>
                            <th scope=""col"">Unit Price</th>
                            <th scope=""col"">Quantity</th>
                            <th scope=""col"">Subtotal</th>
                            <th scope=""col"" class=""end"">Remove</th>
                        </tr>
                    </thead>
                    <tbody  class=""pt-30"">
");
#nullable restore
#line 42 "C:\Users\HP\Desktop\New folder (2)\Nest8\Nest5\Nest3\TaskNest\TaskNest\Views\Product\Cart.cshtml"
                         foreach (BasketItemsVM item in Model)
                        {


#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\r\n                            <td class=\"image product-thumbnail pt-40\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "777391552af49eac1c510ea1afb15363e19dc0d57489", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1785, "~/assets/imgs/shop/", 1785, 19, true);
#nullable restore
#line 46 "C:\Users\HP\Desktop\New folder (2)\Nest8\Nest5\Nest3\TaskNest\TaskNest\Views\Product\Cart.cshtml"
AddHtmlAttributeValue("", 1804, item.Image, 1804, 11, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</td>\r\n                            <td class=\"product-des product-name\">\r\n                                <h6 class=\"mb-5\">\r\n                                    <a class=\"product-name mb-10 text-heading\" href=\"shop-product-right.html\">");
#nullable restore
#line 49 "C:\Users\HP\Desktop\New folder (2)\Nest8\Nest5\Nest3\TaskNest\TaskNest\Views\Product\Cart.cshtml"
                                                                                                         Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                                </h6>\r\n                                ");
#nullable restore
#line 51 "C:\Users\HP\Desktop\New folder (2)\Nest8\Nest5\Nest3\TaskNest\TaskNest\Views\Product\Cart.cshtml"
                            Write(item.IsActive==false ? Html.Raw(@"<div class='product - rate - cover'>
                                                                    <span class = 'text-danger'>Mal bitib</span>
                                                                      </div>"):Html.Raw(""));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                <div class=\"product-rate-cover\">\r\n                                    <div class=\"product-rate d-inline-block\">\r\n                                        <div class=\"product-rating\"");
            BeginWriteAttribute("style", " style=\"", 2641, "\"", 2674, 3);
            WriteAttributeValue("", 2649, "width:", 2649, 6, true);
#nullable restore
#line 56 "C:\Users\HP\Desktop\New folder (2)\Nest8\Nest5\Nest3\TaskNest\TaskNest\Views\Product\Cart.cshtml"
WriteAttributeValue("", 2655, item.Raiting*20, 2655, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2673, "%", 2673, 1, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                        </div>\r\n                                    </div>\r\n                                    <span class=\"font-small ml-5 text-muted\"> (");
#nullable restore
#line 59 "C:\Users\HP\Desktop\New folder (2)\Nest8\Nest5\Nest3\TaskNest\TaskNest\Views\Product\Cart.cshtml"
                                                                          Write(item.Raiting);

#line default
#line hidden
#nullable disable
            WriteLiteral(")</span>\r\n                                </div>\r\n                            </td>\r\n                            <td class=\"price\" data-title=\"Price\">\r\n                                <h4 class=\"text-body\">$");
#nullable restore
#line 63 "C:\Users\HP\Desktop\New folder (2)\Nest8\Nest5\Nest3\TaskNest\TaskNest\Views\Product\Cart.cshtml"
                                                  Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" </h4>
                            </td>
                            <td class=""text-center detail-info"" data-title=""Stock"">
                                <div class=""detail-extralink mr-15"">
                                    <div class=""detail-qty border radius"">
                                        <a href=""#"" class=""qty-down""><i class=""fi-rs-angle-small-down""></i></a>
                                        <span class=""qty-val"">");
#nullable restore
#line 69 "C:\Users\HP\Desktop\New folder (2)\Nest8\Nest5\Nest3\TaskNest\TaskNest\Views\Product\Cart.cshtml"
                                                         Write(item.Count);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
                                        <a href=""#"" class=""qty-up""><i class=""fi-rs-angle-small-up""></i></a>
                                    </div>
                                </div>
                            </td>
                            <td class=""price"" data-title=""Price"">
                                <h4 class=""text-brand"">$");
#nullable restore
#line 75 "C:\Users\HP\Desktop\New folder (2)\Nest8\Nest5\Nest3\TaskNest\TaskNest\Views\Product\Cart.cshtml"
                                                    Write(item.Count*item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </h4>\r\n                            </td>\r\n                            <td class=\"action text-center\" data-title=\"Remove\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "777391552af49eac1c510ea1afb15363e19dc0d513542", async() => {
                WriteLiteral("<i class=\"fi-rs-trash\"></i>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 77 "C:\Users\HP\Desktop\New folder (2)\Nest8\Nest5\Nest3\TaskNest\TaskNest\Views\Product\Cart.cshtml"
                                                                                                                                 WriteLiteral(item.ProductId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</td>\r\n                        </tr>\r\n");
#nullable restore
#line 79 "C:\Users\HP\Desktop\New folder (2)\Nest8\Nest5\Nest3\TaskNest\TaskNest\Views\Product\Cart.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                    </tbody>
                </table>
            </div>
            <div class=""divider-2 mb-30""></div>
            <div class=""cart-action d-flex justify-content-between"">
                <a class=""btn ""><i class=""fi-rs-arrow-left mr-10""></i>Continue Shopping</a>
                <a class=""btn  mr-10 mb-sm-15""><i class=""fi-rs-refresh mr-10""></i>Update Cart</a>
            </div>
");
#nullable restore
#line 89 "C:\Users\HP\Desktop\New folder (2)\Nest8\Nest5\Nest3\TaskNest\TaskNest\Views\Product\Cart.cshtml"
            }
            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                  <h2>Sebetiniz bos gorunur. Alis verise ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "777391552af49eac1c510ea1afb15363e19dc0d517128", async() => {
                WriteLiteral("buradan");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" davam ede bilersiniz..</h2>\r\n");
#nullable restore
#line 93 "C:\Users\HP\Desktop\New folder (2)\Nest8\Nest5\Nest3\TaskNest\TaskNest\Views\Product\Cart.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n</div>\r\n        \r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<BasketItemsVM>> Html { get; private set; }
    }
}
#pragma warning restore 1591
