using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_IfStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isMale = true;
            bool isTall = true;

            if (isMale && isTall) // operators && both conditons true || or operator only one need to be true
            {
                Console.WriteLine("You are male and tall");
            } else if(isMale && !isTall)
            {
                Console.WriteLine("You are a short Male");
            } else if (!isMale && isTall)
            {
                Console.WriteLine("You are tall but not male");
            }
            else
            {
                Console.WriteLine("you are either not male nor tall");
            }


            Console.ReadLine();
        }
    }
}
