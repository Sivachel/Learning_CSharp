using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            SayHi("Mike", 35); //calling a method


            Console.ReadLine();
        }

        static void SayHi(string name, int age) // void method returns nothing 
        {
            Console.WriteLine("Hello "+name + " .you are " + age);
        }
    }
}
