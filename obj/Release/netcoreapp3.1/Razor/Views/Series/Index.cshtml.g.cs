#pragma checksum "C:\Users\PC\Desktop\Proje\MovieApp\Views\Series\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "57dd37425440ab93c4f42b49c429c8fa77fa893e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Series_Index), @"mvc.1.0.view", @"/Views/Series/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"57dd37425440ab93c4f42b49c429c8fa77fa893e", @"/Views/Series/Index.cshtml")]
    public class Views_Series_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<MovieApp.Models.ViewModels.SeriesViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\PC\Desktop\Proje\MovieApp\Views\Series\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_LayoutAdmin.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<title>Dizi Listesi</title>
<a style=""float:left; font-size:inherit; color:#36b9bf;"" href=""/Series/SeriesAdd"">▹Dizi Ekle</a>
<table class=""table"">
    <thead>
        <tr>
            <th> Id </th>
            <th> Adı </th>
            <th> Türü </th>
            <th> Çıkış Yılı </th>
            <th> Sezon </th>
            <th> Durum </th>
            <th> Puan </th>
            <th> Kitle </th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 22 "C:\Users\PC\Desktop\Proje\MovieApp\Views\Series\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td> ");
#nullable restore
#line 25 "C:\Users\PC\Desktop\Proje\MovieApp\Views\Series\Index.cshtml"
                Write(Html.DisplayFor(modelItem => item.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                <td> ");
#nullable restore
#line 26 "C:\Users\PC\Desktop\Proje\MovieApp\Views\Series\Index.cshtml"
                Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                <td> ");
#nullable restore
#line 27 "C:\Users\PC\Desktop\Proje\MovieApp\Views\Series\Index.cshtml"
                Write(Html.DisplayFor(modelItem => item.Genre.GenreName));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td> ");
#nullable restore
#line 28 "C:\Users\PC\Desktop\Proje\MovieApp\Views\Series\Index.cshtml"
                Write(Html.DisplayFor(modelItem => item.ReleaseYear));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                <td> ");
#nullable restore
#line 29 "C:\Users\PC\Desktop\Proje\MovieApp\Views\Series\Index.cshtml"
                Write(Html.DisplayFor(modelItem => item.Season));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                <td> ");
#nullable restore
#line 30 "C:\Users\PC\Desktop\Proje\MovieApp\Views\Series\Index.cshtml"
                Write(Html.DisplayFor(modelItem => item.Status));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                <td> ");
#nullable restore
#line 31 "C:\Users\PC\Desktop\Proje\MovieApp\Views\Series\Index.cshtml"
                Write(Html.DisplayFor(modelItem => item.Rating));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                <td> ");
#nullable restore
#line 32 "C:\Users\PC\Desktop\Proje\MovieApp\Views\Series\Index.cshtml"
                Write(Html.DisplayFor(modelItem => item.AgeRestriction));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n\r\n                <td>");
#nullable restore
#line 34 "C:\Users\PC\Desktop\Proje\MovieApp\Views\Series\Index.cshtml"
               Write(Html.ActionLink("Detay-Düzenle", "SeriesGet", new { id = item.Id }, new { @class = "btn btn-primary" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n                <td>");
#nullable restore
#line 36 "C:\Users\PC\Desktop\Proje\MovieApp\Views\Series\Index.cshtml"
               Write(Html.ActionLink("Sil", "SeriesRemove", new { id = item.Id }, new { @class = "btn btn-danger", onclick = "return confirm('U Y A R I   |   Kayıt silinmek üzere..');" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n");
#nullable restore
#line 38 "C:\Users\PC\Desktop\Proje\MovieApp\Views\Series\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<MovieApp.Models.ViewModels.SeriesViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591