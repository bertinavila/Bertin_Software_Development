using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace newCsharpProgram.cs
{
    class Student
    {

            //these are all the data types in the student class
            public string fName;
            public string lName;
            public int age;
            public double gpa;


            // bellow is the constructor that instantiates the class 
            public Student(string fName, string lName, int age, double gpa)
            {
                this.fName = fName;
                this.lName = lName;
                this.age = age;
                this.gpa = gpa;

            }
        }

}
