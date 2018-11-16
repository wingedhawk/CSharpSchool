using System;
using System.Collections.Generic;
using System.Text;

namespace Opdracht2Week1.Models
{

    class MultipleChoiceQuestion : IQuestionAble
    {
        public int Moeilijkheidsgraad { get; set; }
        public string CategorieString { get; set; }
        public string Antwoord { get; set; }
        public string VraagString { get; set; }
        public List<String> FalseAnswers { get; set; }

        public MultipleChoiceQuestion(int Moeilijkheidsgraad, string CategorieString, string Antwoord, string vraagString, List<String> FalseAnswers)
        {
            this.Moeilijkheidsgraad = Moeilijkheidsgraad;
            this.CategorieString = CategorieString;
            this.Antwoord = Antwoord;
            this.VraagString = vraagString;
            this.FalseAnswers = FalseAnswers;
            this.FalseAnswers.Add(Antwoord);
            this.Shuffle();
        }

        public void Shuffle()
        {
            Random r = new Random();
            int randomIndex = 0;
            List<String> TempFalseAnswers = new List<String>();
            while (FalseAnswers.Count > 0)
            {
                randomIndex = r.Next(0, FalseAnswers.Count);
                TempFalseAnswers.Add(FalseAnswers[randomIndex]);
                FalseAnswers.RemoveAt(randomIndex);
            }
            FalseAnswers = TempFalseAnswers;
        }

        public void ShowAnswers()
        {
            Console.WriteLine("Type de volledig woord!");
            foreach(String s in FalseAnswers)
            {
                Console.WriteLine("- {0}",s);
            }
        }

    }


}
