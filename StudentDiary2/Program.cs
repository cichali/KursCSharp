using System;
using System.Speech.Synthesis;

namespace StudentDiary2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Diary diary = new Diary();

            //diary.AddRating(3f);
            //diary.AddRating(5f);
            //diary.AddRating(11f);

            //Console.WriteLine(Diary.maxGrade);

            //Diary diary2 = new Diary();
            //Diary diary3 = new Diary();
            //Diary diary4 = new Diary();
            //Diary diary5 = new Diary();
            //Diary diary6 = new Diary();

            //Console.WriteLine(Diary.count);

            SpeechSynthesizer synt = new SpeechSynthesizer();
            synt.Speak("Cześć Kubuś");
        }
    }
}
