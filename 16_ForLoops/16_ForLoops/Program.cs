using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_ForLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            //for (int i = 1; i <= 5; i++) //similar to while loop except everything is inside the paranthesis
            //{
                //Console.WriteLine(i);
            //}

            int[] luckynumbers = { 12, 23, 34, 45, 56 };
            for (int i = 0; i < luckynumbers.Length; i++)
            {
                Console.WriteLine(luckynumbers[i]);
            }

            Console.ReadLine();
        }
    }
}
