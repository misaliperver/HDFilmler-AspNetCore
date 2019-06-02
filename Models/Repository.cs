using System;
using System.Collections.Generic;
using System.Linq;

namespace mvccore.Models
{
    public class Repository
    {
        private static List<Movie> _movies = null;

        static Repository() {
            _movies = new List<Movie>()
            {
                new Movie() {   Id = 1 , Name = "Shazam", ImgUrl = "/images/movies/shazam.jpg", imdbpoint = 6.7,
                    Description = "We all have a superhero inside of us -- it just takes a bit of magic to bring it out. In 14-year-old Billy Batson's case, all he needs to do is shout out one word to transform into the adult superhero Shazam. Still a kid at heart, Shazam revels in the new version of himself by doing what any other teen would do -- have fun while testing out his newfound powers. But he'll need to master them quickly before the evil Dr. Thaddeus Sivana can get his hands on Shazam's magical abilities.",
                    UploadDate = new DateTime(2019, 5, 28) },
                new Movie() {   Id = 2 , Name = "DeadPool", ImgUrl = "/images/movies/deadpool.jpeg", imdbpoint = 8,
                    Description = "Wade Wilson (Ryan Reynolds) is a former Special Forces operative who now works as a mercenary. His world comes crashing down when evil scientist Ajax (Ed Skrein) tortures, disfigures and transforms him into Deadpool. The rogue experiment leaves Deadpool with accelerated healing powers and a twisted sense of humor. With help from mutant allies Colossus and Negasonic Teenage Warhead (Brianna Hildebrand), Deadpool uses his new skills to hunt down the man who nearly destroyed his life.",
                    UploadDate = new DateTime(2019, 4, 23) },
                new Movie() {   Id = 3 , Name = "Avengers Ininity War", ImgUrl = "/images/movies/avengersinfinitiy.jpeg", imdbpoint = 8.5,
                    Description = "Iron Man, Thor, the Hulk and the rest of the Avengers unite to battle their most powerful enemy yet -- the evil Thanos. On a mission to collect all six Infinity Stones, Thanos plans to use the artifacts to inflict his twisted will on reality. The fate of the planet and existence itself has never been more uncertain as everything the Avengers have fought for has led up to this moment.",
                    UploadDate = new DateTime(2019, 4, 23) },
                new Movie() {   Id = 4 , Name = "Titanic", ImgUrl = "/images/movies/titanic.jpg", imdbpoint = 7.8,
                    Description = "James Cameron's 'Titanic' is an epic, action-packed romance set against the ill-fated maiden voyage of the R.M.S. Titanic; the pride and joy of the White Star Line and, at the time, the largest moving object ever built. She was the most luxurious liner of her era -- the 'ship of dreams' -- which ultimately carried over 1,500 people to their death in the ice cold waters of the North Atlantic in the early hours of April 15, 1912.",
                    UploadDate = new DateTime(2019, 4, 23)  },
                new Movie() {   Id = 5 , Name = "The Ring", ImgUrl = "/images/movies/thering.jpg", imdbpoint = 7.1,
                    Description = "It sounds like just another urban legend -- a videotape filled with nightmarish images leads to a phone call foretelling the viewer's death in exactly seven days. Newspaper reporter Rachel Keller (Naomi Watts) is skeptical of the story until four teenagers all die mysteriously exactly one week after watching just such a tape. Allowing her investigative curiosity to get the better of her, Rachel tracks down the video and watches it. Now she has just seven days to unravel the mystery.",
                    UploadDate = new DateTime(2019, 4, 23)  },
                new Movie() {   Id = 6 , Name = "The Lord of the Rings: The Fellowship of the Ring", ImgUrl = "/images/movies/theloardofrings.jpeg", imdbpoint = 9.5,
                    Description = "The future of civilization rests in the fate of the One Ring, which has been lost for centuries. Powerful forces are unrelenting in their search for it. But fate has placed it in the hands of a young Hobbit named Frodo Baggins (Elijah Wood), who inherits the Ring and steps into legend. A daunting task lies ahead for Frodo when he becomes the Ringbearer - to destroy the One Ring in the fires of Mount Doom where it was forged.",
                    UploadDate = new DateTime(2019, 4, 23)  },
                new Movie() {   Id = 7 , Name = "The Fast and the Furious", ImgUrl = "/images/movies/fastandfourius.jpg", imdbpoint = 8.3,
                    Description = "The Fast and the Furious is an American media franchise centered on a series of action films that is largely concerned with illegal street racing, heists and espionage. The franchise also includes short films, a television series, live shows, and theme park attractions. It is distributed by Universal Pictures.",
                    UploadDate = new DateTime(2019, 4, 23)  },
            };
        }

        public static List<Movie> Movies{
            get
            {
                return _movies;
            }
        }

        public static void AddMovie(Movie entity){
            _movies.Add(entity);
        }

        public static Movie GetById(int id){
            return _movies.FirstOrDefault(i => i.Id == id);
        }

    }
}