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
                    isbn = String.Concat(value, summe.ToString());

                }
                else if(isbnOhneBindestrich.Length==13)
                {
                    isbn = value;
                }
                else
                {
                    throw new ArgumentException("ISBN muss entweder 12 Zeichen lang sein ohne Prüfziffer oder 13 Zeichen lang sein mit Prüfziffer");
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
        
        
        public static string ConvertToISBN10(string isbn13)
        {
            int checkDigit;
            string isbn10 = isbn13.Replace("-", "").Remove(0,3);
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