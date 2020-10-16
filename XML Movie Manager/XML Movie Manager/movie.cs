using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XML_Movie_Manager
{
    public class Movie
    {
        public string Genre { get; set; }
        public string Title { get; set; }
        public int Year { get; set; }
        public string Length { get; set; }
        public string Director { get; set; }
        public string Rating { get; set; }
        public string FilePath { get; set; }

        public Movie(string genre, string title, int year, string length, string director, string rating, string filepath)
        {
            Genre = genre;
            Title = title;
            Year = year;
            Length = length;
            Director = director;
            Rating = rating;
            FilePath = filepath;
        }

        public Movie()
        {
            Genre = "";
            Title = "";
            Year = 0;
            Length = "";
            Director = "";
            Rating = "";
            FilePath = "";
        }
    }
}
