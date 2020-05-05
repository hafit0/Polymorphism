using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymOR2
{
    class LaserJet : PrinterWindows
    {
        public override void Show()
        {
            Console.WriteLine("LaserJet Display dimension : 12*12");
        }
        public override void Print()
        {
            Console.WriteLine("LaserJet Printer Printing....  ");
        }
    }
}
