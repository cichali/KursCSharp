using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Hello
{
    class Program
    {
        static void Main(string[] args)
        {
            for (; ;) //nieskończona pętla
            {
                Greeting();
                CheckAge();
                Settings();
            }
        }

        ///<summary>
        ///ustawienia konsoli
        ///</summary>
        private static void Settings()
        {
            Console.ReadKey(); //oczekuje na wciśnięcie klawisza
            Console.Clear();
            Console.ResetColor();
        }
        ///<summary>
        ///sprawdzanie wieku użytkownika
        ///</summary>
        private static void CheckAge()
        {
            Console.Write("Podaj swój wiek: ");
            int age;
            bool result = int.TryParse(Console.ReadLine(), out age); //zamiana string na int

            if (age >= 18)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Jesteś pełnoletni");
            }
            else if (result == false) // sprawdzenie czy wprowadzony wiek jest poprawny
            {
                Console.WriteLine("Źle wpisano wiek");
            }
            else
            {
                Console.WriteLine("Nie jesteś pełnoletni");
            }
        }
        ///<summary>
        ///witanie użytkownika
        ///</summary>
        private static void Greeting()
        {
            Console.Write("Wpisz swoje imię: ");
            string name = Console.ReadLine();

            Console.WriteLine("Witaj " + name);
        }
    }
}
