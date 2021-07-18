using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MovieApp.Models.ViewModels
{
    public class SeriesViewModel
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Bu alan boş bırakılamaz..")]
        public string Name { get; set; }


        [Required(ErrorMessage = "Bu alan boş bırakılamaz..")]
        public int ReleaseYear { get; set; }


        [Required(ErrorMessage = "Bu alan boş bırakılamaz..")]
        public int GenreId { get; set; }


        [Required(ErrorMessage = "Bu alan boş bırakılamaz..")]
        public string Season { get; set; }


        [Required(ErrorMessage = "Bu alan boş bırakılamaz..")]
        public string Status { get; set; }


        [Required(ErrorMessage = "Bu alan boş bırakılamaz..")]
        public double Rating { get; set; }


        [Required(ErrorMessage = "Bu alan boş bırakılamaz..")]
        public string AgeRestriction { get; set; }


        [Required(ErrorMessage = "Bu alan boş bırakılamaz..")]
        public string Director { get; set; }


        [Required(ErrorMessage = "Bu alan boş bırakılamaz..")]
        public string Writer { get; set; }


        [Required(ErrorMessage = "Bu alan boş bırakılamaz..")]
        public string Cast { get; set; }


        [Required(ErrorMessage = "Bu alan boş bırakılamaz..")]
        public string Description { get; set; }


        [Required(ErrorMessage = "Bu alan boş bırakılamaz..")]
        public string ImageURL { get; set; }


        [Required(ErrorMessage = "Bu alan boş bırakılamaz..")]
        public string VideoURL { get; set; }

        public string BackgroundURL { get; set; }

        public virtual GenreViewModel Genre { get; set; }
    }
}

