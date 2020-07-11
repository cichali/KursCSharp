using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Typy
{
    class Program
    {
        static void GiveName(ref Diary diary)
        {
            diary = new Diary();
            diary.Name = "Nowy dzienniczek Marcina";
        }

        static void IncrementNumber(ref int number)
        {
            number = 42;
        }
        static void Main(string[] args)
        {
            //PassByValueAndRef();

            Immutable();
        }

        private static void Immutable()
        {
            string name = " Marcin ";
            name = name.Trim();

            DateTime date = new DateTime(2015, 3, 10);
            date = date.AddHours(48);

            Console.WriteLine(name);
            Console.WriteLine(date);
        }

        private static void PassByValueAndRef()
        {
            Diary d1 = new Diary();
            Diary d2 = d1;

            GiveName(ref d2);

            Console.WriteLine(d2.Name);

            int x1 = 4;
            IncrementNumber(ref x1);

            Console.WriteLine(x1);
        }
    }
}
