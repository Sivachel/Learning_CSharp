using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24_StaticClassAttributes
{
    class Program
    {
        static void Main(string[] args)
        {
            Song holiday = new Song("Holiday", "Green Day", 200);
            Console.WriteLine(Song.songCount); //can be only access through class and not objects
            Song kashmir = new Song("Kashmir", "Led Zeppelin", 150);
            Console.WriteLine(Song.songCount);

            Console.ReadLine();
        }
    }
}
