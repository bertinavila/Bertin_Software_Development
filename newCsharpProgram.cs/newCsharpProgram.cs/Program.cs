using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace newCsharpProgram.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            Run r = new Run();
            r.Menu();
        }
    }

    public class UnitConverter
    {


        public double Gs2Kgs(double number1)            //converting grams to kilograms
        {
            double kgs = number1 / 1000;
            return kgs;
        }

        public double Gs2Lbs(double number1)            //converting grams to pounds
        {
            double Lbs = number1 * 453.5923;
            return Lbs;
        }

        public double Gs2Ozs(double number1)            //converting grams to ounces
        {
            double Ozs = number1 * 28.3;
            return Ozs;
        }

        public double Gs2Gs(double number1)             //converting grams to grams, leaving it the same
        {
            double Gs = number1;
            return Gs;
        }
    }

}
       






        
    

