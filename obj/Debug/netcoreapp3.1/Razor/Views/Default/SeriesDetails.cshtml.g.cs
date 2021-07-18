#pragma checksum "C:\Users\PC\Desktop\Proje\MovieApp\Views\Default\SeriesDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c4d6b8edf4a67e35cdfe37d8b238b8391221ff33"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Default_SeriesDetails), @"mvc.1.0.view", @"/Views/Default/SeriesDetails.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c4d6b8edf4a67e35cdfe37d8b238b8391221ff33", @"/Views/Default/SeriesDetails.cshtml")]
    public class Views_Default_SeriesDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MovieApp.Models.ViewModels.MultiViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("reviews__avatar"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Movies/img/comment.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("rates"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\PC\Desktop\Proje\MovieApp\Views\Default\SeriesDetails.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
#nullable restore
#line 8 "C:\Users\PC\Desktop\Proje\MovieApp\Views\Default\SeriesDetails.cshtml"
 if (ViewBag.Average == null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("<style>\r\n    #avg{\n        margin-left:0;\n    }\r\n</style>\r\n");
#nullable restore
#line 15 "C:\Users\PC\Desktop\Proje\MovieApp\Views\Default\SeriesDetails.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("<!-- details -->\n<section class=\"section details\">\n    <div class=\"details__bg\"");
            BeginWriteAttribute("style", " style=\"", 361, "\"", 402, 3);
            WriteAttributeValue("", 369, "background:url(", 369, 15, true);
#nullable restore
#line 18 "C:\Users\PC\Desktop\Proje\MovieApp\Views\Default\SeriesDetails.cshtml"
WriteAttributeValue("", 384, ViewBag.imageUrl, 384, 17, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 401, ")", 401, 1, true);
            EndWriteAttribute();
            WriteLiteral("></div>\n    <!-- details content -->\n    <div class=\"container\">\n        <div class=\"row\">\n");
#nullable restore
#line 22 "C:\Users\PC\Desktop\Proje\MovieApp\Views\Default\SeriesDetails.cshtml"
            foreach (var item in Model.seriesViewModels)
           {
            if (item.Id==ViewBag.x)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                   <!-- title -->\n            <div class=\"col-12\">\n                <h1 class=\"details__title\">");
#nullable restore
#line 28 "C:\Users\PC\Desktop\Proje\MovieApp\Views\Default\SeriesDetails.cshtml"
                                      Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h1>
            </div>
            <!-- end title -->
            <!-- content -->
            <div class=""col-12 col-xl-6"">
                <div class=""card card--details"">
                    <div class=""row"">
                        <!-- card cover -->
                        <div class=""col-12 col-sm-4 col-md-4 col-lg-3 col-xl-5"">
                            <div class=""card__cover"">
                                <img");
            BeginWriteAttribute("src", " src=\"", 1166, "\"", 1186, 1);
#nullable restore
#line 38 "C:\Users\PC\Desktop\Proje\MovieApp\Views\Default\SeriesDetails.cshtml"
WriteAttributeValue("", 1172, item.ImageURL, 1172, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 1187, "\"", 1193, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                            </div>
                        </div>
                        <!-- end card cover -->
                        <!-- card content -->
                        <div class=""col-12 col-sm-8 col-md-8 col-lg-9 col-xl-7"">
                            <div class=""card__content"">
                                <div class=""card__wrap"">
");
#nullable restore
#line 46 "C:\Users\PC\Desktop\Proje\MovieApp\Views\Default\SeriesDetails.cshtml"
                                     if (ViewBag.Average != null)
                                     {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <span class=\"card__rate\"><i class=\"icon ion-ios-star\"></i>");
#nullable restore
#line 48 "C:\Users\PC\Desktop\Proje\MovieApp\Views\Default\SeriesDetails.cshtml"
                                                                                             Write(ViewBag.Average);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\n");
#nullable restore
#line 49 "C:\Users\PC\Desktop\Proje\MovieApp\Views\Default\SeriesDetails.cshtml"
                                     }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                                    <ul class=\"card__list\" id=\"avg\">\n                                        <li>IMDB : ");
#nullable restore
#line 52 "C:\Users\PC\Desktop\Proje\MovieApp\Views\Default\SeriesDetails.cshtml"
                                              Write(item.Rating);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\n                                    </ul>\n                                    <ul class=\"card__list\">\n                                        <li>Kitle : ");
#nullable restore
#line 55 "C:\Users\PC\Desktop\Proje\MovieApp\Views\Default\SeriesDetails.cshtml"
                                               Write(item.AgeRestriction);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\n                                    </ul>\n                                </div>\n\n                                <ul class=\"card__meta\">\n                                    <li>\n                                        <span>Tür:</span> <a");
            BeginWriteAttribute("href", " href=\"", 2374, "\"", 2421, 2);
            WriteAttributeValue("", 2381, "/Default/SeriesGenre/", 2381, 21, true);
