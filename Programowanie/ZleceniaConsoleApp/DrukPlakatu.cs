using System;
using System.Collections.Generic;
using System.Text;

namespace ZleceniaConsoleApp
{
    internal class DrukPlakatu : ZlecenieDruku
    {
        protected DrukPlakatu(string number, int liczbaSztuk)
           : base(number, liczbaSztuk)
        {

        }
        public override decimal Obliczkoszt()
        {
            return LiczbaSztuk * CenaZaSztuke +12;
        }
        public override int ObliczCzasRealizacji()
        {
            return 5 + LiczbaSztuk * 3;
        }
    }
}
