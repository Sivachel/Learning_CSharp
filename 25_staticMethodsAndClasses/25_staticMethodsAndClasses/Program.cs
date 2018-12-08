using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25_staticMethodsAndClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            UsefulTools.SayHi("Mike"); //Static method can be accessed without creating an instance of itself
            Console.ReadLine();
        }
    }
}
