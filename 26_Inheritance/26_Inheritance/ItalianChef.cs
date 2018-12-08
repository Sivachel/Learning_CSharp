using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26_Inheritance
{
    class ItalianChef : Chef // inherits all the attributes from the chef
    {
        public void MakePasta()
        {
            Console.WriteLine("Chef makes Pasta");
        }

        public override void MakeSpecialDish() //override is used to overide method in sub class
        {
            Console.WriteLine("The Chef makes chicken parm");
        }
    }
}
