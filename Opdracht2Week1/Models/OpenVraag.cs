using System;
using System.Collections.Generic;
using System.Text;

namespace Opdracht2Week1.Models
{
    class OpenVraag : IVraag
    {
        public int Moeilijkheidsgraad { get; set; }
        public string CategorieString { get; set; }
        public string Antwoord { get; set; }
        public string VraagString { get; set; }

        public OpenVraag(int moeilijkheidsgraad, string categorieString, string antwoord, string vraagString)
        {
            Moeilijkheidsgraad = moeilijkheidsgraad;
            CategorieString = categorieString;
            Antwoord = antwoord;
            VraagString = vraagString;
        }
    }
}
