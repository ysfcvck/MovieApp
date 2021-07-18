using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using MovieApp.Models.Context;
using MovieApp.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieApp.Controllers
{
    [Authorize(Roles = "Admin,Moderator,User")]
    public class MovieController : Controller
    {
        Context c = new Context();
        public void Genres() 
        {
            //Veritabanından Tür id ve Tür adını listeliyoruz.
            List<SelectListItem> Genres = (from x in c.Genres.ToList()
                                           select new SelectListItem
                                           {
                                               Text = x.GenreName,
                                               Value = x.GenreId.ToString()
                                           }).ToList();
            ViewBag.gnrs = Genres; //Listeyi viewbage atıyoruz.
        }

        // FİLM LİSTELE
        public IActionResult Index()
        {
            Genres();
            var movies = c.Movies.ToList();
            return View(movies);
        }


        // FİLM EKLEME  
        [HttpGet]
        public IActionResult MovieAdd()
        {
            Genres();
            return View();
        }
        [HttpPost]
        public IActionResult MovieAdd(MovieViewModel m)
        {
            Genres();
            /* Veri türü kontrolü */
            if (TryValidateModel(m, nameof(m)))
            {
                c.Movies.Add(m);
                c.SaveChanges();
                ModelState.Clear();
                return RedirectToAction("MovieAdd");
            }
            else
                return View();
        }

        // FİLM SİLME
        public IActionResult MovieRemove(int id)
        {
            var x = c.Movies.Find(id);
            c.Movies.Remove(x);
            c.SaveChanges();
            return RedirectToAction("index");
        }


        // FİLM BİLGİLERİ GETİRME
        public IActionResult MovieGet(int id)
        {
            Genres();
            var x = c.Movies.Find(id);
            return View("MovieGet", x);
        }

        //FİLM GÜNCELLEME
        [HttpPost]
        public IActionResult MovieUpdate(MovieViewModel m)
        {
            var x = c.Movies.Find(m.Id);

            if (TryValidateModel(m, nameof(m)))
            {
                x.Id = m.Id;
                x.Name = m.Name;
                x.ReleaseYear = m.ReleaseYear;
                x.GenreId = m.GenreId;
                x.Time = m.Time;
                x.Rating = m.Rating;
                x.AgeRestriction = m.AgeRestriction;
                x.Director = m.Director;
                x.Writer = m.Writer;
                x.Cast = m.Cast;
                x.Description = m.Description;
                x.ImageURL = m.ImageURL;
                x.VideoURL = m.VideoURL;
                x.BackgroundURL = m.BackgroundURL;

                c.SaveChanges();
                return RedirectToAction("index"); 
            }
            return View("MovieGet", x);
        }
    }
}
