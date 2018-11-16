using System;
using System.Collections.Generic;
using System.Text;

namespace Opdracht2Week1.Models
{
    interface Vraag
    {
        int Moeilijkheidsgraad { get; set; }
        string CategorieString { get; set; }
        string Antwoord { get; set; }
    }

}
