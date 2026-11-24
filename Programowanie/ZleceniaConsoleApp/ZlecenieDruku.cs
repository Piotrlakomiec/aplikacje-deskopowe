using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Xml.Linq;

namespace ZleceniaConsoleApp
{
    internal abstract class ZlecenieDruku
    {
        public required string Numer {  get; set; }
        public int LiczbaSztuk {  get; set; }
        private decimal cenaZaSztuke = 12;
        public decimal CenaZaSztuke { 
            get 
            {
                return cenaZaSztuke;
            }
            set
            {
                cenaZaSztuke = value;
            }
        }
        protected ZlecenieDruku(string number , int liczbaSztuk)
        {
            Numer = number;
            LiczbaSztuk = liczbaSztuk;
        
        }
        public virtual decimal Obliczkoszt()
        {
            return LiczbaSztuk * CenaZaSztuke;
        }
        public abstract int ObliczCzasRealizacji();

        public void Podsumowanie()
        {
            Console.WriteLine($"Numer zlecenia: {Numer}:");
            Console.WriteLine($"Cena plakatu: {CenaZaSztuke}");
        }

    }
}
