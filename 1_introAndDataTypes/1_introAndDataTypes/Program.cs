using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_introAndDataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            string characterName = "John"; //creating a variable, string in this case 
            int characterAge = 35; //creating an int variable

            Console.WriteLine("Hello World"); //to print out a line and order of the line matters
            Console.WriteLine("There was once a man named " + characterName); //Cancatinating a string
            Console.WriteLine("He was " + characterAge + " years old");

            characterName = "Mike"; //variable can be changed at any time

            Console.WriteLine("He really liked the name " + characterName);
            Console.WriteLine("But didn't like being " + characterAge);

            Console.ReadLine(); //waits for input from user




            //Data types
            string phrase = "Giraffe academy";
            char grade = 'A'; //to save a single character
            int age = 30; //no quotes required, also neagtive numbers. sub types ==> float, double, decimal
            double gpa = 3.3; // has to have a decimal when using double.
            bool isMale = true;

        }
    }
}
