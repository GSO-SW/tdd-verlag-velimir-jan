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
        private string isbn13;


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

        public string ISBN13
        {

            get { return isbn13; }
            set 
            {
                string isbnOhneBindestrich = value.Replace("-", "");

                if (isbnOhneBindestrich.Length == 12)
                {
                    int summe=0;
                    for (int i = 1;i<=isbnOhneBindestrich.Length;i++)
                    {
                        summe = summe+ i*Convert.ToInt32(isbnOhneBindestrich[i]);
                    }
                    summe = summe % 11;

                    isbn13 = String.Concat(isbnOhneBindestrich, summe.ToString());


                }
                else if(isbnOhneBindestrich.Length==13)
                {
                    isbn13 = value;
                }
                else
                {
                    throw new ArgumentException("ISBN muss entweder 12 Zahlen lang sein ohne Prüfziffer oder 13 Zahlen lang mit Prüfziffer");
                }
            }
        }

        public string ConvertToISBN10()
        {
            string isbn10 = this.ISBN13.Replace("-", "").Remove(0,3);
            isbn10 = isbn10.Remove(9,1);
            return isbn10 + CalculateISBN10CheckDigit(isbn10).ToString();
        }


        public static int CalculateISBN10CheckDigit(string isbn) 
        {
            if (isbn == null || isbn.Length != 9)
            {
                throw new ArgumentException("ISBN-10 sollte 9 Zeichen lang sein.");
            }

            int sum = 0;
            for (int i = 10; i > 1; i--)
            {
                sum += i * isbn[i -2];
            }

            sum = sum % 11;

            return sum;
        }
    }
}