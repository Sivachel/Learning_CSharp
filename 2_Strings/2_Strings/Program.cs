using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Giraffe \nAcademy"); //to break string into two lines
            Console.WriteLine("Giraffe \"Academy"); //to insert quotation mark

            string phrase = "Giraffe Academy";
            Console.WriteLine(phrase.Length ); //to find the length of the string 
            Console.WriteLine(phrase.ToUpper()); //uses the ToUpper method
            Console.WriteLine(phrase.ToLower()); //uses the ToLower method 
            Console.WriteLine(phrase.Contains("Academy")); //uses the Contains method
            Console.WriteLine(phrase[2]); //finds the character using the index number
            Console.WriteLine(phrase.IndexOf("Academy")); //finds the index number of where the A starts
            Console.WriteLine(phrase.IndexOf("f")); //finds the index number of f
            Console.WriteLine(phrase.Substring(8, 3)); //first number indicates the index number , 2nd how many characters
            

            Console.ReadLine();

        }
    }
}
