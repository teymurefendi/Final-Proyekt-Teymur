#pragma checksum "C:\Users\admin\Desktop\basqa final project back\Justica2\Justica2\Views\NewsDetail\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "af0841cc05218d39e467aabfd6e3534da980ed24"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_NewsDetail_Index), @"mvc.1.0.view", @"/Views/NewsDetail/Index.cshtml")]
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
#line 1 "C:\Users\admin\Desktop\basqa final project back\Justica2\Justica2\Views\_ViewImports.cshtml"
using Justica2;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\admin\Desktop\basqa final project back\Justica2\Justica2\Views\_ViewImports.cshtml"
using Justica2.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\admin\Desktop\basqa final project back\Justica2\Justica2\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\admin\Desktop\basqa final project back\Justica2\Justica2\Views\_ViewImports.cshtml"
using Justica2.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"af0841cc05218d39e467aabfd6e3534da980ed24", @"/Views/NewsDetail/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c5ae762b0e2273a956ec2135f0d93291378d051e", @"/Views/_ViewImports.cshtml")]
    public class Views_NewsDetail_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<VmNewsDetail>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "NewsDetail", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\admin\Desktop\basqa final project back\Justica2\Justica2\Views\NewsDetail\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<section id=\"sub-header\">\r\n    <div class=\"container\">\r\n        <div class=\"row\">\r\n            <div class=\"col\">\r\n                <h1>");
#nullable restore
#line 10 "C:\Users\admin\Desktop\basqa final project back\Justica2\Justica2\Views\NewsDetail\Index.cshtml"
               Write(Model.New.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h1>
                <div class=""h1-border"" style=""width: 260px;"">
                </div>
                <p>Reputation. Respect. Result.</p>
            </div>
        </div>
    </div>
</section>
<section id=""single-all"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-md-8"">
                <div class=""single-content"">
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "af0841cc05218d39e467aabfd6e3534da980ed245657", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 615, "~/dist/img/", 615, 11, true);
#nullable restore
#line 23 "C:\Users\admin\Desktop\basqa final project back\Justica2\Justica2\Views\NewsDetail\Index.cshtml"
AddHtmlAttributeValue("", 626, Model.New.Img, 626, 14, false);

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
            WriteLiteral("\r\n                    <div class=\"single-text\">\r\n                        <p>\r\n                            ");
#nullable restore
#line 26 "C:\Users\admin\Desktop\basqa final project back\Justica2\Justica2\Views\NewsDetail\Index.cshtml"
                       Write(Model.New.Text1);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </p>\r\n                        <blockquote>");
#nullable restore
#line 28 "C:\Users\admin\Desktop\basqa final project back\Justica2\Justica2\Views\NewsDetail\Index.cshtml"
                               Write(Model.New.Aforizm);

#line default
#line hidden
#nullable disable
            WriteLiteral("</blockquote>\r\n                        <p>\r\n                            ");
#nullable restore
#line 30 "C:\Users\admin\Desktop\basqa final project back\Justica2\Justica2\Views\NewsDetail\Index.cshtml"
                       Write(Model.New.Text2);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </p>\r\n                        <p>\r\n                            ");
#nullable restore
#line 33 "C:\Users\admin\Desktop\basqa final project back\Justica2\Justica2\Views\NewsDetail\Index.cshtml"
                       Write(Model.New.Text3);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </p>\r\n                        <span class=\"news-date\">");
#nullable restore
#line 35 "C:\Users\admin\Desktop\basqa final project back\Justica2\Justica2\Views\NewsDetail\Index.cshtml"
                                           Write(Model.New.CreatedDAte.ToString("dd MMMM yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
                        <span id=""news-like"" onclick=""likebtn()"">
                            <i id=""urek"" class=""far fa-heart""></i><span id=""like-count"">181</span>
                        </span>
                    </div>
                </div>
                <div id=""news-comment"">
                    <div id=""fb-root""></div>
                    <div class=""fb-comments"" data-href=""");
#nullable restore
#line 43 "C:\Users\admin\Desktop\basqa final project back\Justica2\Justica2\Views\NewsDetail\Index.cshtml"
                                                   Write(Model.New.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral(@""" data-width=""100%"" data-numposts=""10""></div>
                </div>
            </div>
            <div class=""col-md-4"">
                <div class=""widget-cont widget-post"">
                    <h4>Recent Posts</h4>
                    <div class=""border-h4""></div>
                    <ul>
");
#nullable restore
#line 51 "C:\Users\admin\Desktop\basqa final project back\Justica2\Justica2\Views\NewsDetail\Index.cshtml"
                         foreach (var item in Model.NewsNames.TakeLast(6))
                        {
                            if (!(Model.New.Id == item.NewsId))
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                               <li>\r\n                                   <span>");
#nullable restore
#line 56 "C:\Users\admin\Desktop\basqa final project back\Justica2\Justica2\Views\NewsDetail\Index.cshtml"
                                    Write(item.News.CreatedDAte.Day);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 56 "C:\Users\admin\Desktop\basqa final project back\Justica2\Justica2\Views\NewsDetail\Index.cshtml"
                                                               Write(item.News.CreatedDAte.ToString("MMM"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                   ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "af0841cc05218d39e467aabfd6e3534da980ed2411166", async() => {
#nullable restore
#line 57 "C:\Users\admin\Desktop\basqa final project back\Justica2\Justica2\Views\NewsDetail\Index.cshtml"
                                                                                                                                                      Write(item.Name);

#line default
#line hidden
#nullable disable
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
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-Id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 57 "C:\Users\admin\Desktop\basqa final project back\Justica2\Justica2\Views\NewsDetail\Index.cshtml"
                                                                                       WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["Id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-Id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["Id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "class", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 57 "C:\Users\admin\Desktop\basqa final project back\Justica2\Justica2\Views\NewsDetail\Index.cshtml"
AddHtmlAttributeValue("", 2363, ViewBag.Active=="News"?"active":"", 2363, 37, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                               </li>\r\n");
#nullable restore
#line 59 "C:\Users\admin\Desktop\basqa final project back\Justica2\Justica2\Views\NewsDetail\Index.cshtml"
                            }
                        }                        

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </ul>\r\n                </div>\r\n                <div class=\"widget-cont widget-text\">\r\n                    <h4>About Us</h4>\r\n                    <div class=\"border-h4\"></div>\r\n                    <p>\r\n                        ");
#nullable restore
#line 67 "C:\Users\admin\Desktop\basqa final project back\Justica2\Justica2\Views\NewsDetail\Index.cshtml"
                   Write(Model.New.About);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </p>\r\n                </div>\r\n                <div class=\"widget-cont widget-tags\">\r\n                    <h4>Tags</h4>\r\n                    <div class=\"border-h4\"></div>\r\n                    <ul>\r\n");
#nullable restore
#line 74 "C:\Users\admin\Desktop\basqa final project back\Justica2\Justica2\Views\NewsDetail\Index.cshtml"
                         foreach (var item in Model.New.NewsToTags)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <li><a href=\"#\">");
#nullable restore
#line 76 "C:\Users\admin\Desktop\basqa final project back\Justica2\Justica2\Views\NewsDetail\Index.cshtml"
                                       Write(item.Tag.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n");
#nullable restore
#line 77 "C:\Users\admin\Desktop\basqa final project back\Justica2\Justica2\Views\NewsDetail\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </ul>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</section>\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<VmNewsDetail> Html { get; private set; }
    }
}
#pragma warning restore 1591
