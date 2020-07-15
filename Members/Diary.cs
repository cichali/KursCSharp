using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Members
{
    public class Diary
    {
        public Diary() //konstruktor
        {
            ratings = new List<float>(); //utworzenie listy ocen
            Count++; //zwiększenie licznika wywołań konstruktora
        }

        //Stan (zmienne - pola)
        private List<float> ratings; //lista ocen

        public static float MinGrade = 0;
        public static float MaxGrade = 10;
        public static long Count = 0; //licznik wywołań kostruktora

        private string _name;

        public string Name
        {
            get
            {
                return _name.ToUpper();
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _name = value;
                }
            }
        }

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

            stats.AverageGrade = sum / ratings.Count(); //wyliczenie średniej

            stats.MaxGrade = ratings.Max(); //najwyższa ocena
             
            stats.MinGrade = ratings.Min(); //najniższa ocena

            return stats;
        }

    }
}
