using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Verlag
{
    class Buch
    {
        private string autor;
        private string titel;
        private int auflage;

        public string Autor
        {
            set { autor = value; }get { return autor; }
        }
        public string Titel
        {
            set { titel = value; } get { return titel; }
        }
        public int Auflage
        {
            set { auflage = value; }
            get { return auflage; }
        }

        public Buch(string autor, string titel, int auflage)
        {
            Autor = autor;
            Titel = titel;
            Auflage = auflage;
        }
    }
}
