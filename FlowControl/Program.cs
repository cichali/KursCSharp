﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowControl
{
    class Program
    {
        private static int age;
        private static string name;

        static void Main(string[] args)
        {
            //InstructionIf();
            //InstructionSwitch();



            Console.ReadKey();
        }

        private static void InstructionSwitch()
        {
            Console.WriteLine("Podaj swoje imię");
            name = Console.ReadLine();

            switch (name)
            {
                case "Marcin":
                    Method1();
                    break;
                case "Tomek":
                    Method2();
                    Method3();
                    break;
                default:
                    Method4();
                    break;
            }
        }

        private static void InstructionIf()
        {
            Console.WriteLine("Podaj swój wiek");
            age = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj swoje imię");
            name = Console.ReadLine();

            string test = age > 18 ? "Pełnoletni" : "Dziecko";
            Console.WriteLine(test);

            if (age <= 10)
            {
                if (name == "Kuba")
                {
                    Method1();
                }
            }
            else if (age < 20)
            {
                Method2();
            }
            else if (age < 30)
            {
                Method3();
            }
            else
            {
                Method4();
            }
        }

        private static void Method4()
        {
            Console.WriteLine("Metoda 4");
        }

        private static void Method3()
        {
            Console.WriteLine("Metoda 3");               
        }

        private static void Method2()
        {
            Console.WriteLine("Metoda 2");
        }

        private static void Method1()
        {
            Console.WriteLine("Metoda 1");        
        }
    }
}