#nullable restore
#line 61 "C:\Users\PC\Desktop\Proje\MovieApp\Views\Default\SeriesDetails.cshtml"
WriteAttributeValue("", 2402, item.Genre.GenreId, 2402, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 61 "C:\Users\PC\Desktop\Proje\MovieApp\Views\Default\SeriesDetails.cshtml"
                                                                                                        Write(item.Genre.GenreName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\n                                    </li>\n                                    <li><span>Çıkış Yılı:</span> ");
#nullable restore
#line 63 "C:\Users\PC\Desktop\Proje\MovieApp\Views\Default\SeriesDetails.cshtml"
                                                            Write(item.ReleaseYear);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\n                                    <li><span>Sezon:</span> ");
#nullable restore
#line 64 "C:\Users\PC\Desktop\Proje\MovieApp\Views\Default\SeriesDetails.cshtml"
                                                       Write(item.Season);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\n                                    <li><span>Durum:</span> ");
#nullable restore
#line 65 "C:\Users\PC\Desktop\Proje\MovieApp\Views\Default\SeriesDetails.cshtml"
                                                       Write(item.Status);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\n                                    <li><span>Yönetmen:</span> <a href=\"#\">");
#nullable restore
#line 66 "C:\Users\PC\Desktop\Proje\MovieApp\Views\Default\SeriesDetails.cshtml"
                                                                      Write(item.Director);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\n                                    <li><span>Senarist:</span> <a href=\"#\">");
#nullable restore
#line 67 "C:\Users\PC\Desktop\Proje\MovieApp\Views\Default\SeriesDetails.cshtml"
                                                                      Write(item.Writer);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\n                                    <li><span>Oyuncular:</span> <a href=\"#\">");
#nullable restore
#line 68 "C:\Users\PC\Desktop\Proje\MovieApp\Views\Default\SeriesDetails.cshtml"
                                                                       Write(item.Cast);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\n                                </ul>\n\n                                <div class=\"card__description card__description--details\">\n                                    ");
