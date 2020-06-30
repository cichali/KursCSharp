using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentDiary
{
    class Program
    {
        static void Main(string[] args)
        {
            Diary diary = new Diary(); //tworzymy nowy obiekt klasy Diary

            //diary.AddRating(5);
            //diary.AddRating(8.5f);
            //diary.AddRating(4.7f);

            //float avg = diary.CalcAverage();
            //float max = diary.GetMaxRating();
            //float min = diary.GetMinRating();

            for (; ;)
            {
                Console.WriteLine("Wpisz ocenę z zakresu 1-10");

                float rating = 0;
                bool result = float.TryParse(Console.ReadLine(), out rating); //Wprowadzanie oceny w konsoli

                if (rating == 11) //Wyjście z pętli przy ocenie 11
                {
                    break;
                }

                if (result == true) //Sprawdzenie czy wprowadzona wartość jest liczbą
                {
                    if (rating >=1 && rating <=10) //Sprawdzenie czy liczba mieści się w zakresie
                    {
                        diary.AddRating(rating); //Dodanie oceny do dzienniczka
                    }
                    else
                    {
                        Console.WriteLine("Liczba niepoprawna");
                    }
                }            
            }


            Console.WriteLine("Średnia twoich ocen to: " + diary.CalcAverage());
            Console.WriteLine("Najwyższa ocena to: " + diary.GetMaxRating());
            Console.WriteLine("Najniższa ocena to: " + diary.GetMinRating());
            Console.ReadKey();

        }
    }
}
