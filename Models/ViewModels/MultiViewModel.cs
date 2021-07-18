using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using X.PagedList;

namespace MovieApp.Models.ViewModels
{
    public class MultiViewModel
    {
        public IEnumerable<MovieViewModel> movieViewModels { get; set; }
        public IEnumerable<SeriesViewModel> seriesViewModels { get; set; }
        public IEnumerable<GenreViewModel> genreViewModels { get; set; }
        public IEnumerable<M_CommentsViewModel> M_CommentsViewModel { get; set; }
        public IEnumerable<S_CommentsViewModel> s_CommentsViewModels { get; set; }

        public string Rate { get; set; } //Kullanıcı puanları
        public List<SelectListItem> Rates { get; } = new List<SelectListItem>
        {
        new SelectListItem { Value = "1", Text = "1" },
        new SelectListItem { Value = "2", Text = "2" },
        new SelectListItem { Value = "3", Text = "3" },
        new SelectListItem { Value = "4", Text = "4" },
        new SelectListItem { Value = "5", Text = "5" },
        new SelectListItem { Value = "6", Text = "6" },
        new SelectListItem { Value = "7", Text = "7" },
        new SelectListItem { Value = "8", Text = "8" },
        new SelectListItem { Value = "9", Text = "9" },
        new SelectListItem { Value = "10", Text = "10" },
        };
    }
}
