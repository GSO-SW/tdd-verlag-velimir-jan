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


