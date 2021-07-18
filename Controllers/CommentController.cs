using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MovieApp.Models.Context;
using MovieApp.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieApp.Controllers
{
    [Authorize(Roles = "Admin,Moderator,User")]
    public class CommentController : Controller
    {
        Context c = new Context();       

        // aktif film yorum listesi
        public IActionResult ActiveMovieComments()
        {
            var comments = c.m_Comments.ToList();
            return View(comments);
        }
        // inaktif film listesi
        public IActionResult InactiveMovieComments()
        {
            var comments = c.m_Comments.ToList();
            return View(comments);
        }

        // Film yorumu aktif hale getir
        public IActionResult MovieCommentActive(int id)
        {
            var x = c.m_Comments.Find(id);
            x.Status = true;
            c.SaveChanges();
            return RedirectToAction("InactiveMovieComments");
        }

        // Film yorumu pasif hale getir
        public IActionResult MovieCommentInactive(int id)
        {
            var x = c.m_Comments.Find(id);
            x.Status = false;
            c.SaveChanges();
            return RedirectToAction("ActiveMovieComments");
        }

        // Film yorum sil
        public IActionResult MovieCommentRemove(int id)
        {
            var x = c.m_Comments.Find(id);
            c.m_Comments.Remove(x);
            c.SaveChanges();
            return RedirectToAction("InactiveMovieComments");
        }


        // aktif dizi yorum listesi
        public IActionResult ActiveSeriesComments()
        {
            var comments = c.s_Comments.ToList();
            return View(comments);
        }
        // inaktif dizi listesi
        public IActionResult InactiveSeriesComments()
        {
            var comments = c.s_Comments.ToList();
            return View(comments);
        }

        // dizi yorumu aktif hale getir
        public IActionResult SeriesCommentActive(int id)
        {
            var x = c.s_Comments.Find(id);
            x.Status = true;
            c.SaveChanges();
            return RedirectToAction("InactiveSeriesComments");
        }

        // dizi yorumu pasif hale getir
        public IActionResult SeriesCommentInactive(int id)
        {
            var x = c.s_Comments.Find(id);
            x.Status = false;
            c.SaveChanges();
            return RedirectToAction("ActiveSeriesComments");
        }

        // dizi yorum sil
        public IActionResult SeriesCommentRemove(int id)
        {
            var x = c.s_Comments.Find(id);
            c.s_Comments.Remove(x);
            c.SaveChanges();
            return RedirectToAction("InactiveSeriesComments");
        }
    }
}
