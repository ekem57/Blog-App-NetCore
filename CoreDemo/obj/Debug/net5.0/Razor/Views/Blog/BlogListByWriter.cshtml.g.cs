#pragma checksum "C:\Users\HefaLab\Documents\GitHub\Blog-App-NetCore\CoreDemo\Views\Blog\BlogListByWriter.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "69e88bc82ca8ec7c76b4c01678251d30b6867dc2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Blog_BlogListByWriter), @"mvc.1.0.view", @"/Views/Blog/BlogListByWriter.cshtml")]
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
#line 1 "C:\Users\HefaLab\Documents\GitHub\Blog-App-NetCore\CoreDemo\Views\Blog\BlogListByWriter.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"69e88bc82ca8ec7c76b4c01678251d30b6867dc2", @"/Views/Blog/BlogListByWriter.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c0e2cbebe4b7cca4b09168dd159f601192fafdf0", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Blog_BlogListByWriter : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Blog>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\HefaLab\Documents\GitHub\Blog-App-NetCore\CoreDemo\Views\Blog\BlogListByWriter.cshtml"
  
    ViewData["Title"] = "BlogListByWriter";
    Layout = "~/Views/Shared/WriterLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>BlogListByWriter</h1>

<table class=""table table-bordered"">
    <tr>
        <td>#</td>
        <td>Blog Başlığı</td>
        <td>Oluşturma Tarihi</td>
        <td>Kategori</td>
        <td>Durum</td>
        <td>Sil</td>
        <td>Düzenle</td>
    </tr>
   

");
#nullable restore
#line 22 "C:\Users\HefaLab\Documents\GitHub\Blog-App-NetCore\CoreDemo\Views\Blog\BlogListByWriter.cshtml"
 foreach (var item in Model)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <tr>\n        <th>");
#nullable restore
#line 25 "C:\Users\HefaLab\Documents\GitHub\Blog-App-NetCore\CoreDemo\Views\Blog\BlogListByWriter.cshtml"
       Write(item.BlogID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\n        <td>");
#nullable restore
#line 26 "C:\Users\HefaLab\Documents\GitHub\Blog-App-NetCore\CoreDemo\Views\Blog\BlogListByWriter.cshtml"
       Write(item.BlogTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n        <td>");
#nullable restore
#line 27 "C:\Users\HefaLab\Documents\GitHub\Blog-App-NetCore\CoreDemo\Views\Blog\BlogListByWriter.cshtml"
       Write(item.BlogCreateDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n        <td>");
#nullable restore
#line 28 "C:\Users\HefaLab\Documents\GitHub\Blog-App-NetCore\CoreDemo\Views\Blog\BlogListByWriter.cshtml"
       Write(item.CategoryId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n        <td>");
#nullable restore
#line 29 "C:\Users\HefaLab\Documents\GitHub\Blog-App-NetCore\CoreDemo\Views\Blog\BlogListByWriter.cshtml"
       Write(item.BlogStatus);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td><a href=\"#\" class=\"btn btn-danger\">Sil</a></td>\r\n        <td><a href=\"#\" class=\"btn btn-warning\">Güncelle</a></td>\r\n\r\n    </tr>\n");
#nullable restore
#line 34 "C:\Users\HefaLab\Documents\GitHub\Blog-App-NetCore\CoreDemo\Views\Blog\BlogListByWriter.cshtml"
   
}

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\r\n<a href=\"#\" class=\"btn btn-info\">Yeni Blog Oluştur</a>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Blog>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
