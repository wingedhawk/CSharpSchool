using System;
using System.Collections.Generic;
using System.Text;

namespace Opdracht2Week1.Models
{

    class MultipleChoiceQuestion : IVraag
    {
        public int Moeilijkheidsgraad { get; set; }
        public string CategorieString { get; set; }
        public string Antwoord { get; set; }
        public string VraagString { get; set; }
        //public List<String> falseAnswers { get; set; }

        public MultipleChoiceQuestion(int Moeilijkheidsgraad, string CategorieString, string Antwoord, string vraagString)
        {
            this.Moeilijkheidsgraad = Moeilijkheidsgraad;
            this.CategorieString = CategorieString;
            this.Antwoord = Antwoord;
            this.VraagString = vraagString;
            //this.falseAnswers = falseAnswers;
        }



    }


}
