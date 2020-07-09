using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentDiary2
{
    class Diary
    {
        public Diary() //konstruktor
        {
            ratings = new List<float>(); //utworzenie listy ocen
            count++; //zwiększenie licznika wywołań konstruktora
        }

        //Stan (zmienne - pola)
        private List<float> ratings; //lista ocen

        public static float minGrade = 0;
        public static float maxGrade = 10;
        public static long count = 0; //licznik wywołań kostruktora

        //Zachowania
        ///<summary>
        ///Dodanie ocen do listy
        ///</summary>>
        public void AddRating(float rating) 
        {
            if (rating >= 0 && rating <=10) //sprawdzenie poprawności wprowadzanej oceny
            {
                ratings.Add(rating);
            }
            
        }

        ///<summary>
        ///Wyliczenie statystyk dzienniczka
        ///</summary>>
        public DiaryStatistics ComputeStatistics()
        {
            DiaryStatistics stats = new DiaryStatistics();

            float sum = 0f; //zmienne pomocnicza

            foreach (var rating in ratings) //pętla sumująca elementy listy
            {
                sum += rating;
            }

            stats.averageGrade = sum / ratings.Count(); //wyliczenie średniej

            stats.maxGrade = ratings.Max(); //najwyższa ocena
             
            stats.minGrade = ratings.Min(); //najniższa ocena

            return stats;
        }

    }
}
