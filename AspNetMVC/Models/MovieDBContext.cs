using AspNetMVC.Models.Movies;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace AspNetMVC.Models
{
    public class MovieDBContext : DbContext
    {
        public MovieDBContext() : base("DefaultConnection")
        {
        }
        public DbSet<Movie> MovieTitles { get; set; }
        public DbSet<Actor> ActorNames { get; set; }
        public DbSet<Crew> CrewNames { get; set; }
        //public DbSet<CrewTitle> CrewTitles { get; set; }
        public DbSet<Detail> Details { get; set; }
        //public DbSet<Category> CategoryTitles { get; set; }
    }

}