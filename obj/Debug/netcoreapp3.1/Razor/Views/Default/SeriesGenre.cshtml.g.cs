#pragma checksum "C:\Users\PC\Desktop\Proje\MovieApp\Views\Default\SeriesGenre.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c7b7c8b693a5ceb82f069e2db37a61ef745555c7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Default_SeriesGenre), @"mvc.1.0.view", @"/Views/Default/SeriesGenre.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c7b7c8b693a5ceb82f069e2db37a61ef745555c7", @"/Views/Default/SeriesGenre.cshtml")]
    public class Views_Default_SeriesGenre : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<MovieApp.Models.ViewModels.SeriesViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "C:\Users\PC\Desktop\Proje\MovieApp\Views\Default\SeriesGenre.cshtml"
   ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml"; 

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<!-- page title -->
<section class=""section section--first section--bg"" data-bg=""img/section/section.jpg"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-12"">
                <div class=""section__wrap"">
                    <!-- section title -->
                    <h2 class=""section__title"">Dizi Katoloğu</h2>
                    <!-- end section title -->
                    <!-- breadcrumb -->
                    <ul class=""breadcrumb"">
                        <li class=""breadcrumb__item""><a href=""/Default/Index"">Ana Sayfa</a></li>
                        <li class=""breadcrumb__item""><a href=""/Default/Series"">Diziler</a></li>
                        <li class=""breadcrumb__item breadcrumb__item--active"">Tür</li>
                    </ul>
                    <!-- end breadcrumb -->
                </div>
            </div>
        </div>
    </div>
