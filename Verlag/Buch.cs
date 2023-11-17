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

        // Konstruktor keine Auflage 
    public Buch(string autor, string titel)
    {
        if (String.IsNullOrEmpty(autor))
        {
            throw new ArgumentException(nameof(autor), "Der Name des Autors dard keine Sonderzeichen beinhalten");
        }

        foreach (char c in autor)
        {
            if (!char.IsLetter(c))
            {
                throw new ArgumentException(nameof(c), "Der Name des Autors dard keine Sonderzeichen beinhalten");
            }
        }

        this.titel = titel;
        this.auflage = 1;
    }

        // Konstruktor mit auflage
        public Buch(string autor, string titel, int auflage)
        {
            if (auflage <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(auflage), "Auflage muss größer als 0 sein.");
            }
            else
            {
            this.auflage = auflage;

            }

            this.autor = autor;
            this.titel = titel;
        }
    }
}