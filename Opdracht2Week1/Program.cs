using Opdracht2Week1.Models;
using System;
using System.Collections.Generic;

namespace Opdracht2Week1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IVraag> VragenLijst = new List<IVraag>() {
                new OpenVraag(1, "Alphabet", "H","Type de letter H"),
                new OpenVraag(1, "Alphabet", "B","Type de letter B"),
                new OpenVraag(3, "Alphabet", "A","AlphAbet"),
                new OpenVraag(3, "Alphabet", "AB","AB"),
                new OpenVraag(1, "Ascii", "66","A is 65 wat is B?"),
                new OpenVraag(1, "Ascii", "66","Wat was antwoord van vorige vraag"),
                new OpenVraag(2, "Ascii", "97","als A 65 wat is a in Ascii (tip er zitten 6 symbolen tussen A en a)"),
                new OpenVraag(2, "Ascii", "AB","65+66"),
            };

            Quiz myQuiz = new Quiz(VragenLijst);
            int mode = myQuiz.StartState();
            myQuiz.StartQuiz(myQuiz.InitMode(mode));

            Console.WriteLine("---Done---");
        }
    }
}
