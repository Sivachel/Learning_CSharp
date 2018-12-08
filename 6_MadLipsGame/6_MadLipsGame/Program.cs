using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_MadLipsGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a color: ");
            string color = Console.ReadLine();
            Console.Write("Enter a plural Noun: ");
            string pluralNoun = Console.ReadLine();
            Console.Write("Enter a celebrity name: ");
            string celebrityName = Console.ReadLine();

            Console.WriteLine("Roses are " + color);
            Console.WriteLine(pluralNoun + " are blue");
            Console.WriteLine("I Love " + celebrityName);

            Console.ReadLine();
        }
    }
}
