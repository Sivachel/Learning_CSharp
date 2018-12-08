using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23_GettersAndSetters
{
    class Movie
    {
        public string title;
        public string director;
        private string rating; //private => only the code inside of the movie class can access the rating

        public Movie(string aTitle,string aDirector,string aRating)
        {
            title = aTitle;
            director = aDirector;
            Rating = aRating;
        }

        public string Rating //property method
        {
            get // allow to access the rating
            {
                return rating;
            }
            set // setters limits what rating can be set
            {
                if(value == "G" || value == "PG" || value == "PG-13" || value == "R" || value == "NR")
                {
                    rating = value;
                }
                else
                {
                    rating = "NR";
                }
            }
        }
    }
}
