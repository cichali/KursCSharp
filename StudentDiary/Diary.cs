using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentDiary
{
    class Diary
    {
        //Stan (zmienne - pola)

        List<float> ratings = new List<float>(); ///Utworzenie listy przechowująca zmienne typu float (oceny)

        //Zachowania

        ///<summary>
        ///Metoda dodająca oceny do listy
        ///</summary>>
        public void AddRating(float rating) 
        {
            ratings.Add(rating);
        }

        ///<summary>
        ///Metoda wyliczająca średnią
        ///</summary>>
        public float CalcAverage()
        {
            float sum = 0, avg = 0; //zmienne pomocnicza

            foreach (var rating in ratings) //pętla sumująca elementy listy
            {
                sum += rating;
            }

            avg = sum / ratings.Count(); //wyliczenie średniej

            return avg;
        }

        ///<summary>
        ///Metoda zwracająca najwyższą ocenę
        ///</summary>>
        public float GetMaxRating()
        {
            return ratings.Max();
        }

        ///<summary>
        ///Metoda zwracająca najniższą ocenę
        ///</summary>>
        public float GetMinRating()
        {
            return ratings.Min();
        }

    }
}
