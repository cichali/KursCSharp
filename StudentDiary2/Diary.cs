using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentDiary2
{
    class Diary
    {
        public Diary()
        {
            ratings = new List<float>(); //Utworzenie listy ocen
        }

        //Stan (zmienne - pola)
        List<float> ratings;

        //Zachowania
        ///<summary>
        ///Metoda dodająca oceny do listy
        ///</summary>>
        public void AddRating(float rating) 
        {
            ratings.Add(rating);
        }

        internal DiaryStatistics ComputeStatistics()
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
