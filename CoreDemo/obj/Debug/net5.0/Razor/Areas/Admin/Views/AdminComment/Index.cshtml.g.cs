#pragma checksum "C:\Users\HefaLab\Documents\GitHub\Blog-App-NetCore\CoreDemo\Areas\Admin\Views\AdminComment\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4fa18967f432803bd8f25d99fca108add3e8ae47"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_AdminComment_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/AdminComment/Index.cshtml")]
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
#line 1 "C:\Users\HefaLab\Documents\GitHub\Blog-App-NetCore\CoreDemo\Areas\Admin\Views\AdminComment\Index.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4fa18967f432803bd8f25d99fca108add3e8ae47", @"/Areas/Admin/Views/AdminComment/Index.cshtml")]
    #nullable restore
    public class Areas_Admin_Views_AdminComment_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Comment>>
    #nullable disable
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\HefaLab\Documents\GitHub\Blog-App-NetCore\CoreDemo\Areas\Admin\Views\AdminComment\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!DOCTYPE html>\r\n<html>\r\n\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4fa18967f432803bd8f25d99fca108add3e8ae473221", async() => {
                WriteLiteral(@"

        <div class=""wrapper wrapper-content animated fadeInRight"">
           <div class=""row"">
                <div class=""col-lg-12"">
                <div class=""ibox "">
                    <div class=""ibox-title"">
                        <h5>Yorumlar </h5>
                        <div class=""ibox-tools"">
                            <a class=""collapse-link"">
                                <i class=""fa fa-chevron-up""></i>
                            </a>
                            <a class=""dropdown-toggle"" data-toggle=""dropdown"" href=""#"">
                                <i class=""fa fa-wrench""></i>
                            </a>
                            <ul class=""dropdown-menu dropdown-user"">
                                <li><a href=""#"" class=""dropdown-item"">Config option 1</a>
                                </li>
                                <li><a href=""#"" class=""dropdown-item"">Config option 2</a>
                                </li>
                            </ul>");
                WriteLiteral(@"
                            <a class=""close-link"">
                                <i class=""fa fa-times""></i>
                            </a>
                        </div>
                    </div>
                    <div class=""ibox-content"">

                        <table class=""table table-striped"">
                            <thead>
                            <tr>
                                <th>#</th>
                                <th>Yazar</th>
                                <th>Başlık</th>
                                <th>Blog</th>
                                <th>Puan</th>
                                <th>Tarih</th>
                            </tr>
                            </thead>
                            <tbody>
");
#nullable restore
#line 52 "C:\Users\HefaLab\Documents\GitHub\Blog-App-NetCore\CoreDemo\Areas\Admin\Views\AdminComment\Index.cshtml"
                         foreach (var item in Model)
                       {

#line default
#line hidden
#nullable disable
                WriteLiteral("                            <tr>\r\n                                <td>");
#nullable restore
#line 55 "C:\Users\HefaLab\Documents\GitHub\Blog-App-NetCore\CoreDemo\Areas\Admin\Views\AdminComment\Index.cshtml"
                               Write(item.CommentID);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 56 "C:\Users\HefaLab\Documents\GitHub\Blog-App-NetCore\CoreDemo\Areas\Admin\Views\AdminComment\Index.cshtml"
                               Write(item.CommentUserName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 57 "C:\Users\HefaLab\Documents\GitHub\Blog-App-NetCore\CoreDemo\Areas\Admin\Views\AdminComment\Index.cshtml"
                               Write(item.CommentTitle);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 58 "C:\Users\HefaLab\Documents\GitHub\Blog-App-NetCore\CoreDemo\Areas\Admin\Views\AdminComment\Index.cshtml"
                               Write(item.Blog.BlogTitle);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                \r\n                            </tr>\n");
#nullable restore
#line 61 "C:\Users\HefaLab\Documents\GitHub\Blog-App-NetCore\CoreDemo\Areas\Admin\Views\AdminComment\Index.cshtml"
                       }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                           
                            </tbody>
                        </table>
                    </div>
                </div>
            </div>
           </div>
           
        
        
        </div>
          
       




");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n</html>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Comment>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
