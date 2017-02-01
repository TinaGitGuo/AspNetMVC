using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AspNetMVC.Models.Movies
{
    public class MovieV
    {
        
            public MovieV() { }
            public Movie MovieTitle { get; set; }
            public Actor ActorNames { get; set; }
            public Crew CrewNamesTitles { get; set; }
            public Detail MovieCatDesc { get; set; }
            //public Category CategoryName { get; private set; }
            //public CrewTitle CrewTitleName { get; private set; }
            public string strMovieTitle { get; set; }
            public string strActorName { get; set; }
            public string strCrewName { get; set; }
            public string strCrewTitle { get; set; }
            public string strCategory { get; set; }
            public string strDescription { get; set; }
            public IEnumerable<string> Categories { set; get; }
            public int intCrewTitleID { get; set; }
            public int intCategoryID { get; set; }

            public MovieV(Movie Movies)
            {
                MovieTitle = Movies;
                ActorNames = new Actor();
                CrewNamesTitles = new Crew();
                MovieCatDesc = new Detail();
                //CategoryName = new Category();
                //CrewTitleName = new CrewTitle();
                strMovieTitle = "";
                strActorName = "";
                strCrewName = "";
                strCrewTitle = "";
                strDescription = "";
                strCategory = "";
                Categories = null;
                intCrewTitleID = -1;
                intCategoryID = -1;
            }
       
    }

    public partial class Movie
    {
        /// <summary>
        /// You will need to configure this module in the Web.config file of your
        /// web and register it with IIS before being able to use it. For more information
        /// see the following link: http://go.microsoft.com/?linkid=8101007
        /// </summary>
        //#region IHttpModule Members
        //public void Dispose()
        //{
        // //clean-up code here.
        //}
        //public void Init(HttpApplication context)
        //{
        // // Below is an example of how you can handle LogRequest event and provide 
        // // custom logging implementation for it
        // context.LogRequest += new EventHandler(OnLogRequest);
        //}
        //#endregion
        [Key]
        public int MovieID { get; set; }
        [Required]
        [StringLength(100, ErrorMessage = "Name cannot be longer than 100 characters")]
        [Display(Name = "Movie: ")]
        public string MovieTitle { get; set; }
        public virtual ICollection<Actor> Actors { get; set; }
        public virtual ICollection<Crew> Crew { get; set; }
        public virtual ICollection<Detail> Detail { get; set; }
        //public IEnumerable<Category> Category { get; private set; }
        //public IEnumerable<CrewTitle> CrewTitle { get; private set; }
        public void OnLogRequest(Object source, EventArgs e)
        {
            //custom logging logic can go here
        }
    }
    public class Actor
    {
        public int MovieId { get; set; }
        public int ActorId { get; set; }
        [StringLength(50, ErrorMessage = "Actor cannot be longer than 50 characters")]
        [Required]
        [Display(Name = "Actor: ")]
        public string ActorName { get; set; }
        public virtual Movie Movie { get; set; }
    }
    public class Crew
    {
        public int MovieId { get; set; }
        public int CrewId { get; set; }
        public Nullable<int> CrewTitleId { get; set; }
        [StringLength(50, ErrorMessage = "Name cannot be longer than 50 characters")]
        [Required]
        [Display(Name = "Name: ")]
        public string CrewName { get; set; }
        public virtual Movie Movie { get; set; }
        //public virtual CrewTitle CrewTitle { get; set; }
    }
    public class Detail
    {
        public int MovieId { get; set; }
        public int DetailId { get; set; }
        public int CategoryID { get; set; }
        [Display(Name = "Description: ")]
        [StringLength(255, ErrorMessage = "Description cannot be longer than 255 characters")]
        public string Description { get; set; }
        public virtual Movie Movie { get; set; }
        //public virtual Category Category { get; set; }
    }
}