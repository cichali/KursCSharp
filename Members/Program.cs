using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Members
{
    class Program
    {
        static void Main(string[] args)
        {
            #region stary kod
            //Diary diary = new Diary();

            //diary.AddRating(3.5f);
            //diary.AddRating(5.4f);
            //diary.AddRating(8.4f);

            //DiaryStatistics stats = diary.ComputeStatistics();
            ////WriteResult("Average", stats.AverageGrade, 3, 5, 7 ,8 ,9);
            ////WriteResult("Max", (int)stats.MaxGrade);
            ////WriteResult("Min", (long)stats.MinGrade, 1);

            //diary.NameChanged += OnNameChanged;
            //diary.NameChanged += OnNameChanged2;
            //diary.NameChanged += OnNameChanged2;

            //try
            //{
            //    Console.WriteLine("Podaj nazwę: ");
            //    diary.Name = Console.ReadLine();
            //}
            //catch (ArgumentException ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            //catch (NullReferenceException)
            //{
            //    Console.WriteLine("Coś poszło nie tak");
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}

            //diary.Name = "Dzienniczek Kuby";
            //diary.Name = "Jacek";
            //Console.WriteLine(diary.Name);
            #endregion

            StreamWriter file = new StreamWriter("plik.txt");

            try
            {
                file.WriteLine("Witaj, piszemy do pliku tekstowego.");
            }
            finally
            {
                file.Close();
            }

            using (StreamWriter file2 = new StreamWriter("plik.txt", true))
            {
                file2.WriteLine("Witaj, piszemy do pliku tekstowego.");
            }
        }

        private static void OnNameChanged(object sender, NameChangedEventArgs args)
        {
            Console.WriteLine($"Zmiana nazwy z {args.ExistingName} na {args.NewName}");
        }

        private static void OnNameChanged2(object sender, NameChangedEventArgs args)
        {
            Console.WriteLine("************************************************");
        }

        static void WriteResult(string description, params float[] result)
        {
            Console.WriteLine(description + ": " + result);
        }

        static void WriteResult(string description, int result)
        {
            Console.WriteLine(description + ": " + result);
        }

        static void WriteResult(string description, long result)
        {
            Console.WriteLine(description + ": " + result);
        }

        static void WriteResult(string description, long result, long test)
        {
            Console.WriteLine(description + ": " + result);
        }
    }
}
