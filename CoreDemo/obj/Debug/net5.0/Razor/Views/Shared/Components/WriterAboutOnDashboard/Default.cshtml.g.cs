#pragma checksum "C:\Users\HefaLab\Documents\GitHub\Blog-App-NetCore\CoreDemo\Views\Shared\Components\WriterAboutOnDashboard\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a5c8f73d1a235b03d7249425093b984ed37ad07e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_WriterAboutOnDashboard_Default), @"mvc.1.0.view", @"/Views/Shared/Components/WriterAboutOnDashboard/Default.cshtml")]
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
#line 1 "C:\Users\HefaLab\Documents\GitHub\Blog-App-NetCore\CoreDemo\Views\_ViewImports.cshtml"
using CoreDemo;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\HefaLab\Documents\GitHub\Blog-App-NetCore\CoreDemo\Views\_ViewImports.cshtml"
using CoreDemo.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\HefaLab\Documents\GitHub\Blog-App-NetCore\CoreDemo\Views\Shared\Components\WriterAboutOnDashboard\Default.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a5c8f73d1a235b03d7249425093b984ed37ad07e", @"/Views/Shared/Components/WriterAboutOnDashboard/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c0e2cbebe4b7cca4b09168dd159f601192fafdf0", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared_Components_WriterAboutOnDashboard_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Writer>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@" <div class=""row"">
              <div class=""col-12 grid-margin stretch-card"">
                <div class=""card"">
                  <div class=""card-body"">
                    <h4 class=""card-title"">Yazar Hakkında</h4>
                     
                   <h1>");
#nullable restore
#line 9 "C:\Users\HefaLab\Documents\GitHub\Blog-App-NetCore\CoreDemo\Views\Shared\Components\WriterAboutOnDashboard\Default.cshtml"
                  Write(ViewBag.Username);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n                    <div class=\"d-flex mt-5 align-items-top\">\r\n");
#nullable restore
#line 11 "C:\Users\HefaLab\Documents\GitHub\Blog-App-NetCore\CoreDemo\Views\Shared\Components\WriterAboutOnDashboard\Default.cshtml"
                         foreach (var item in Model)
                       {

#line default
#line hidden
#nullable disable
            WriteLiteral("                              <img");
            BeginWriteAttribute("src", " src=\"", 519, "\"", 542, 1);
#nullable restore
#line 13 "C:\Users\HefaLab\Documents\GitHub\Blog-App-NetCore\CoreDemo\Views\Shared\Components\WriterAboutOnDashboard\Default.cshtml"
WriteAttributeValue("", 525, item.WriterImage, 525, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"img-sm rounded-circle mr-3\" alt=\"image\">\r\n                      <div class=\"mb-0 flex-grow\">\r\n                        <h5 class=\"mr-2 mb-2\">");
#nullable restore
#line 15 "C:\Users\HefaLab\Documents\GitHub\Blog-App-NetCore\CoreDemo\Views\Shared\Components\WriterAboutOnDashboard\Default.cshtml"
                                         Write(item.WriterName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" - ");
#nullable restore
#line 15 "C:\Users\HefaLab\Documents\GitHub\Blog-App-NetCore\CoreDemo\Views\Shared\Components\WriterAboutOnDashboard\Default.cshtml"
                                                            Write(item.WriterMail);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                        <p class=\"mb-0 font-weight-light\">");
#nullable restore
#line 16 "C:\Users\HefaLab\Documents\GitHub\Blog-App-NetCore\CoreDemo\Views\Shared\Components\WriterAboutOnDashboard\Default.cshtml"
                                                     Write(item.WriterAbout);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                      </div>\n");
#nullable restore
#line 18 "C:\Users\HefaLab\Documents\GitHub\Blog-App-NetCore\CoreDemo\Views\Shared\Components\WriterAboutOnDashboard\Default.cshtml"
                       }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                   
                      <div class=""ml-auto"">
                        <i class=""mdi mdi-heart-outline text-muted""></i>
                      </div>
                    </div>
                  </div>
                </div>
              </div>
            </div>");
        }
        #pragma warning restore 1998
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Writer>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
