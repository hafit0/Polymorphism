﻿using System;

namespace PolymOR2
{
    class Canon : PrinterWindows
    {
        public override void Show()
        {
            Console.WriteLine("Canon Display dimension : 9.5*12");
        }
        public override void Print()
        {
            Console.WriteLine("Canon Printer Printing....  ");
        }
    }
}
