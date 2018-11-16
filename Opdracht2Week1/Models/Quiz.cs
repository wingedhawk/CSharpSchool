using Opdracht2Week1.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Opdracht2Week1
{

    class Quiz
    {
        public delegate List<IQuestionAble> MethodDelegate();
        public delegate String MethodDelegate2();
        public List<IQuestionAble> Vragen = new List<IQuestionAble>();

        List<Delegate> Delegates = new List<Delegate>();
        List<MethodDelegate> DelList;

        public Quiz(List<IQuestionAble> vragen)
        {
            DelList = new List<MethodDelegate> { GetCategorieVragen, GetMoeilijkheidVragen, GetOrderedLijst };
            this.Vragen = vragen;
        }

        public int StartState()
        {
            Console.WriteLine("Welcome to Quizzz");
            Console.WriteLine("Wat voorn type vragen wilt u?");
            Console.WriteLine("Kies met behulp van de aangewezen cijfer");
            Console.WriteLine("1) Categorie / 2) Moeilijksheid / 3) All");
            return int.Parse(Console.ReadLine());
        }

        public List<IQuestionAble> InitMode(int question)
        {
            return DelList[question-1]();
        }

        public void StartQuiz(List<IQuestionAble> lijst)
        {
            foreach(IQuestionAble vraag in lijst)
            {
                MultipleChoiceQuestion testType = (MultipleChoiceQuestion)vraag;
                
                Console.WriteLine("Graad:{0} Categorie:{1} \n {2}", vraag.Moeilijkheidsgraad, 
                    vraag.CategorieString, vraag.VraagString);
                if (testType.FalseAnswers != null)
                {
                    testType.ShowAnswers();
                }
                while (true)
                {
                    if (Console.ReadLine() != vraag.Antwoord)
                    {
                        Console.WriteLine("---------------------- \n WRONG! Try again");
                    }
                    else
                    {
                        Console.WriteLine("---------------------- \n CORRECT MOVE ON");
                        break;
                    }
                }
            }
        }

        public List<IQuestionAble> GetOrderedLijst()
        {
            var returnVragen = Vragen.OrderBy(v => v.Moeilijkheidsgraad).ToList();
            Console.WriteLine("U krijgt alle vragen");
            return returnVragen;
        }

        public List<IQuestionAble> GetMoeilijkheidVragen()
        {
            Console.WriteLine("Welke moeilijkheid wilt u?");
            Console.WriteLine("1 t/m 3");
            int graad = int.Parse(Console.ReadLine());
            IEnumerable<IQuestionAble> specificList = from v in Vragen where graad == v.Moeilijkheidsgraad select v;
            return specificList.ToList();
        }

        public List<IQuestionAble> GetCategorieVragen()
        {
            Console.WriteLine("Welke categorie wilt u kiezen?");
            Console.WriteLine("Alphabet, Ascii - Voer de volledig naam inclusief hoofdletter");
            string categorie = Console.ReadLine();
            IEnumerable<IQuestionAble> specificList = from v in Vragen where categorie == v.CategorieString select v;
            return specificList.ToList();
        }

    }

}
