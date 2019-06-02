using System;

namespace mvccore.Models
{
    public class Movie
    {
        public int Id {get; set;}
        public string Name {get; set;}
        public string Description {get; set;}
        public string ImgUrl {get; set;}

        public double imdbpoint {get; set;}
        public DateTime UploadDate {get; set;}
    }
}