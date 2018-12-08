using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_ReturnStatement
{
    class Program
    {
        static void Main(string[] args)
        {
            int CubedNumber = cube(5);
            Console.WriteLine(CubedNumber);
            //or 
            Console.WriteLine(cube(5));
            Console.ReadLine();
        }

        static int cube(int num)
        {
            int result = num * num * num;
            return result; //returns information back to the caller
        }
    }
}
