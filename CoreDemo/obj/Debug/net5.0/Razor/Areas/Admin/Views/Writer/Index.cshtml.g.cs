#pragma checksum "C:\Users\HefaLab\Documents\GitHub\Blog-App-NetCore\CoreDemo\Areas\Admin\Views\Writer\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0c4d4f3b454c14dadafb0aa4f6fd21b75f5e6506"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Writer_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Writer/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0c4d4f3b454c14dadafb0aa4f6fd21b75f5e6506", @"/Areas/Admin/Views/Writer/Index.cshtml")]
    #nullable restore
    public class Areas_Admin_Views_Writer_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\HefaLab\Documents\GitHub\Blog-App-NetCore\CoreDemo\Areas\Admin\Views\Writer\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>Yazar Ajax İşlemleri</h1>
<br />
<button type=""button"" id =""btngetlist"" class=""btn btn-outline-primary""> Yazar Listesi </button>
<button type=""button"" id =""btngetbyid"" class=""btn btn-outline-success""> Yazar Getir </button>
<button type=""button"" id =""btnaddwriter"" class=""btn btn-outline-info""> Yazar Ekle </button>
<button type=""button"" id =""btndeletewriter"" class=""btn btn-outline-danger""> Yazar Sil </button>
<button type=""button"" id =""btnupdatewriter"" class=""btn btn-outline-danger""> Yazar Güncelle </button>


<br /> <br />

<div id=""writerlist"">
    Buraya yazarlar gelecek
</div>
<br />

<div id=""writerget"">
    Buraya yazarlar gelecek
</div>
<br />

<div>
    <input type=""text"" id=""writerid"" placeholder=""Yazar id değerini gir"" class=""form-control""  />
</div>
<br />
<div>
 <input type=""text"" id=""txtwriterid"" placeholder=""Yazar ID"" class=""form-control"" />
  <input type=""text"" id=""txtwritername"" placeholder=""Yazar Name"" class=""form-control"" />
</div>
<br />
<div>
    <input t");
            WriteLiteral(@"ype=""text"" id=""txtid"" placeholder=""Silinecek id değerini gir"" class=""form-control""  />
</div>
<br />
<div>
    <input type=""text"" id=""txtid1"" placeholder=""Güncellenecek id değerini gir"" class=""form-control""  />
    <input type=""text"" id=""txtwritername1"" placeholder=""Yazar Name"" class=""form-control""  />
</div>
<br />
");
            DefineSection("scripts", async() => {
                WriteLiteral(@"
    <script>
        $(""#btngetlist"").click(function () {
            $.ajax({
                contentType: ""application/json"",
                dataType: ""json"",
                type: ""Get"",
                url: ""/Admin/Writer/WriterList/"",
                success: function (func) {
                    let w = jQuery.parseJSON(func);
                    console.log(w);
                    let tablehtml = ""<div class='ibox-title'><h5>Yazar Listesi</h5></div><div class='ibox-content'><table class='table'><thead><tr><th> Yazar ID</th> <th> Yazar Adı </th></tr></thead>"";
                    $.each(w, (index, value) => {
                        tablehtml += `<tr><td>${value.Id}</td> <td>${value.Name}</td></tr>`
                    });
                    tablehtml += ""</table></div>"";
                    $(""#writerlist"").html(tablehtml);
                }
            });
        });

        $(""#btngetbyid"").click(x =>{
            let id2 = $(""#writerid"").val();
            console.log(id2");
                WriteLiteral(@");
            $.ajax({
                contentType: ""application/json"",
                dataType: ""json"",
                type: ""Get"",
                data:{id:id2},
                url: ""/Admin/Writer/GetWriterByID/"",
                
                success: function (func) {
                    let w = jQuery.parseJSON(func);
                    console.log(w);
                    let tablehtml = `<div class='ibox-title'><h5>Yazar ID</h5></div><div class='ibox-content'><table class='table'><thead><tr><th> Yazar ID</th> <th> Yazar Adı </th></tr> <tr><td>${w.Id}</td> <td>${w.Name}</td></tr></table>`;
                    $(""#writerget"").html(tablehtml);
                  
                }
            });
        });

        $(""#btnaddwriter"").click(x =>{
            let writer ={
                Id: $(""#txtwriterid"").val(),
                Name: $(""#txtwritername"").val(),
            };

            $.ajax({
                type: ""Post"",
                data:writer,
             ");
                WriteLiteral(@"   url: ""/Admin/Writer/AddWriter/"",
                success: function (func) {
                    let w = jQuery.parseJSON(func);
                    console.log(func);
                    alert(""Yazar eklendi"");
                  
                }
            });
        });

        $(""#btndeletewriter"").click(x =>{
            let id =$(""#txtid"").val();
            
            $.ajax({
                type: ""Post"",
                dataType: ""json"", 
                url: ""/Admin/Writer/DeleteWriter/""+id,
                success: function (func) {
                 alert(""yazar silindi"");
                  
                }
            });
        });
        
         $(""#btnupdatewriter"").click(x =>{
            let writer ={
                Id: $(""#txtid1"").val(),
                Name: $(""#txtwritername1"").val(),
            };

            $.ajax({
                type: ""Post"",
                data:writer,
                url: ""/Admin/Writer/UpdateWriter/"",
          ");
                WriteLiteral(@"      success: function (func) {
                    let w = jQuery.parseJSON(func);
                    console.log(func);
                    alert(""Yazar Güncellendi"");
                  
                }
            });
        });

     </script>
");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591