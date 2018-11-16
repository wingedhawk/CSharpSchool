using Opdracht2Week1.Models;
using System;
using System.Collections.Generic;

namespace Opdracht2Week1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<String> FalseAnswers = new List<String>() { "NIET DEZE", "NIET DEZE", "NIET DEZE" };
            List<IQuestionAble> VragenLijst = new List<IQuestionAble>() {
                new MultipleChoiceQuestion(1, "Alphabet", "H","Type de letter H", new List<String>(FalseAnswers)),
                new MultipleChoiceQuestion(1, "Alphabet", "B","Type de letter B", new List<String>(FalseAnswers)),
                new MultipleChoiceQuestion(3, "Alphabet", "A","AlphAbet", new List<String>(FalseAnswers)),
                new MultipleChoiceQuestion(3, "Alphabet", "AB","AB", new List<String>(FalseAnswers)),
                new MultipleChoiceQuestion(1, "Ascii", "66","A is 65 wat is B?", new List<String>(FalseAnswers)),
                new MultipleChoiceQuestion(1, "Ascii", "66","Wat was antwoord van vorige vraag", new List<String>(FalseAnswers)),
                new MultipleChoiceQuestion(2, "Ascii", "97","als A 65 wat is a in Ascii (tip er zitten 6 symbolen tussen A en a)", new List<String>(FalseAnswers)),
                new MultipleChoiceQuestion(2, "Ascii", "AB","65+66", new List<String>(FalseAnswers)),
            };

            /*List<IQuestionAble> VragenLijst = new List<IQuestionAble>() {
                new OpenVraag(1, "Alphabet", "H","Type de letter H"),
                new OpenVraag(1, "Alphabet", "B","Type de letter B"),
                new OpenVraag(3, "Alphabet", "A","AlphAbet"),
                new OpenVraag(3, "Alphabet", "AB","AB"),
                new OpenVraag(1, "Ascii", "66","A is 65 wat is B?"),
                new OpenVraag(1, "Ascii", "66","Wat was antwoord van vorige vraag"),
                new OpenVraag(2, "Ascii", "97","als A 65 wat is a in Ascii (tip er zitten 6 symbolen tussen A en a)"),
                new OpenVraag(2, "Ascii", "AB","65+66"),
            };*/

            Quiz myQuiz = new Quiz(VragenLijst);
            int mode = myQuiz.StartState();
            myQuiz.StartQuiz(myQuiz.InitMode(mode));

            Console.WriteLine("---Done---");
        }
    }
}
