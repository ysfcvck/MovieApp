using Microsoft.AspNetCore.Mvc;
using MovieApp.Models.Context;
using MovieApp.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using X.PagedList;

namespace MovieApp.Controllers
{
    public class DefaultController : Controller
    {
        Context c = new Context();
        MultiViewModel m = new MultiViewModel();
        public void Models()
        {
            m.movieViewModels = c.Movies.ToList(); //film listesi
            m.seriesViewModels = c.Series.ToList();//dizi listesi
            m.genreViewModels = c.Genres.ToList();//tür listesi
            m.M_CommentsViewModel = c.m_Comments.ToList();//film yorumları listesi
            m.s_CommentsViewModels = c.s_Comments.ToList();//dizi yorumları listesi
        }

        public IActionResult Index()
        {
            Models();
            return View(m);
        }

        public IActionResult Movies(string search)
        {
            
            var genres = c.Genres.ToList();
            var movies = c.Movies.ToList();
            if (!string.IsNullOrEmpty(search))//parametreden gelen değer boş değilse
            {
                movies = movies.Where(x => x.Name.ToLower().Contains(search)).ToList();//parametreden gelen değerle filmler tablosunda arama yapıyoruz
            }
            return View(movies);
        }
        public IActionResult MoviesGenre(int id, string search)
        {
            var genres = c.Genres.ToList();
            var movies = c.Movies.ToList();
            if (!string.IsNullOrEmpty(search))//parametreden gelen değer boş değilse
            {
                movies = movies.Where(x => x.Name.ToLower().Contains(search)).ToList();//parametreden gelen değerle filmler tablosunda arama yapıyoruz
            }
            ViewBag.x = id;
            return View(movies);
        }

        public IActionResult Series(string search)
        {
            var genres = c.Genres.ToList();
            var series = c.Series.ToList();
            if (!string.IsNullOrEmpty(search))//parametreden gelen değer boş değilse
            {
                series = series.Where(x => x.Name.ToLower().Contains(search)).ToList();//parametreden gelen değerle diziler tablosunda arama yapıyoruz.
            }
            return View(series);
        }
        public IActionResult SeriesGenre(int id, string search)
        {
            var genres = c.Genres.ToList();
            var series = c.Series.ToList();
            if (!string.IsNullOrEmpty(search))//parametreden gelen değer boş değilse
            {
                series = series.Where(x => x.Name.ToLower().Contains(search)).ToList();//parametreden gelen değerle diziler tablosunda arama yapıyoruz.
            }
            ViewBag.x = id;
            return View(series);
        }

        [HttpGet]
        public IActionResult MovieDetails(int id)
        {
            Models();
            var genres = c.Genres.ToList();
            var ratings = c.m_Comments.Where(d => d.MovieId.Equals(id)).ToList();//seçili olan movieId ye göre yorum puanlarını alıyoruz.
            if (ratings.Count()>0 )//liste boş değilse..
            {
                var ratingSum = ratings.Sum(d => d.Rate);//listedeki puanları topluyoruz.
                var average = ratingSum / ratings.Count(); //toplamı liste uzunluğuna bölüp ortalamasını alıyoruz.
                average = Math.Round(average, 2); //Virgülden sonra 2 basamak alıyoruz.
                ViewBag.Average = average;
            }
            var imageUrl = c.Movies.Where(x => x.Id == id).Select(x => x.BackgroundURL).SingleOrDefault();
            ViewBag.imageUrl = imageUrl;
            ViewBag.x = id;
            return View(m);
        }

        // Film yorum yap
        [HttpPost]
        public IActionResult MovieDetails(int id, string Name, string Email, double Rate, String Comment)
        {
            M_CommentsViewModel mv = new M_CommentsViewModel();
            mv.MovieId = id;
            mv.NameSurname = Name;
            mv.Email = Email;
            mv.Status = false;
            mv.Rate = Rate;
            mv.Date = DateTime.Now;
            mv.Comment = Comment;
            c.m_Comments.Add(mv);
            c.SaveChanges();
            ModelState.Clear();
            return RedirectToAction("MovieDetails",id);
        }

        [HttpGet]
        public IActionResult SeriesDetails(int id)
        {
            Models();
            var genres = c.Genres.ToList();
            var ratings = c.s_Comments.Where(d => d.SeriesId.Equals(id)).ToList();//seçili olan movieId ye göre yorum puanlarını alıyoruz.
            if (ratings.Count() > 0)//listede değer varsa
            {
                var ratingSum = ratings.Sum(d => d.Rate);//listedeki rate leri topluyoruz.
                var average = ratingSum / ratings.Count(); //toplamı liste uzunluğuna bölüp ortalamasını alıyoruz.
                average = Math.Round(average, 2); //Virgülden sonra 2 basamak alıyoruz.
                ViewBag.Average = average;
            }
            var imageUrl = c.Series.Where(x => x.Id == id).Select(x => x.BackgroundURL).SingleOrDefault();
            ViewBag.imageUrl = imageUrl;
            ViewBag.x = id;
            return View(m);
        }

        // Dizi yorum yap
        [HttpPost]
        public IActionResult SeriesDetails(int id, string Name, string Email, double Rate, String Comment)
        {
            S_CommentsViewModel sv = new S_CommentsViewModel();
            sv.SeriesId = id;
            sv.NameSurname = Name;
            sv.Email = Email;
            sv.Status = false;
            sv.Rate = Rate;
            sv.Date = DateTime.Now;
            sv.Comment = Comment;
            c.s_Comments.Add(sv);
            c.SaveChanges();
            ModelState.Clear();
            return RedirectToAction("SeriesDetails", id);
        }

        public IActionResult UserAgreement()
        {
            return View();
        }
    }
}
