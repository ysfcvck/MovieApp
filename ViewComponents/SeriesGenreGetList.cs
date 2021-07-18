using Microsoft.AspNetCore.Mvc;
using MovieApp.Models.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieApp.ViewComponents
{
    public class SeriesGenreGetList : ViewComponent
    {
        Context c = new Context();
        public IViewComponentResult Invoke()
        {
            var genres = c.Genres.ToList();
            return View(genres);
        }
    }
}
