using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymOR2
{
    public class PrinterWindows
    {

        public virtual void Show() 
        {
            Console.WriteLine("Display dimension : ");
        }
        public virtual void Print()
        {
            Console.WriteLine("Printer Printing.... ");
        }

    }
}
