using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Typy
{
    class Program
    {
        static void Main(string[] args)
        {
            Diary d1 = new Diary();
            Diary d2 = d1;

            d1 = new Diary();

            d1.Name = "Dzienniczek Emilki";

            Console.WriteLine(d2.Name);

            int x1 = 4;
            int x2 = x1;
            x1 = 100;
            Console.WriteLine(x2);

        }
    }
}
