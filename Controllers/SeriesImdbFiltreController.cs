using Microsoft.AspNetCore.Mvc;
using MovieApp.Models.Context;
using MovieApp.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieApp.Controllers
{
    public class SeriesImdbFiltreController : Controller
    {
        Context c = new Context();

        // imdb 0-2,5 arası
        public IActionResult ImdbOne(string search)
        {
            var genres = c.Genres.ToList();
            var series = c.Series.ToList();
            if (!string.IsNullOrEmpty(search))//parametreden gelen değer boş değilse
            {
                series = series.Where(x => x.Name.ToLower().Contains(search)).ToList();//parametreden gelen değerle diziler tablosunda arama yapıyoruz
            }
            return View(series);
        }
        // imdb 2,5-5 arası
        public IActionResult ImdbTwo(string search)
        {
            var genres = c.Genres.ToList();
            var series = c.Series.ToList();
            if (!string.IsNullOrEmpty(search))
            {
                series = series.Where(x => x.Name.ToLower().Contains(search)).ToList();
            }
            return View(series);
        }
        //imdb 5-7,5 arası
        public IActionResult ImdbThree(string search)
        {
            var genres = c.Genres.ToList();
            var series = c.Series.ToList();
            if (!string.IsNullOrEmpty(search))
            {
                series = series.Where(x => x.Name.ToLower().Contains(search)).ToList();
            }
            return View(series);
        }
        // imdb 7,5-10 arası
        public IActionResult ImdbFour(string search)
        {
            var genres = c.Genres.ToList();
            var series = c.Series.ToList();
            if (!string.IsNullOrEmpty(search))
            {
                series = series.Where(x => x.Name.ToLower().Contains(search)).ToList();
            }
            return View(series);
        }
    }
}