</section>
<!-- end page title -->
<!-- filter -->
<div class=""filter"">
    <div class=""container"">
        <div class=""row"">
 ");
            WriteLiteral(@"           <div class=""col-12"">
                <div class=""filter__content"">
                    <div class=""filter__items"">
                        <!-- filter item -->
                        <div class=""filter__item"" id=""filter__genre"">
                            <span class=""filter__item-label"">TÜR:</span>

                            <div class=""filter__item-btn dropdown-toggle"" role=""navigation"" id=""filter-genre"" data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false"">
                                <input type=""button"" value=""Tür Seç"">
                                <span></span>
                            </div>

                            <ul class=""filter__item-menu dropdown-menu scrollbar-dropdown"" aria-labelledby=""filter-genre"">

                                <!-- genre list -->
                                ");
#nullable restore
#line 47 "C:\Users\PC\Desktop\Proje\MovieApp\Views\Default\SeriesGenre.cshtml"
                           Write(await Component.InvokeAsync("SeriesGenreGetList"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

                            </ul>
                        </div>
                        <!-- end filter item -->
                        <!-- filter item -->
                        <div class=""filter__item"" id=""filter__quality"">
                            <span class=""filter__item-label"">IMDB:</span>

                            <div class=""filter__item-btn dropdown-toggle"" role=""navigation"" id=""filter-quality"" data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false"">
                                <input type=""button"" value=""Puanlar"">
                                <span></span>
                            </div>

                            <ul class=""filter__item-menu dropdown-menu scrollbar-dropdown"" aria-labelledby=""filter-quality"">
                                <li><a href=""/SeriesImdbFiltre/ImdbOne"">0,0 - 2,5</a></li>
                                <li><a href=""/SeriesImdbFiltre/ImdbTwo"">2,5 - 5,0</a></li>
                                <li><a href=""/SeriesImdbFiltre/ImdbThree"">5,0 ");
            WriteLiteral(@"- 7,5</a></li>
                                <li><a href=""/SeriesImdbFiltre/ImdbFour"">7,5 - 10,0</a></li>
                            </ul>
                        </div>
                        <!-- end filter item -->
                        <!-- filter item -->
                        <div class=""filter__item"" id=""filter__rate"">

");
#nullable restore
#line 72 "C:\Users\PC\Desktop\Proje\MovieApp\Views\Default\SeriesGenre.cshtml"
                             using (Html.BeginForm())
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div>\n                        ");
#nullable restore
#line 75 "C:\Users\PC\Desktop\Proje\MovieApp\Views\Default\SeriesGenre.cshtml"
                   Write(Html.TextBox("search", null, new { @class = "form-control-search", @placeholder = "Dizi adı ile ara.." }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    </div>");
#nullable restore
#line 76 "C:\Users\PC\Desktop\Proje\MovieApp\Views\Default\SeriesGenre.cshtml"
                          }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        </div>
                        <!-- end filter item -->
                    </div>
                    <!-- filter btn -->
					<button class=""filter__btn"" onclick=""document.location='/default/series'"" >Filtreyi Temizle</button>
					<!-- end filter btn -->
                </div>
            </div>
        </div>
    </div>
</div>
<!-- end filter -->
<!-- catalog -->
<div class=""catalog"">
    <div class=""container"">
        <div class=""row"">
            <!-- card -->
            <!-- türe göre listeleme -->
");
#nullable restore
#line 95 "C:\Users\PC\Desktop\Proje\MovieApp\Views\Default\SeriesGenre.cshtml"
             foreach (var item in Model)
            {
                if (item.Genre.GenreId == ViewBag.x)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"col-6 col-sm-4 col-lg-3 col-xl-2\">\n                        <div class=\"card\">\n                            <div class=\"card__cover\">\n                                <img id=\"images\"");
            BeginWriteAttribute("src", " src=\"", 4575, "\"", 4595, 1);
#nullable restore
#line 102 "C:\Users\PC\Desktop\Proje\MovieApp\Views\Default\SeriesGenre.cshtml"
WriteAttributeValue("", 4581, item.ImageURL, 4581, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 4596, "\"", 4602, 0);
            EndWriteAttribute();
            WriteLiteral(">\n                                <a");
            BeginWriteAttribute("href", " href=\"", 4639, "\"", 4677, 2);
            WriteAttributeValue("", 4646, "/Default/SeriesDetails/", 4646, 23, true);
#nullable restore
#line 103 "C:\Users\PC\Desktop\Proje\MovieApp\Views\Default\SeriesGenre.cshtml"
WriteAttributeValue("", 4669, item.Id, 4669, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""card__play"">
                                    <i class=""icon ion-ios-play""></i>
                                </a>
                            </div>
                            <div class=""card__content"">
                                <h3 class=""card__title""><a");
            BeginWriteAttribute("href", " href=\"", 4955, "\"", 4993, 2);
            WriteAttributeValue("", 4962, "/Default/SeriesDetails/", 4962, 23, true);
#nullable restore
#line 108 "C:\Users\PC\Desktop\Proje\MovieApp\Views\Default\SeriesGenre.cshtml"
WriteAttributeValue("", 4985, item.Id, 4985, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 108 "C:\Users\PC\Desktop\Proje\MovieApp\Views\Default\SeriesGenre.cshtml"
                                                                                             Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></h3>\n                                <span class=\"card__category\">\n                                    <a");
            BeginWriteAttribute("href", " href=\"", 5115, "\"", 5162, 2);
            WriteAttributeValue("", 5122, "/Default/SeriesGenre/", 5122, 21, true);
#nullable restore
#line 110 "C:\Users\PC\Desktop\Proje\MovieApp\Views\Default\SeriesGenre.cshtml"
WriteAttributeValue("", 5143, item.Genre.GenreId, 5143, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 110 "C:\Users\PC\Desktop\Proje\MovieApp\Views\Default\SeriesGenre.cshtml"
                                                                                  Write(item.Genre.GenreName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\n                                </span>\n                                <ul class=\"card__list\" id=\"rate\">\n                                    <li>IMDB :  ");
#nullable restore
#line 113 "C:\Users\PC\Desktop\Proje\MovieApp\Views\Default\SeriesGenre.cshtml"
                                           Write(item.Rating);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\n                                </ul>\n                            </div>\n                        </div>\n                    </div>\n");
#nullable restore
#line 118 "C:\Users\PC\Desktop\Proje\MovieApp\Views\Default\SeriesGenre.cshtml"
                }
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("            <!-- end card -->\n        </div>\n    </div>\n</div>\n<!-- end catalog -->");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<MovieApp.Models.ViewModels.SeriesViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591