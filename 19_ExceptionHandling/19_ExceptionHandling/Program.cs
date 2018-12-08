using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            try //this is where all the risky codes go in
            {
                Console.Write("Enter a number: ");
                int num1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter another number: ");
                int num2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine(num1 / num2);
                Console.ReadLine();
            }
            /*
            catch(Exception error) // this can be used to throw the error message
            {
                Console.WriteLine(error.Message); //prints the error the message
            }
            */
            catch(DivideByZeroException error) //catches only the specified exception
            {
                Console.WriteLine(error.Message);
            }
            catch(FormatException error) //catches only the specified exception
            {
                Console.WriteLine(error.Message);
            }
            finally
            {
                //any code here will be executed no matter what
            }

            Console.ReadLine();

        }
    }
}
