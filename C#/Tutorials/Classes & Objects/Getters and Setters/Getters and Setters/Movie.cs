using System;
using System.Collections.Generic;
using System.Text;

namespace Getters_and_Setters
{
    class Movie
    {
        public string title;
        public string director;
        private string rating;

        public Movie(string aTittle, string aDirector, string aRating )
        {
            title = aTittle;
            director = aDirector;
            Rating = aRating; 
        }

        public string Rating
        {
            get { return rating; }
            set
            {
                 if (value == "G" || value == "PG" || value == "R" || value == "PG-13")
                {
                    rating = value;
                } else
                {
                    rating = "NR";
                }
            }

        }

    }
}
