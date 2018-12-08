using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_2dArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] numberGrid =
            {
                {1,2 },
                {3,4 },
                {5,6 }
            };
            int[,] myArray = new int[2, 3];//if we don't have the data we can just create the frameworl for it using this
            Console.WriteLine(numberGrid[2, 1]); // first number indicates the row, second number the character in the row

            Console.ReadLine();
        }
    }
}
