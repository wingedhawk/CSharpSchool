using Opdracht2Week1.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Opdracht2Week1
{
    class Quiz
    {
        public List<Vraag> vragen = new List<Vraag>();

        public List<Vraag> getOrderedLijst()
        {
            var returnVragen = vragen.OrderBy(v => v.CategorieString).ToList();
            return returnVragen;
        }

    }

}
