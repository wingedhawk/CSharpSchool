using Opdracht2Week1.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Opdracht2Week1
{

    class Quiz
    {
        public delegate List<IVraag> MethodDelegate();
        public delegate String MethodDelegate2();
        public List<IVraag> Vragen = new List<IVraag>();

        List<Delegate> Delegates = new List<Delegate>();
        List<MethodDelegate> DelList;

        public Quiz(List<IVraag> vragen)
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

        public List<IVraag> InitMode(int question)
        {
            return DelList[question-1]();
        }

        public void StartQuiz(List<IVraag> lijst)
        {
            Boolean right;
            foreach(IVraag vraag in lijst)
            {
                right = false;
                Console.WriteLine("Graad:{0} Categorie:{1} \n {2}", vraag.Moeilijkheidsgraad, 
                    vraag.CategorieString, vraag.VraagString);
                while (!right)
                {
                    if (Console.ReadLine() != vraag.Antwoord)
                    {
                        Console.WriteLine("---------------------- \n WRONG! Try again");
                    }
                    else
                    {
                        Console.WriteLine("---------------------- \n CORRECT MOVE ON");
                        right = true;
                    }
                }
            }
        }

        public List<IVraag> GetOrderedLijst()
        {
            var returnVragen = Vragen.OrderBy(v => v.Moeilijkheidsgraad).ToList();
            Console.WriteLine("U krijgt alle vragen");
            return returnVragen;
        }

        public List<IVraag> GetMoeilijkheidVragen()
        {
            Console.WriteLine("Welke moeilijkheid wilt u?");
            Console.WriteLine("1 t/m 3");
            int graad = int.Parse(Console.ReadLine());
            IEnumerable<IVraag> specificList = from v in Vragen where graad == v.Moeilijkheidsgraad select v;
            return specificList.ToList();
        }

        public List<IVraag> GetCategorieVragen()
        {
            Console.WriteLine("Welke categorie wilt u kiezen?");
            Console.WriteLine("Alphabet, Ascii - Voer de volledig naam inclusief hoofdletter");
            string categorie = Console.ReadLine();
            IEnumerable<IVraag> specificList = from v in Vragen where categorie == v.CategorieString select v;
            return specificList.ToList();
        }

    }

}
