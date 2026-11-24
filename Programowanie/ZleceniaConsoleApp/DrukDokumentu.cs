using System;
using System.Collections.Generic;
using System.Text;

namespace ZleceniaConsoleApp
{
    internal class DrukDokumentu : ZlecenieDruku
    {
        protected DrukDokumentu(string number, int liczbaSztuk)
            :base(number, liczbaSztuk)
        {
            
        }
        public override int ObliczCzasRealizacji()
        {
            return (int)Math.Ceiling(LiczbaSztuk / 20.0);
        }
    }
}
