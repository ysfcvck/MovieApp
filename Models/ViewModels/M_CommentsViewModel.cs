using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MovieApp.Models.ViewModels
{
    public class M_CommentsViewModel
    {
        public int Id { get; set; }


        [Display(Name = "Name")]
        public string NameSurname { get; set; }


        [Display(Name = "Email")]
        public string Email { get; set; }


        public int MovieId { get; set; }
        public bool Status { get; set; }
        public DateTime Date { get; set; }

        [Display(Name = "Rate")]
        public double Rate { get; set; }


        [Display(Name = "Comment")]
        public string Comment { get; set; }

        public virtual MovieViewModel Movie { get; set; }
    }
}
