using System;
using System.Collections.Generic;
using System.Globalization;
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
            set { isbn = value; }
        }

        // Konstruktor keine Auflage 
        public Buch(string autor, string titel)
        {
            this.Autor = autor;
            this.Titel = titel;
            this.Auflage = 1;
        }
        

        // Konstruktor mit auflage
        public Buch(string autor, string titel, int auflage) : this(autor, titel)
        {
            this.Auflage = auflage;
        }

        public string ConvertToISBN10()
        {
            int checkDigit;
            string isbn10 = this.ISBN.Replace("-", "").Remove(0,3);
            isbn10 = isbn10.Remove(9,1);
            checkDigit = 

        }

        public static int CalculateISBN10CheckDigit(string isbn) 
        {
            if (isbn == null || isbn.Length != 9)
            {
                throw new ArgumentException("ISBN-10 sollte 9 Zeichen lang sein.");
            }

            int sum = 0;
            for (int i = 0; i < 9; i++)
            {
                sum += (i + 1) * (isbn[i] - '0');
            }
        }
    }
}