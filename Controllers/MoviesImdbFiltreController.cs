using Microsoft.AspNetCore.Mvc;
using MovieApp.Models.Context;
using MovieApp.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieApp.Controllers
{
    public class MoviesImdbFiltreController : Controller
    {
        Context c = new Context();

        // imdb 0-2,5 arası
        public IActionResult ImdbOne(string search)
        {
            var movies = c.Movies.ToList();
            var genres = c.Genres.ToList();
            if (!string.IsNullOrEmpty(search))//parametreden gelen değer boş değilse
            {
                movies = movies.Where(x => x.Name.ToLower().Contains(search)).ToList();//parametreden gelen değerle filmler tablosunda arama yapıyoruz
            }
            return View(movies);
        }
        // imdb 2,5-5 arası
        public IActionResult ImdbTwo(string search)
        {
            var movies = c.Movies.ToList();
            var genres = c.Genres.ToList();
            if (!string.IsNullOrEmpty(search))
            {
                movies = movies.Where(x => x.Name.ToLower().Contains(search)).ToList();
            }
            return View(movies);
        }
        //imdb 5-7,5 arası
        public IActionResult ImdbThree(string search)
        {
            var movies = c.Movies.ToList();
            var genres = c.Genres.ToList();
            if (!string.IsNullOrEmpty(search))
            {
                movies = movies.Where(x => x.Name.ToLower().Contains(search)).ToList();
            }
            return View(movies);
        }
        // imdb 7,5-10 arası
        public IActionResult ImdbFour(string search)
        {
            var movies = c.Movies.ToList();
            var genres = c.Genres.ToList();
            if (!string.IsNullOrEmpty(search))
            {
                movies = movies.Where(x => x.Name.ToLower().Contains(search)).ToList();
            }
            return View(movies);
        }
    }
}
