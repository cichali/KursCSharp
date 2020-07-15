using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Members
{
    class Program
    {
        static void Main(string[] args)
        {
            Diary diary = new Diary();
            diary.AddRating(3.5f);
            diary.AddRating(5.4f);
            diary.AddRating(8.4f);

            DiaryStatistics stats = diary.ComputeStatistics();
            //WriteResult("Average", stats.AverageGrade, 3, 5, 7 ,8 ,9);
            //WriteResult("Max", (int)stats.MaxGrade);
            //WriteResult("Min", (long)stats.MinGrade, 1);

            diary.Name = "Dzienniczek Kuby";
            diary.Name = "";
            diary.Name = null;
            Console.WriteLine(diary.Name);
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
