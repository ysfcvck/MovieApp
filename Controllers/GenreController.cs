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
    public class GenreController : Controller
    {
        Context c = new Context();
        public void Statuses() // Durumları listelemek için metot
        {
            //Veritabanından durumları listeye alıyoruz.
            List<SelectListItem> Statuses = (from x in c.Statuses.ToList()
                                             select new SelectListItem
                                             {
                                                 Text = x.Status,
                                                 Value = x.Status
                                             }).ToList();
            ViewBag.Statuses = Statuses; // Listeyi viewbag e aktarıyoruz.
        }

        // TÜR LİSTELE
        public IActionResult Index()
        {
            var genres = c.Genres.ToList();
            return View(genres);
        }

        // TÜR EKLE
        [HttpGet]
        public IActionResult GenreAdd()
        {
            Statuses();
            return View();
        }
        [HttpPost]
        public IActionResult GenreAdd(GenreViewModel g)
        {
            Statuses();
            // Veri türü kontrolü 
            if (TryValidateModel(g, nameof(g)))
            {
                c.Genres.Add(g);
                c.SaveChanges();
                ModelState.Clear();
                return RedirectToAction("GenreAdd");
            }
            else
                return View();
        }

        // TÜR BİLGİSİ GETİR
        public IActionResult GenreGet(int id) // Id'ye göre tür bilgilerini getirme.
        {
            var x = c.Genres.Find(id);
            return View("GenreGet", x);
        }

        // TÜR GÜNCELLE
        public IActionResult GenreUpdate(GenreViewModel g)
        {
            var x = c.Genres.Find(g.GenreId);
            if (TryValidateModel(g, nameof(g)))
            {
                x.GenreId = g.GenreId;
                x.GenreName = g.GenreName;
                x.Status = g.Status;
                c.SaveChanges();

                return RedirectToAction("index");
            }
            return View("GenreGet", x);
        }

        //Türü aktif hale getir
        public IActionResult GenreActive(int id)
        {
            var x = c.Genres.Find(id);
            x.Status = true;
            c.SaveChanges();
            return RedirectToAction("index");
        }

        //Türü pasif hale getir
        public IActionResult GenreInactive(int id)
        {
            var x = c.Genres.Find(id);
            x.Status = false;
            c.SaveChanges();
            return RedirectToAction("index");
        }
    }
}