#nullable restore
#line 72 "C:\Users\PC\Desktop\Proje\MovieApp\Views\Default\SeriesDetails.cshtml"
                               Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                </div>
                            </div>
                        </div>
                        <!-- end card content -->
                    </div>
                </div>
            </div>
            <!-- end content -->
            <!-- player -->
            <div class=""col-12 col-xl-6"">
                <iframe width=""560"" height=""315""");
            BeginWriteAttribute("src", " src=\"", 3586, "\"", 3645, 2);
            WriteAttributeValue("", 3592, "https://www.youtube-nocookie.com/embed/", 3592, 39, true);
#nullable restore
#line 83 "C:\Users\PC\Desktop\Proje\MovieApp\Views\Default\SeriesDetails.cshtml"
WriteAttributeValue("", 3631, item.VideoURL, 3631, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" title=\"YouTube video player\" frameborder=\"0\" allow=\"accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture\" allowfullscreen></iframe>\n            </div>\n            <!-- end player -->\r\n");
#nullable restore
#line 86 "C:\Users\PC\Desktop\Proje\MovieApp\Views\Default\SeriesDetails.cshtml"
            }
            
            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
            <div class=""col-12"">
                <div class=""details__wrap"">
                    <!-- availables -->
                    <div class=""details__devices"">
                        <span class=""details__devices-title"">Destekleyen Cihazlar:</span>
                        <ul class=""details__devices-list"">
                            <li><i class=""icon ion-logo-apple""></i><span>IOS</span></li>
                            <li><i class=""icon ion-logo-android""></i><span>Android</span></li>
                            <li><i class=""icon ion-logo-windows""></i><span>Windows</span></li>
                            <li><i class=""icon ion-md-tv""></i><span>Smart TV</span></li>
                        </ul>
                    </div>
                    <!-- end availables -->
                    <!-- share -->
                    <div class=""details__share"">
                        <span class=""details__share-title"">Sosyal Medya:</span>

                        <ul class=""details__share-list"">
               ");
            WriteLiteral(@"             <li class=""facebook""><a href=""https://tr-tr.facebook.com""><i class=""icon ion-logo-facebook""></i></a></li>
                            <li class=""instagram""><a href=""https://www.instagram.com/?hl=tr""><i class=""icon ion-logo-instagram""></i></a></li>
                            <li class=""twitter""><a href=""https://twitter.com/?lang=tr""><i class=""icon ion-logo-twitter""></i></a></li>
                        </ul>
                    </div>
                    <!-- end share -->
                </div>
            </div>
        </div>
    </div>
    <!-- end details content -->
</section>
<!-- end details -->

<!-- content -->
	<section class=""content"">
		<div class=""content__head"">
			<div class=""container"">
				<div class=""row"">
					<div class=""col-12"">
						<!-- content title -->
						<h2 class=""content__title"">Yorumlar</h2>
						<!-- end content title -->
					</div>
				</div>
			</div>
		</div>

		<div class=""container"">
			<div class=""row"">
				<div class=""col-12 col-lg-8 col-xl-8"">
					<!-");
            WriteLiteral(@"- content tabs -->
					<div class=""tab-content"" id=""myTabContent"">
						<div class=""tab-pane fade show active"" id=""tab-1"" role=""tabpanel"" aria-labelledby=""1-tab"">
                            <div class=""row"">
                                <!-- comment -->
                                <div class=""col-12"">
                                    <div class=""reviews"">
                                        <ul class=""reviews__list"">

											<!-- comments -->
");
#nullable restore
#line 149 "C:\Users\PC\Desktop\Proje\MovieApp\Views\Default\SeriesDetails.cshtml"
                                             foreach (var item in Model.s_CommentsViewModels)
                                            {
                                                if (item.SeriesId == ViewBag.x && item.Status == true)
                                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                    <li class=\"reviews__item\">\n                                                        <div class=\"reviews__autor\">\n                                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "c4d6b8edf4a67e35cdfe37d8b238b8391221ff3317385", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                                                            <span class=\"reviews__name\">");
#nullable restore
#line 156 "C:\Users\PC\Desktop\Proje\MovieApp\Views\Default\SeriesDetails.cshtml"
                                                                                   Write(item.NameSurname);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\n                                                            <span class=\"reviews__time\">");
#nullable restore
#line 157 "C:\Users\PC\Desktop\Proje\MovieApp\Views\Default\SeriesDetails.cshtml"
                                                                                   Write(item.Date);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\n\n                                                            <span class=\"reviews__rating\"><i class=\"icon ion-ios-star\"></i>");
#nullable restore
#line 159 "C:\Users\PC\Desktop\Proje\MovieApp\Views\Default\SeriesDetails.cshtml"
                                                                                                                      Write(item.Rate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\n                                                        </div>\n                                                        <p class=\"reviews__text\">");
#nullable restore
#line 161 "C:\Users\PC\Desktop\Proje\MovieApp\Views\Default\SeriesDetails.cshtml"
                                                                            Write(item.Comment);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n                                                    </li>\n");
#nullable restore
#line 163 "C:\Users\PC\Desktop\Proje\MovieApp\Views\Default\SeriesDetails.cshtml"
                                                }
                                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        </ul>\n\n\t\t\t\t\t\t\t\t\t\t<!-- comment form -->\n                                        <b style=\"color:#939397; font-size:larger; font-family:\'Open Sans\', sans-serif; margin-top:15px;\">Yorum Yap</b>\n");
#nullable restore
#line 169 "C:\Users\PC\Desktop\Proje\MovieApp\Views\Default\SeriesDetails.cshtml"
                                         using (Html.BeginForm("SeriesDetails", "Default", FormMethod.Post))
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                            <input style=""margin-top:15px;"" type=""text"" class=""form__input"" name=""Name"" placeholder=""Ad Soyad"">
                                            <input type=""text"" class=""form__input"" name=""Email"" placeholder=""Eposta"">
                                            <textarea class=""form__textarea"" name=""Comment"" placeholder=""Yorumunuz..""></textarea>
                                            <div class=""form__slider"">
                                                <label class=""kanyelele"">»</label>
                                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c4d6b8edf4a67e35cdfe37d8b238b8391221ff3321793", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
#nullable restore
#line 176 "C:\Users\PC\Desktop\Proje\MovieApp\Views\Default\SeriesDetails.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Rate);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 176 "C:\Users\PC\Desktop\Proje\MovieApp\Views\Default\SeriesDetails.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items = Model.Rates;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-items", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                                            </div>
											<b style=""color:#df5261; font-family:'Open Sans', sans-serif;"">Yorumunuz incelendikten sonra yayınlanacaktır.</b>
                                            <button type=""submit"" class=""form__btn"">Gönder</button>
");
#nullable restore
#line 180 "C:\Users\PC\Desktop\Proje\MovieApp\Views\Default\SeriesDetails.cshtml"
                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                    </div>
                                </div>
                                <!-- end comment -->
                            </div>
						</div>
					</div>
					<!-- end content tabs -->
				</div>

				<!-- sidebar -->
				<div class=""col-12 col-lg-4 col-xl-4"">
                    <div class=""row"">
                        <!-- section title -->
                        <div class=""col-12"">
                            <h2 class=""section__title section__title--sidebar"">Önerilen diziler...</h2>
                        </div>
                        <!-- end section title -->
                        <!-- card -->
");
#nullable restore
#line 199 "C:\Users\PC\Desktop\Proje\MovieApp\Views\Default\SeriesDetails.cshtml"
                         foreach (var item in Model.seriesViewModels.Reverse().Take(6))
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <div class=\"col-6 col-sm-4 col-lg-6\">\n                                    <div class=\"card\">\n                                        <div class=\"card__cover\">\n                                            <img id=\"images\"");
            BeginWriteAttribute("src", " src=\"", 10073, "\"", 10093, 1);
#nullable restore
#line 204 "C:\Users\PC\Desktop\Proje\MovieApp\Views\Default\SeriesDetails.cshtml"
WriteAttributeValue("", 10079, item.ImageURL, 10079, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 10094, "\"", 10100, 0);
            EndWriteAttribute();
            WriteLiteral(">\n                                            <a");
            BeginWriteAttribute("href", " href=\"", 10149, "\"", 10187, 2);
            WriteAttributeValue("", 10156, "/Default/SeriesDetails/", 10156, 23, true);
#nullable restore
#line 205 "C:\Users\PC\Desktop\Proje\MovieApp\Views\Default\SeriesDetails.cshtml"
WriteAttributeValue("", 10179, item.Id, 10179, 8, false);

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
            BeginWriteAttribute("href", " href=\"", 10525, "\"", 10563, 2);
            WriteAttributeValue("", 10532, "/Default/SeriesDetails/", 10532, 23, true);
#nullable restore
#line 210 "C:\Users\PC\Desktop\Proje\MovieApp\Views\Default\SeriesDetails.cshtml"
WriteAttributeValue("", 10555, item.Id, 10555, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 210 "C:\Users\PC\Desktop\Proje\MovieApp\Views\Default\SeriesDetails.cshtml"
                                                                                                         Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></h3>\n                                            <span class=\"card__category\">\n                                                <a");
            BeginWriteAttribute("href", " href=\"", 10709, "\"", 10756, 2);
            WriteAttributeValue("", 10716, "/Default/SeriesGenre/", 10716, 21, true);
#nullable restore
#line 212 "C:\Users\PC\Desktop\Proje\MovieApp\Views\Default\SeriesDetails.cshtml"
WriteAttributeValue("", 10737, item.Genre.GenreId, 10737, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 212 "C:\Users\PC\Desktop\Proje\MovieApp\Views\Default\SeriesDetails.cshtml"
                                                                                              Write(item.Genre.GenreName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\n                                            </span>\n                                            <span class=\"card__rate\"><i class=\"icon ion-ios-star\"></i>");
#nullable restore
#line 214 "C:\Users\PC\Desktop\Proje\MovieApp\Views\Default\SeriesDetails.cshtml"
                                                                                                 Write(item.Rating);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\n                                        </div>\n                                    </div>\n                                </div>\n");
#nullable restore
#line 218 "C:\Users\PC\Desktop\Proje\MovieApp\Views\Default\SeriesDetails.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                        <!-- end card -->\n                    </div>\n\t\t\t\t</div>\n\t\t\t\t<!-- end sidebar -->\n\t\t\t</div>\n\t\t</div>\n\t</section>\n\t<!-- end content -->\n");
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
