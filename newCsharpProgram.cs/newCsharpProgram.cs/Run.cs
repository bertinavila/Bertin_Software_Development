using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace newCsharpProgram.cs
{
    class Run
    {
                                                                                   // the second program that runs the program class
  
        private Dictionary<string, Student> studs = new Dictionary<string, Student>();  //creating a dictionary named studs

        public void Exit()
        {
            Console.Clear();
        
        }
        public void Menu()
        {
            Console.WriteLine("Welcome to the student menu.Please select one from the following options, choose an option then ");
            Console.WriteLine("1) -Register a new student");
            Console.WriteLine("2) -View registered students");
            Console.WriteLine("3) -Search students by last name");
            Console.WriteLine("4) -convert mersures program");
            Console.WriteLine("0) -Exit this program");


            string selection = Console.ReadLine();                                      //reads the selection or gets your option choice
            int option = Convert.ToInt32(selection);                                    //converts that selection or option choice into a int

            switch (option)
            {
                case 1:
                    Register();
                    break;

                case 2:
                    ViewStudent();
                    break;

                case 3:
                    SearchStudent();
                    break;

                case 0: Exit();
                    break;

                default:
                    Console.WriteLine("Your enter was not reconized as one of the options, please enter a number 1-3.");
                    Console.WriteLine("1) -Register a new student");
                    Console.WriteLine("2) -View registered students");
                    Console.WriteLine("3) -Search students by name");
                    Console.WriteLine("4) -convert mersures program");
                    Console.WriteLine("0) -Exit this program");
                    break;
            }

        }

        protected void Register()
        {
            Console.Clear();
            Console.WriteLine("Enter your first name");
            string fName = Console.ReadLine();
            Console.WriteLine("Enter your last name");
            string lName = Console.ReadLine();
            Console.WriteLine("Enter your age");
            string age = Console.ReadLine();
            Console.WriteLine("Enter your gpa, include a decimal");

            string gpa = Console.ReadLine();                        //reads the first and last names 

            int Nage = Convert.ToInt32(age);                        //converts to intiger type for age
            double Ngpa = Convert.ToDouble(gpa);                    //converts to doulbe type for gpa

            Student students = new Student(fName, lName, Nage, Ngpa);

            studs.Add(lName, students);                             //adds the new student info to dictionary

            Menu();                                                 //returns to main menu


        }

        public void ViewStudent()
        {

            foreach (KeyValuePair<string, Student> student in studs) //foreach loop sees all students in studs dictionary
            {
                Console.WriteLine(student.Key + " " + student.Value.fName + " " + student.Value.age + " " + student.Value.gpa);
            }                                                       //displays contents of student

            Menu();                                                 //returns to main menu

        }

        public void SearchStudent()
        {
            Console.Clear();                                        //clears the screen 
            Console.WriteLine("Enter the last name of the person you wish to find.");

            string searchLname = Console.ReadLine();                //reads the last name and saves as searchLname

            if (studs.ContainsKey(searchLname))                     //checks if last name aka "searchLname" is in studs dictionary
            {
               Console.WriteLine(studs[searchLname].lName + " " + studs[searchLname].fName + " " + studs[searchLname].age + " " + studs[searchLname].gpa);         
            }
               else  
                {
                        Console.WriteLine("The person you wish to find does not exitst in the student list.");
                }
             
             Menu();
        }
    }
}
