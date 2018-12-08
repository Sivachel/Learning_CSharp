using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_SwitchStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(GetDay(0));
            Console.ReadLine();
        }

        static string GetDay(int dayNum)
        {
            string dayName;
            switch (dayNum)
            {
                case 0:
                    dayName = "Sunday";
                    break; // breaks out of the method
                case 1:
                    dayName = "Monday";
                    break;
                case 2:
                    dayName = "Tuesday";
                    break;
                case 3:
                    dayName = "Wednesday";
                    break;
                case 4:
                    dayName = "Thursday";
                    break;
                case 5:
                    dayName = "Friday";
                    break;
                case 6:
                    dayName = "Saturday";
                    break;
                default: //if none matches default is used 
                    dayName = "Invalid Day Number";
                    break;

            }

            return dayName;
        }
    }
}
