using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26_Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Chef chef = new Chef();
            chef.MakeChicken();
            chef.MakeSpecialDish();

            ItalianChef italianChef = new ItalianChef(); //in this case the chef is superclass and italianchef is subclass
            italianChef.MakeChicken();
            italianChef.MakePasta();
            italianChef.MakeSpecialDish();


            Console.ReadLine();
        }
    }
}
