using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(50); //simply prints out 50 
            Console.WriteLine(5 + 8); //can do maths problems straight including + - * / %
            Console.WriteLine(4 + 2 * 10); //happens in the order of operations
            int num = 6;
            num++; // increases the numbe by 1, -- decreases by 1
            //using math methods
            Console.WriteLine(Math.Abs(-40)); //gives the absoulte value
            Console.WriteLine(Math.Pow(3,2)); //power number
            Console.WriteLine(Math.Sqrt(36)); // square root
            Console.WriteLine(Math.Max(4,90)); //gives the bigger number
            Console.WriteLine(Math.Round(4.3)); //rounds the number
            Console.WriteLine();




            Console.ReadLine();
        }
    }
}
