using System;
using System.Collections.Generic;
using System.Text;

namespace PrinterTaskConsoleApp
{
    internal class Printer
    {
        int Name { get; set; }

        private int PaperCount;


        int PCount { get; set; }

        public void Show()
        {
            Console.WriteLine("Wydruk:");

        }
    }
}
