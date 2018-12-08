using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int [] luckynumbers = {4,8,15,16,23,42}; //to create an array use [] to indicate and {} to store
            Console.WriteLine(luckynumbers[0]);//use index number to access a string in an array
            luckynumbers[1] = 900; //to change the string in a array
            string[] friends = new string[10]; //can hold upto 10 values in the new array
            friends[0] = "Jim";
            friends[1] = "Kelly";


            Console.ReadLine();
        }
    }
}
