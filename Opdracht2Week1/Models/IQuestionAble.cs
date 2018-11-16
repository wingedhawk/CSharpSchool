using System;
using System.Collections.Generic;
using System.Text;

namespace Opdracht2Week1.Models
{
    interface IQuestionAble
    {
        int Moeilijkheidsgraad { get; set; }
        string CategorieString { get; set; }
        string VraagString { get; set; }
        string Antwoord { get; set; }
    }

}
