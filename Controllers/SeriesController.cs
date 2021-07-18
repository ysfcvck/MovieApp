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
    public class SeriesController : Controller
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

        // DİZİ LİSTELE
        public IActionResult Index()
        {
            Genres();
            var series = c.Series.ToList();
            return View(series);
        }


        // DİZİ EKLEME  
        [HttpGet]
        public IActionResult SeriesAdd()
        {
            Genres();
            return View();
        }
        [HttpPost]
        public IActionResult SeriesAdd(SeriesViewModel s)
        {
            Genres();
            /* Veri türü kontrolü */
            if (TryValidateModel(s, nameof(s)))
            {
                c.Series.Add(s);
                c.SaveChanges();
                ModelState.Clear();
                return RedirectToAction("SeriesAdd");
            }
            else
                return View();
        }

        // DİZİ SİLME
        public IActionResult SeriesRemove(int id)
        {
            var x = c.Series.Find(id);
            c.Series.Remove(x);
            c.SaveChanges();
            return RedirectToAction("index");
        }


        // DİZİ BİLGİLERİ GETİRME
        public IActionResult SeriesGet(int id)
        {
            Genres();
            var x = c.Series.Find(id);
            return View("SeriesGet", x);
        }

        //DİZİ GÜNCELLEME
        [HttpPost]
        public IActionResult SeriesUpdate(SeriesViewModel s)
        {
            var x = c.Series.Find(s.Id);

            if (TryValidateModel(s, nameof(s)))
            {
                x.Id = s.Id;
                x.Name = s.Name;
                x.ReleaseYear = s.ReleaseYear;
                x.GenreId = s.GenreId;
                x.Season = s.Season;
                x.Status = s.Status;
                x.Rating = s.Rating;
                x.AgeRestriction = s.AgeRestriction;
                x.Director = s.Director;
                x.Writer = s.Writer;
                x.Cast = s.Cast;
                x.Description = s.Description;
                x.ImageURL = s.ImageURL;
                x.VideoURL = s.VideoURL;
                x.BackgroundURL = s.BackgroundURL;

                c.SaveChanges();
                return RedirectToAction("index");
            }
            return View("SeriesGet", x);
        }
    }
}
