using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Verlag
{
    public class Buch
    {
        private string autor;
        private string titel;
        private int auflage;
        private string isbn;

        
        public string Autor
        {
            get { return autor; }
            set { autor = value; }
        }
    

        public string Titel
        {
            get { return titel; }
            set { titel = value; }
        }

        public int Auflage 
        { 
            get { return auflage; }
            set
            {
                if (value <= 0) 
                {
                    throw new ArgumentOutOfRangeException("Auflage muss größer als 0 sein");
                }                
                else
                {
                    auflage = value;
                }
            }
        }

        public string ISBN
        {
            get { return isbn; }
            set 
            { 
                if (value.Length < 10)
                {
                    int summe=0;
                    for (int i = 1;i<=value.Length;i++)
                    {
                        summe = summe+ i*Convert.ToInt32(value[i]);
                    }
                    summe = summe % 11;
                    isbn = String.Concat(value, summe);

                }
                else
                {
                    isbn = value;
                }
            }
        }

        // Konstruktor keine Auflage 
        public Buch(string autor, string titel)
        {
            this.Autor = autor;
            this.Titel = titel;
            this.Auflage = 1;
        }
        

        // Konstruktor mit auflage
        public Buch(string autor, string titel, int auflage)
        {
            this.Auflage = auflage;
            this.Autor = autor;
            this.Titel = titel;
        }
    }
}