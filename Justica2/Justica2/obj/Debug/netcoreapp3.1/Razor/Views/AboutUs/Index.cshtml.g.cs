#pragma checksum "C:\Users\admin\Desktop\basqa final project back\Justica2\Justica2\Views\AboutUs\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4a42ad172d01388fa8c4967f3c5c9c0f1b1c85fb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_AboutUs_Index), @"mvc.1.0.view", @"/Views/AboutUs/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4a42ad172d01388fa8c4967f3c5c9c0f1b1c85fb", @"/Views/AboutUs/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c5ae762b0e2273a956ec2135f0d93291378d051e", @"/Views/_ViewImports.cshtml")]
    public class Views_AboutUs_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<VmAbout>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("small-img"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("big-img"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\admin\Desktop\basqa final project back\Justica2\Justica2\Views\AboutUs\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 6 "C:\Users\admin\Desktop\basqa final project back\Justica2\Justica2\Views\AboutUs\Index.cshtml"
Write(await Component.InvokeAsync("VcSubheader", new { PageName = "About Us" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<section id=\"partner\">\r\n    <div class=\"container\">\r\n        <div class=\"row\">\r\n            <div class=\"col-md-5\">\r\n                <span>Who We Are</span><br>\r\n                <h2>");
#nullable restore
#line 12 "C:\Users\admin\Desktop\basqa final project back\Justica2\Justica2\Views\AboutUs\Index.cshtml"
               Write(Model.Legal.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n                <p>");
#nullable restore
#line 13 "C:\Users\admin\Desktop\basqa final project back\Justica2\Justica2\Views\AboutUs\Index.cshtml"
              Write(Model.Legal.Text);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            </div>\r\n            <div class=\"col-md-6 offset-md-1\">\r\n                <div class=\"img-cont\">\r\n                    <div class=\"added-text-cont\">\r\n                        <h1>");
#nullable restore
#line 18 "C:\Users\admin\Desktop\basqa final project back\Justica2\Justica2\Views\AboutUs\Index.cshtml"
                       Write(Model.Legal.Number);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n                        <span>Solved Cases</span>\r\n                    </div>\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "4a42ad172d01388fa8c4967f3c5c9c0f1b1c85fb6372", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 723, "~/dist/img/", 723, 11, true);
#nullable restore
#line 21 "C:\Users\admin\Desktop\basqa final project back\Justica2\Justica2\Views\AboutUs\Index.cshtml"
AddHtmlAttributeValue("", 734, Model.Legal.Img2, 734, 17, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "4a42ad172d01388fa8c4967f3c5c9c0f1b1c85fb8056", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 808, "~/dist/img/", 808, 11, true);
#nullable restore
#line 22 "C:\Users\admin\Desktop\basqa final project back\Justica2\Justica2\Views\AboutUs\Index.cshtml"
AddHtmlAttributeValue("", 819, Model.Legal.Img1, 819, 17, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                </div>
            </div>
        </div>
    </div>
</section>



<section id=""women"" style=""background-color: black;"">
    <div class=""img-container col-md-6""></div>
    <div class=""container"">
        <div class=""row"">
            <div class=""col-md-5 offset-md-7"">
                <span>Features</span><br>
                <h2 style=""color: white;"">
                    ");
#nullable restore
#line 38 "C:\Users\admin\Desktop\basqa final project back\Justica2\Justica2\Views\AboutUs\Index.cshtml"
               Write(Model.Our.Title.Substring(0, 19));

#line default
#line hidden
#nullable disable
            WriteLiteral("<br>\r\n                    ");
#nullable restore
#line 39 "C:\Users\admin\Desktop\basqa final project back\Justica2\Justica2\Views\AboutUs\Index.cshtml"
               Write(Model.Our.Title.Substring(20));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </h2>\r\n                <ul id=\"raptor\">\r\n");
#nullable restore
#line 42 "C:\Users\admin\Desktop\basqa final project back\Justica2\Justica2\Views\AboutUs\Index.cshtml"
                      int i = 1; 

#line default
#line hidden
#nullable disable
#nullable restore
#line 43 "C:\Users\admin\Desktop\basqa final project back\Justica2\Justica2\Views\AboutUs\Index.cshtml"
                     foreach (var item in Model.OurParts)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <li");
            BeginWriteAttribute("class", " class=\"", 1544, "\"", 1586, 2);
            WriteAttributeValue("", 1552, "raptor-li", 1552, 9, true);
#nullable restore
#line 45 "C:\Users\admin\Desktop\basqa final project back\Justica2\Justica2\Views\AboutUs\Index.cshtml"
WriteAttributeValue(" ", 1561, i == 1 ? "active2":"", 1562, 24, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" data-form=\"");
#nullable restore
#line 45 "C:\Users\admin\Desktop\basqa final project back\Justica2\Justica2\Views\AboutUs\Index.cshtml"
                                                                             Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("\"><a");
            BeginWriteAttribute("href", " href=\"", 1605, "\"", 1612, 0);
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 45 "C:\Users\admin\Desktop\basqa final project back\Justica2\Justica2\Views\AboutUs\Index.cshtml"
                                                                                            Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n");
#nullable restore
#line 46 "C:\Users\admin\Desktop\basqa final project back\Justica2\Justica2\Views\AboutUs\Index.cshtml"
                        i++;
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </ul>\r\n                <div class=\"ul-content-cont\">\r\n");
#nullable restore
#line 50 "C:\Users\admin\Desktop\basqa final project back\Justica2\Justica2\Views\AboutUs\Index.cshtml"
                       int j = 1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 51 "C:\Users\admin\Desktop\basqa final project back\Justica2\Justica2\Views\AboutUs\Index.cshtml"
                     foreach (var item in Model.OurParts)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div");
            BeginWriteAttribute("class", " class=\"", 1905, "\"", 1948, 2);
            WriteAttributeValue("", 1913, "li-content", 1913, 10, true);
#nullable restore
#line 53 "C:\Users\admin\Desktop\basqa final project back\Justica2\Justica2\Views\AboutUs\Index.cshtml"
WriteAttributeValue(" ", 1923, j == 1 ? "active3":"", 1924, 24, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("id", " id=\"", 1949, "\"", 1959, 2);
            WriteAttributeValue("", 1954, "li-", 1954, 3, true);
#nullable restore
#line 53 "C:\Users\admin\Desktop\basqa final project back\Justica2\Justica2\Views\AboutUs\Index.cshtml"
WriteAttributeValue("", 1957, j, 1957, 2, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" data-type=\"");
#nullable restore
#line 53 "C:\Users\admin\Desktop\basqa final project back\Justica2\Justica2\Views\AboutUs\Index.cshtml"
                                                                                          Write(j);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">\r\n                            <p>");
#nullable restore
#line 54 "C:\Users\admin\Desktop\basqa final project back\Justica2\Justica2\Views\AboutUs\Index.cshtml"
                          Write(item.Text);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        </div>\r\n");
#nullable restore
#line 56 "C:\Users\admin\Desktop\basqa final project back\Justica2\Justica2\Views\AboutUs\Index.cshtml"
                        j++;
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</section>\r\n");
#nullable restore
#line 63 "C:\Users\admin\Desktop\basqa final project back\Justica2\Justica2\Views\AboutUs\Index.cshtml"
Write(await Component.InvokeAsync("VcTeam"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 65 "C:\Users\admin\Desktop\basqa final project back\Justica2\Justica2\Views\AboutUs\Index.cshtml"
Write(await Component.InvokeAsync("VcYears"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<section id=""investigation"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-lg-4 col-md-6"">
                <div class=""custom-box"">
                    <i class=""fas fa-envelope-open-text little-i""></i>
                    <div class=""cust-text"">
                        <h4>Request Quote</h4>
                        <p>
                            Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem.
                        </p>
                    </div>
                    <i class=""fas fa-envelope-open-text big-i""></i>
                </div>
            </div>
            <div class=""col-lg-4 col-md-6"">
                <div class=""custom-box"">
                    <i class=""fas fa-search little-i""></i>
                    <div class=""cust-text"">
                        <h4>Investigation</h4>
                        <p>
                            Sed ut perspiciatis unde omnis iste natus error");
            WriteLiteral(@" sit voluptatem accusantium doloremque laudantium, totam rem.
                        </p>
                    </div>
                    <i class=""fas fa-search big-i""></i>
                </div>
            </div>
            <div class=""col-lg-4 hidden-md"">
                <div class=""custom-box"">
                    <i class=""far fa-hand-rock little-i""></i>
                    <div class=""cust-text"">
                        <h4>Case Fight</h4>
                        <p>
                            Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem.
                        </p>
                    </div>
                    <i class=""far fa-hand-rock big-i""></i>
                </div>
            </div>
        </div>
    </div>
</section>



");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<VmAbout> Html { get; private set; }
    }
}
#pragma warning restore 1591
