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
        public string Autor
        {
            get { return autor; }

            set 
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentException(nameof(value), "Der Name des Autors darf nicht leer sein");
                }

                foreach (char c in value)
                {
                    if (!char.IsLetter(c))
                    {
                        throw new ArgumentException(nameof(c), "Der Name des Autors dard keine Sonderzeichen beinhalten");
                    }
                }

                autor = value; 
            }
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