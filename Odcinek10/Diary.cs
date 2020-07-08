using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odcinek10
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
        ///<param name="rating">nowa ocena</param>
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
