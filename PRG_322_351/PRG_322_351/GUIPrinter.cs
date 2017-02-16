using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Forms;


namespace PRG_322_351
{
    public class GUIPrinter : IPrinter
    {
        public void Print(string theMessage)
        {
            MessageBox.Show(theMessage);
        } 
    }
}
