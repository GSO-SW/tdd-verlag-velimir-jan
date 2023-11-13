using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Verlag
{
        public class Buch
        {
            public string Autor { get; set; }
            public string Titel { get; set; }
            public int Auflage { get; set; }

            // Konstruktor keine Auflage 
            public Buch(string autor, string titel)
            {
                foreach (char c in autor)
                {
                    if (!char.IsLetter(c))
                    {
                        throw new ArgumentException(nameof(c), "Der Name des Autors dard keine Sonderzeichen beinhalten");
                    }
                }
                Autor = autor;
                Titel = titel;
                Auflage = 1;
            }

            // Konstruktor mit auflage
            public Buch(string autor, string titel, int auflage)
            {
                if (auflage <= 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(auflage), "Auflage muss größer als 0 sein.");
                }
                Autor = autor;
                Titel = titel;
                Auflage = auflage;
            }
        }
    
    }


