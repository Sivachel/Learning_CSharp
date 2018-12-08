using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_GettingUserInput
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your Name: "); //write stays in same line, WriteLine moves to next line
            string name = Console.ReadLine();
            Console.Write("Enter you age: ");
            string age = Console.ReadLine();
            Console.WriteLine("Hello " + name + "You are "+ age);
            Console.ReadLine();
        }
    }
}
