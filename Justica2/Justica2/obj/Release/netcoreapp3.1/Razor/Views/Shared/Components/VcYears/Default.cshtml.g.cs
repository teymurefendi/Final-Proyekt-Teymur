#pragma checksum "C:\Users\admin\Desktop\basqa final project back\Justica2\Justica2\Views\Shared\Components\VcYears\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "af4c417146b62b493160adeeff77f738b5f7f51f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_VcYears_Default), @"mvc.1.0.view", @"/Views/Shared/Components/VcYears/Default.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"af4c417146b62b493160adeeff77f738b5f7f51f", @"/Views/Shared/Components/VcYears/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c5ae762b0e2273a956ec2135f0d93291378d051e", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_VcYears_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Experience>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\admin\Desktop\basqa final project back\Justica2\Justica2\Views\Shared\Components\VcYears\Default.cshtml"
  
    Layout = null;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\admin\Desktop\basqa final project back\Justica2\Justica2\Views\Shared\Components\VcYears\Default.cshtml"
 if (ViewBag.Active == "Contact")
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <section id=\"years\">\r\n        <div class=\"container\">\r\n            <div class=\"row\">\r\n                <div class=\"col-lg-4 col-md-12\">\r\n                    <div class=\"count-twenty\">\r\n                        <h3 id=\"7\" class=\'counter\' data-number=\'");
#nullable restore
#line 12 "C:\Users\admin\Desktop\basqa final project back\Justica2\Justica2\Views\Shared\Components\VcYears\Default.cshtml"
                                                           Write(Model.Year);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"' data-speed='100' data-step='1'>20</h3>
                        <span>Years of Experience</span>
                    </div>
                </div>
                <div class=""col-lg-4 p-lg-5 mb-sm-30"">
                    <span id=""title-well"">Welcome</span><br>
                    <h2>");
#nullable restore
#line 18 "C:\Users\admin\Desktop\basqa final project back\Justica2\Justica2\Views\Shared\Components\VcYears\Default.cshtml"
                   Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n                </div>\r\n                <div class=\"col-lg-4\">\r\n                    <p>\r\n                        ");
#nullable restore
#line 22 "C:\Users\admin\Desktop\basqa final project back\Justica2\Justica2\Views\Shared\Components\VcYears\Default.cshtml"
                   Write(Model.Text);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </p>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </section>\r\n");
#nullable restore
#line 28 "C:\Users\admin\Desktop\basqa final project back\Justica2\Justica2\Views\Shared\Components\VcYears\Default.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <section id=\"years\">\r\n        <div class=\"container\">\r\n            <div class=\"row\">\r\n                <div class=\"col-lg-4 col-md-12\">\r\n                    <div class=\"count-twenty\">\r\n                        <h3 id=\"7\" class=\'counter\' data-number=\'");
#nullable restore
#line 36 "C:\Users\admin\Desktop\basqa final project back\Justica2\Justica2\Views\Shared\Components\VcYears\Default.cshtml"
                                                           Write(Model.Year);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"' data-speed='100' data-step='1'>0</h3>
                        <span>Years of Experience</span>
                    </div>
                </div>
                <div class=""col-lg-4 p-lg-5 mb-sm-30"">
                    <span id=""title-well"">Welcome</span><br>
                    <h2>");
#nullable restore
#line 42 "C:\Users\admin\Desktop\basqa final project back\Justica2\Justica2\Views\Shared\Components\VcYears\Default.cshtml"
                   Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n                </div>\r\n                <div class=\"col-lg-4\">\r\n                    <p>\r\n                        ");
#nullable restore
#line 46 "C:\Users\admin\Desktop\basqa final project back\Justica2\Justica2\Views\Shared\Components\VcYears\Default.cshtml"
                   Write(Model.Text);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </p>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </section>\r\n");
#nullable restore
#line 52 "C:\Users\admin\Desktop\basqa final project back\Justica2\Justica2\Views\Shared\Components\VcYears\Default.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Experience> Html { get; private set; }
    }
}
#pragma warning restore 1591