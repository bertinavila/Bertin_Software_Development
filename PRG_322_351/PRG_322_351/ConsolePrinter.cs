using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;

namespace PRG_322_351
{
    public class ConsolePrinter : IPrinter
    {
        public void Print(string theMessage)
        {
           Console.WriteLine(theMessage);
        }
    }
}
