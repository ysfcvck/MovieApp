#pragma checksum "C:\Users\PC\Desktop\Proje\MovieApp\Views\Default\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f8bec96419790cf4051ce140302bd55da12837d3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Default_Index), @"mvc.1.0.view", @"/Views/Default/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f8bec96419790cf4051ce140302bd55da12837d3", @"/Views/Default/Index.cshtml")]
    public class Views_Default_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MovieApp.Models.ViewModels.MultiViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\PC\Desktop\Proje\MovieApp\Views\Default\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<!-- home -->
<section class=""home"">
    <!-- home bg -->
    <div class=""owl-carousel home__bg"">
        <div class=""item home__cover"" style=""background:url(https://wallpapershome.com/images/pages/pic_h/21130.jpg)""></div>
        <div class=""item home__cover"" style=""background:url(https://wallpapershome.com/images/pages/pic_h/22520.jpg)""></div>
        <div class=""item home__cover"" style=""background:url(https://wallpapershome.com/images/pages/pic_h/17889.jpg)""></div>
        <div class=""item home__cover"" style=""background:url(https://wallpapershome.com/images/pages/pic_h/22167.jpg)""></div>
    </div>
    <!-- end home bg -->
    <div class=""container"">
        <div class=""row"">
            <div class=""col-12"">
                <h1 class=""home__title""><b>SON</b> EKLENENLER </h1>

                <button class=""home__nav home__nav--prev"" type=""button"">
                    <i class=""icon ion-ios-arrow-round-back""></i>
                </button>
                <button class=""home__nav home__na");
            WriteLiteral(@"v--next"" type=""button"">
                    <i class=""icon ion-ios-arrow-round-forward""></i>
                </button>
            </div>

            <div class=""col-12"">
                <div class=""owl-carousel home__carousel"">

                    <!-- Son eklenen 6 film -->
");
#nullable restore
#line 34 "C:\Users\PC\Desktop\Proje\MovieApp\Views\Default\Index.cshtml"
                     foreach (var item in Model.movieViewModels.Reverse().Take(6))
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"item\">\r\n                            <div class=\"card card--big\">\r\n                                <div class=\"card__cover\">\r\n                                    <img id=\"bigImages\"");
            BeginWriteAttribute("src", " src=\"", 1773, "\"", 1793, 1);
#nullable restore
#line 39 "C:\Users\PC\Desktop\Proje\MovieApp\Views\Default\Index.cshtml"
WriteAttributeValue("", 1779, item.ImageURL, 1779, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 1794, "\"", 1800, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                    <a");
            BeginWriteAttribute("href", " href=\"", 1842, "\"", 1879, 2);
            WriteAttributeValue("", 1849, "/Default/MovieDetails/", 1849, 22, true);
#nullable restore
#line 40 "C:\Users\PC\Desktop\Proje\MovieApp\Views\Default\Index.cshtml"
WriteAttributeValue("", 1871, item.Id, 1871, 8, false);

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
            BeginWriteAttribute("href", " href=\"", 2182, "\"", 2219, 2);
            WriteAttributeValue("", 2189, "/Default/MovieDetails/", 2189, 22, true);
#nullable restore
#line 45 "C:\Users\PC\Desktop\Proje\MovieApp\Views\Default\Index.cshtml"
WriteAttributeValue("", 2211, item.Id, 2211, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 45 "C:\Users\PC\Desktop\Proje\MovieApp\Views\Default\Index.cshtml"
                                                                                                Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></h3>\r\n                                    <span class=\"card__category\">\r\n                                        <a");
            BeginWriteAttribute("href", " href=\"", 2351, "\"", 2398, 2);
            WriteAttributeValue("", 2358, "/Default/MoviesGenre/", 2358, 21, true);
#nullable restore
#line 47 "C:\Users\PC\Desktop\Proje\MovieApp\Views\Default\Index.cshtml"
WriteAttributeValue("", 2379, item.Genre.GenreId, 2379, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 47 "C:\Users\PC\Desktop\Proje\MovieApp\Views\Default\Index.cshtml"
                                                                                      Write(item.Genre.GenreName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                                    </span>\r\n                                    <ul class=\"card__list\" id=\"rate\">\r\n                                        <li>IMDB :  ");
#nullable restore
#line 50 "C:\Users\PC\Desktop\Proje\MovieApp\Views\Default\Index.cshtml"
                                               Write(item.Rating);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                                    </ul>\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n");
#nullable restore
#line 55 "C:\Users\PC\Desktop\Proje\MovieApp\Views\Default\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    <!-- Son eklenen 6 dizi -->\r\n");
#nullable restore
#line 58 "C:\Users\PC\Desktop\Proje\MovieApp\Views\Default\Index.cshtml"
                     foreach (var item in Model.seriesViewModels.Reverse().Take(6))
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"item\">\r\n                            <div class=\"card card--big\">\r\n                                <div class=\"card__cover\">\r\n                                    <img id=\"bigImages\"");
            BeginWriteAttribute("src", " src=\"", 3163, "\"", 3183, 1);
#nullable restore
#line 63 "C:\Users\PC\Desktop\Proje\MovieApp\Views\Default\Index.cshtml"
WriteAttributeValue("", 3169, item.ImageURL, 3169, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 3184, "\"", 3190, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                    <a");
            BeginWriteAttribute("href", " href=\"", 3232, "\"", 3270, 2);
            WriteAttributeValue("", 3239, "/Default/SeriesDetails/", 3239, 23, true);
#nullable restore
#line 64 "C:\Users\PC\Desktop\Proje\MovieApp\Views\Default\Index.cshtml"
WriteAttributeValue("", 3262, item.Id, 3262, 8, false);

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
            BeginWriteAttribute("href", " href=\"", 3573, "\"", 3611, 2);
            WriteAttributeValue("", 3580, "/Default/SeriesDetails/", 3580, 23, true);
#nullable restore
#line 69 "C:\Users\PC\Desktop\Proje\MovieApp\Views\Default\Index.cshtml"
WriteAttributeValue("", 3603, item.Id, 3603, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 69 "C:\Users\PC\Desktop\Proje\MovieApp\Views\Default\Index.cshtml"
                                                                                                 Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></h3>\r\n                                    <span class=\"card__category\">\r\n                                        <a");
            BeginWriteAttribute("href", " href=\"", 3743, "\"", 3790, 2);
            WriteAttributeValue("", 3750, "/Default/SeriesGenre/", 3750, 21, true);
#nullable restore
#line 71 "C:\Users\PC\Desktop\Proje\MovieApp\Views\Default\Index.cshtml"
WriteAttributeValue("", 3771, item.Genre.GenreId, 3771, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 71 "C:\Users\PC\Desktop\Proje\MovieApp\Views\Default\Index.cshtml"
                                                                                      Write(item.Genre.GenreName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                                    </span>\r\n                                    <ul class=\"card__list\" id=\"rate\">\r\n                                        <li>IMDB :  ");
#nullable restore
#line 74 "C:\Users\PC\Desktop\Proje\MovieApp\Views\Default\Index.cshtml"
                                               Write(item.Rating);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                                    </ul>\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n");
#nullable restore
#line 79 "C:\Users\PC\Desktop\Proje\MovieApp\Views\Default\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                </div>
            </div>
        </div>
    </div>
</section>
<!-- end home -->
<!-- content -->
<section class=""content"">
    <div class=""content__head"">
        <div class=""container"">
            <div class=""row"">
                <div class=""col-12"">
                    <h2 class=""content__title"">Son Eklenen 12 ????erik</h2>
                    <!-- content tabs nav -->
                    <ul class=""nav nav-tabs content__tabs"" id=""content__tabs"" role=""tablist"">
                        <li class=""nav-item"">
                            <a class=""nav-link active"" data-toggle=""tab"" href=""#tab-1"" role=""tab"" aria-controls=""tab-1"" aria-selected=""true"">T??m??</a>
                        </li>

                        <li class=""nav-item"">
                            <a class=""nav-link"" data-toggle=""tab"" href=""#tab-2"" role=""tab"" aria-controls=""tab-2"" aria-selected=""false"">Film</a>
                        </li>

                        <li class=""nav-item"">
                     ");
            WriteLiteral(@"       <a class=""nav-link"" data-toggle=""tab"" href=""#tab-3"" role=""tab"" aria-controls=""tab-3"" aria-selected=""false"">Dizi</a>
                        </li>

                    </ul>
                    <!-- end content tabs nav -->
                    <!-- content mobile tabs nav -->
                    <div class=""content__mobile-tabs"" id=""content__mobile-tabs"">
                        <div class=""content__mobile-tabs-btn dropdown-toggle"" role=""navigation"" id=""mobile-tabs"" data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false"">
                            <input type=""button"" value=""New items"">
                            <span></span>
                        </div>

                        <div class=""content__mobile-tabs-menu dropdown-menu"" aria-labelledby=""mobile-tabs"">
                            <ul class=""nav nav-tabs"" role=""tablist"">
                                <li class=""nav-item""><a class=""nav-link active"" id=""1-tab"" data-toggle=""tab"" href=""#tab-1"" role=""tab"" aria-controls");
            WriteLiteral(@"=""tab-1"" aria-selected=""true"">T??m??</a></li>

                                <li class=""nav-item""><a class=""nav-link"" id=""2-tab"" data-toggle=""tab"" href=""#tab-2"" role=""tab"" aria-controls=""tab-2"" aria-selected=""false"">Film</a></li>

                                <li class=""nav-item""><a class=""nav-link"" id=""3-tab"" data-toggle=""tab"" href=""#tab-3"" role=""tab"" aria-controls=""tab-3"" aria-selected=""false"">Dizi</a></li>

                            </ul>
                        </div>
                    </div>
                    <!-- end content mobile tabs nav -->
                </div>
            </div>
        </div>
    </div>

    <div class=""container"">
        <!-- content tabs -->
        <div class=""tab-content"" id=""myTabContent"">
            <div class=""tab-pane fade show active"" id=""tab-1"" role=""tabpanel"" aria-labelledby=""1-tab"">
                <div class=""row"">
                    <!-- card -->
                    <!-- Son eklenen 6 film -->
");
#nullable restore
#line 140 "C:\Users\PC\Desktop\Proje\MovieApp\Views\Default\Index.cshtml"
                     foreach (var item in Model.movieViewModels.Reverse().Take(6))
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        <div class=""col-6 col-sm-12 col-lg-6"">
                            <div class=""card card--list"">
                                <div class=""row"">
                                    <div class=""col-12 col-sm-4"">
                                        <div class=""card__cover"">
                                            <img id=""images""");
            BeginWriteAttribute("src", " src=\"", 7689, "\"", 7709, 1);
#nullable restore
#line 147 "C:\Users\PC\Desktop\Proje\MovieApp\Views\Default\Index.cshtml"
WriteAttributeValue("", 7695, item.ImageURL, 7695, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 7710, "\"", 7716, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                            <a");
            BeginWriteAttribute("href", " href=\"", 7766, "\"", 7803, 2);
            WriteAttributeValue("", 7773, "/Default/MovieDetails/", 7773, 22, true);
#nullable restore
#line 148 "C:\Users\PC\Desktop\Proje\MovieApp\Views\Default\Index.cshtml"
WriteAttributeValue("", 7795, item.Id, 7795, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""card__play"">
                                                <i class=""icon ion-ios-play""></i>
                                            </a>
                                        </div>
                                    </div>

                                    <div class=""col-12 col-sm-8"">
                                        <div class=""card__content"">
                                            <h3 class=""card__title""><a");
            BeginWriteAttribute("href", " href=\"", 8259, "\"", 8296, 2);
            WriteAttributeValue("", 8266, "/Default/MovieDetails/", 8266, 22, true);
#nullable restore
#line 156 "C:\Users\PC\Desktop\Proje\MovieApp\Views\Default\Index.cshtml"
WriteAttributeValue("", 8288, item.Id, 8288, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 156 "C:\Users\PC\Desktop\Proje\MovieApp\Views\Default\Index.cshtml"
                                                                                                        Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></h3>\r\n                                            <span class=\"card__category\">\r\n                                                <a href=\"/default/Movies\">Film</a>\r\n                                                <a");
            BeginWriteAttribute("href", " href=\"", 8528, "\"", 8575, 2);
            WriteAttributeValue("", 8535, "/Default/MoviesGenre/", 8535, 21, true);
#nullable restore
#line 159 "C:\Users\PC\Desktop\Proje\MovieApp\Views\Default\Index.cshtml"
WriteAttributeValue("", 8556, item.Genre.GenreId, 8556, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 159 "C:\Users\PC\Desktop\Proje\MovieApp\Views\Default\Index.cshtml"
                                                                                              Write(item.Genre.GenreName);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</a>
                                            </span>
                                            <div class=""card__wrap"">
                                                <ul class=""card__list"" id=""rate"">
                                                    <li>IMDB :  ");
#nullable restore
#line 163 "C:\Users\PC\Desktop\Proje\MovieApp\Views\Default\Index.cshtml"
                                                           Write(item.Rating);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                                                </ul>\r\n                                                <ul class=\"card__list\">\r\n                                                    <li>Kitle :  ");
#nullable restore
#line 166 "C:\Users\PC\Desktop\Proje\MovieApp\Views\Default\Index.cshtml"
                                                            Write(item.AgeRestriction);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</li>
                                                </ul>
                                            </div>

                                            <div class=""card__description"">
                                                <p id=""description"">");
#nullable restore
#line 171 "C:\Users\PC\Desktop\Proje\MovieApp\Views\Default\Index.cshtml"
                                                               Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
");
#nullable restore
#line 178 "C:\Users\PC\Desktop\Proje\MovieApp\Views\Default\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    <!-- Son eklenen 6 dizi -->\r\n");
#nullable restore
#line 181 "C:\Users\PC\Desktop\Proje\MovieApp\Views\Default\Index.cshtml"
                     foreach (var item in Model.seriesViewModels.Reverse().Take(6))
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        <div class=""col-6 col-sm-12 col-lg-6"">
                            <div class=""card card--list"">
                                <div class=""row"">
                                    <div class=""col-12 col-sm-4"">
                                        <div class=""card__cover"">
                                            <img id=""images""");
            BeginWriteAttribute("src", " src=\"", 10192, "\"", 10212, 1);
#nullable restore
#line 188 "C:\Users\PC\Desktop\Proje\MovieApp\Views\Default\Index.cshtml"
WriteAttributeValue("", 10198, item.ImageURL, 10198, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 10213, "\"", 10219, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                            <a");
            BeginWriteAttribute("href", " href=\"", 10269, "\"", 10307, 2);
            WriteAttributeValue("", 10276, "/Default/SeriesDetails/", 10276, 23, true);
#nullable restore
#line 189 "C:\Users\PC\Desktop\Proje\MovieApp\Views\Default\Index.cshtml"
WriteAttributeValue("", 10299, item.Id, 10299, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""card__play"">
                                                <i class=""icon ion-ios-play""></i>
                                            </a>
                                        </div>
                                    </div>

                                    <div class=""col-12 col-sm-8"">
                                        <div class=""card__content"">
                                            <h3 class=""card__title""><a");
            BeginWriteAttribute("href", " href=\"", 10763, "\"", 10801, 2);
            WriteAttributeValue("", 10770, "/Default/SeriesDetails/", 10770, 23, true);
#nullable restore
#line 197 "C:\Users\PC\Desktop\Proje\MovieApp\Views\Default\Index.cshtml"
WriteAttributeValue("", 10793, item.Id, 10793, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 197 "C:\Users\PC\Desktop\Proje\MovieApp\Views\Default\Index.cshtml"
                                                                                                         Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></h3>\r\n                                            <span class=\"card__category\">\r\n                                                <a href=\"/default/Series\">Dizi</a>\r\n                                                <a");
            BeginWriteAttribute("href", " href=\"", 11033, "\"", 11080, 2);
            WriteAttributeValue("", 11040, "/Default/SeriesGenre/", 11040, 21, true);
#nullable restore
#line 200 "C:\Users\PC\Desktop\Proje\MovieApp\Views\Default\Index.cshtml"
WriteAttributeValue("", 11061, item.Genre.GenreId, 11061, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 200 "C:\Users\PC\Desktop\Proje\MovieApp\Views\Default\Index.cshtml"
                                                                                              Write(item.Genre.GenreName);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</a>
                                            </span>
                                            <div class=""card__wrap"">
                                                <ul class=""card__list"" id=""rate"">
                                                    <li>IMDB :  ");
#nullable restore
#line 204 "C:\Users\PC\Desktop\Proje\MovieApp\Views\Default\Index.cshtml"
                                                           Write(item.Rating);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                                                </ul>\r\n                                                <ul class=\"card__list\">\r\n                                                    <li>Kitle :  ");
#nullable restore
#line 207 "C:\Users\PC\Desktop\Proje\MovieApp\Views\Default\Index.cshtml"
                                                            Write(item.AgeRestriction);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</li>
                                                </ul>
                                            </div>

                                            <div class=""card__description"">
                                                <p id=""description"">");
#nullable restore
#line 212 "C:\Users\PC\Desktop\Proje\MovieApp\Views\Default\Index.cshtml"
                                                               Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
");
#nullable restore
#line 219 "C:\Users\PC\Desktop\Proje\MovieApp\Views\Default\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    <!-- end card -->
                </div>
            </div>

            <div class=""tab-pane fade"" id=""tab-2"" role=""tabpanel"" aria-labelledby=""2-tab"">
                <div class=""row"">
                    <!-- card -->                    
                    <!-- Son eklenen 12 film -->
");
#nullable restore
#line 228 "C:\Users\PC\Desktop\Proje\MovieApp\Views\Default\Index.cshtml"
                     foreach (var item in Model.movieViewModels.Reverse().Take(12))
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"col-6 col-sm-4 col-lg-3 col-xl-2\">\r\n                            <div class=\"card\">\r\n                                <div class=\"card__cover\">\r\n                                    <img id=\"images\"");
            BeginWriteAttribute("src", " src=\"", 12826, "\"", 12846, 1);
#nullable restore
#line 233 "C:\Users\PC\Desktop\Proje\MovieApp\Views\Default\Index.cshtml"
WriteAttributeValue("", 12832, item.ImageURL, 12832, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 12847, "\"", 12853, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                    <a");
            BeginWriteAttribute("href", " href=\"", 12895, "\"", 12932, 2);
            WriteAttributeValue("", 12902, "/Default/MovieDetails/", 12902, 22, true);
#nullable restore
#line 234 "C:\Users\PC\Desktop\Proje\MovieApp\Views\Default\Index.cshtml"
WriteAttributeValue("", 12924, item.Id, 12924, 8, false);

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
            BeginWriteAttribute("href", " href=\"", 13235, "\"", 13272, 2);
            WriteAttributeValue("", 13242, "/Default/MovieDetails/", 13242, 22, true);
#nullable restore
#line 239 "C:\Users\PC\Desktop\Proje\MovieApp\Views\Default\Index.cshtml"
WriteAttributeValue("", 13264, item.Id, 13264, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 239 "C:\Users\PC\Desktop\Proje\MovieApp\Views\Default\Index.cshtml"
                                                                                                Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></h3>\r\n                                    <span class=\"card__category\">\r\n                                        <a");
            BeginWriteAttribute("href", " href=\"", 13404, "\"", 13451, 2);
            WriteAttributeValue("", 13411, "/Default/MoviesGenre/", 13411, 21, true);
#nullable restore
#line 241 "C:\Users\PC\Desktop\Proje\MovieApp\Views\Default\Index.cshtml"
WriteAttributeValue("", 13432, item.Genre.GenreId, 13432, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 241 "C:\Users\PC\Desktop\Proje\MovieApp\Views\Default\Index.cshtml"
                                                                                      Write(item.Genre.GenreName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                                    </span>\r\n                                    <ul class=\"card__list\" id=\"rate\">\r\n                                        <li>IMDB :  ");
#nullable restore
#line 244 "C:\Users\PC\Desktop\Proje\MovieApp\Views\Default\Index.cshtml"
                                               Write(item.Rating);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                                    </ul>                                \r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n");
#nullable restore
#line 249 "C:\Users\PC\Desktop\Proje\MovieApp\Views\Default\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    <!-- end card -->
                </div>
            </div>

            <div class=""tab-pane fade"" id=""tab-3"" role=""tabpanel"" aria-labelledby=""3-tab"">
                <div class=""row"">
                    <!--card-->
                    <!--Son eklenen 12 dizi-->
");
#nullable restore
#line 258 "C:\Users\PC\Desktop\Proje\MovieApp\Views\Default\Index.cshtml"
                     foreach (var item in Model.seriesViewModels.Reverse().Take(12))
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"col-6 col-sm-4 col-lg-3 col-xl-2\">\r\n                            <div class=\"card\">\r\n                                <div class=\"card__cover\">\r\n                                    <img id=\"images\"");
            BeginWriteAttribute("src", " src=\"", 14506, "\"", 14526, 1);
#nullable restore
#line 263 "C:\Users\PC\Desktop\Proje\MovieApp\Views\Default\Index.cshtml"
WriteAttributeValue("", 14512, item.ImageURL, 14512, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 14527, "\"", 14533, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                    <a");
            BeginWriteAttribute("href", " href=\"", 14575, "\"", 14613, 2);
            WriteAttributeValue("", 14582, "/Default/SeriesDetails/", 14582, 23, true);
#nullable restore
#line 264 "C:\Users\PC\Desktop\Proje\MovieApp\Views\Default\Index.cshtml"
WriteAttributeValue("", 14605, item.Id, 14605, 8, false);

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
            BeginWriteAttribute("href", " href=\"", 14916, "\"", 14954, 2);
            WriteAttributeValue("", 14923, "/Default/SeriesDetails/", 14923, 23, true);
#nullable restore
#line 269 "C:\Users\PC\Desktop\Proje\MovieApp\Views\Default\Index.cshtml"
WriteAttributeValue("", 14946, item.Id, 14946, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 269 "C:\Users\PC\Desktop\Proje\MovieApp\Views\Default\Index.cshtml"
                                                                                                 Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></h3>\r\n                                    <span class=\"card__category\">\r\n                                        <a");
            BeginWriteAttribute("href", " href=\"", 15086, "\"", 15133, 2);
            WriteAttributeValue("", 15093, "/Default/SeriesGenre/", 15093, 21, true);
#nullable restore
#line 271 "C:\Users\PC\Desktop\Proje\MovieApp\Views\Default\Index.cshtml"
WriteAttributeValue("", 15114, item.Genre.GenreId, 15114, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 271 "C:\Users\PC\Desktop\Proje\MovieApp\Views\Default\Index.cshtml"
                                                                                      Write(item.Genre.GenreName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                                    </span>\r\n                                    <ul class=\"card__list\" id=\"rate\">\r\n                                        <li>IMDB :  ");
#nullable restore
#line 274 "C:\Users\PC\Desktop\Proje\MovieApp\Views\Default\Index.cshtml"
                                               Write(item.Rating);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                                    </ul>\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n");
#nullable restore
#line 279 "C:\Users\PC\Desktop\Proje\MovieApp\Views\Default\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <!--end card-->\r\n                </div>\r\n            </div>\r\n        </div>\r\n        <!-- end content tabs -->\r\n    </div>\r\n</section>\r\n<!-- end content -->\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MovieApp.Models.ViewModels.MultiViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
