using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.Write("Enter a number: ");
            //int num1 = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Enter another number: ");
            //int num2 = Convert.ToInt32(Console.ReadLine());

            // to allow decimals use double and convert to double
            Console.Write("Enter a number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter another number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(num1 + num2);

            Console.ReadLine();

        }
    }
}
