using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MovieApp.Models.Authentication
{
    public class AppUser : IdentityUser<int>
    {
        public string NameSurname { get; set; }
    }
}
