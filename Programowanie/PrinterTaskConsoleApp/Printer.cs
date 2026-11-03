using System;
using System.Collections.Generic;
using System.Text;

namespace PrinterTaskConsoleApp
{

    internal class Printer
    {
        public string Name { get; set; }

        private int paperCount;

        public int PaperCount
        {
            get
            {
                return paperCount;
            }
            set
            {
                if (value >= 0)
                {
                    paperCount = value;
                }
            }
        }

        public Printer(string name, int count)
        {
            Name = name;
            PaperCount = count;
        }

        public bool Print(int pageCount)
        {
            if (pageCount > 0 && pageCount <= PaperCount)
            {
                PaperCount = PaperCount - pageCount;
                return true;
            }

            return false;
        }

    }
}
