using Microsoft.EntityFrameworkCore;
using MovieApp.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieApp.Models.Context
{
    public class Context:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-68O6AVP\\SQLEXPRESS;Database=MovieAppDb;Trusted_Connection=True;");
        }

        public DbSet<MovieViewModel> Movies { get; set; }
        public DbSet<GenreViewModel> Genres { get; set; }
        public DbSet<SeriesViewModel> Series { get; set; }
        public DbSet<StatusViewModel> Statuses { get; set; }
        public DbSet<M_CommentsViewModel> m_Comments { get; set; }
        public DbSet<S_CommentsViewModel> s_Comments { get; set; }
    }
}
