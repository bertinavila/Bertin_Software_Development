using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace newCsharpProgram.cs
{
    public class MeasuresMenu
    {
        static void convertMeasuresMenu()
        {
            Console.WriteLine("Unite converter program, please select the type of weight you would like to \n convert.");
            Console.WriteLine("1) -Convert grams to kilograms");
            Console.WriteLine("2) -Convert grams to pounds");
            Console.WriteLine("3) -Convert grams to ounces");
            Console.WriteLine("4) -Convert grams to grams");
            Console.WriteLine("5) -Exit this program");

            string selection = Console.ReadLine();              //the string selection is what the user input and the console reads that line 
            
            int option = Convert.ToInt32(selection);            //gets the selection 1,2,3,4 or 0

            double sel = Convert.ToDouble(selection);           //now the string is turned into a type double

            UnitConverter name = new UnitConverter();           //calls the unitConverter class to get methods to convert weight
            double value;
                                                                //string amount = Console.ReadLine();
                                                                //Convert.ToDouble(amount);
            switch (option)
            {
                case 1:
                    value = name.Gs2Kgs(sel);
                                                                //Console.WriteLine("amount is " + amount);

                    break;

                case 2:
                    value = name.Gs2Lbs(sel);
                     
                    break;

                case 3:
                    value = name.Gs2Ozs(sel);
                    
                    break;

                case 4:

                    value = name.Gs2Gs(sel);

                    break;


                case 5: Exit();
                    {
                        Console.Clear();               //clears the screen
                    break;
                    }

                default:
                    Console.WriteLine("Your enter was not reconized as one of the options,\nplease enter a number 1-5.");
                    Console.WriteLine("1) -Convert grams to kilograms");
                    Console.WriteLine("2) -Convert grams to pounds");
                    Console.WriteLine("3) -Convert grams to ounces");
                    Console.WriteLine("5) -Exit this program");
                    break;
            }                                           //switch case ends here
            Console.WriteLine("Now enter the amount you want to convert.");

            string numberAmount = Console.ReadLine();
        }
                                                        //main ends here
        private static void Exit()
        {
            Console.Clear();                            //clears screen and ends program

        }


    }
}
