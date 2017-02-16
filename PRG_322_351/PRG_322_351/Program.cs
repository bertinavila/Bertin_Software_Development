using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRG_322_351
{
    class Program
    {
        static void Main(string[] args)
        {
            Student_Roster CCSD = new Student_Roster();
            Student s = new Student("Bert", "Avila", 28 );
            s.SetPrinter( new ConsolePrinter() );
            s.Debug();

            s.SetPrinter( new GUIPrinter() );
            s.Debug();
        }
    }
}
