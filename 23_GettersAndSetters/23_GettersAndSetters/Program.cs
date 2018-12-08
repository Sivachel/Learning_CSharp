using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23_GettersAndSetters
{
    class Program
    {
        static void Main(string[] args)
        {
            Movie avengers = new Movie("The Avengers", "Josh Whedon", "PG-13");
            Movie shrek = new Movie("Shrek", "Adam Adamson", "PG");

            avengers.Rating = "R"; //still can be changed but only using a property method Rating 
            Console.WriteLine(avengers.Rating);
            Console.ReadLine();
        }
    }
}
