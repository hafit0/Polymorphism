
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymOR2
{
    class Epson : PrinterWindows
    {
        public override void Show()
        {
            Console.WriteLine("Epson Display dimension : 10*11");
        }
        public override void Print()
        {
            Console.WriteLine("Epson Printer Printing....  ");
        }
    }
}
