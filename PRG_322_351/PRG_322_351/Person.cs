using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PRG_322_351
{
    public class Person
    {
       
        protected string m_FirstName;                         //the students frist name will be inherited from person
        protected string m_LastName;                          //the students last name will be inherited from person
        protected string m_hairColor;                         //the students hair color will be inherited from person 
        protected int m_NumberReferences;                     //the number of students will be incremented by one and stored here
        protected int m_age;                                  //the students age will be here

        public Person(string m_FirstName, string m_LastName, int m_age)
        {
             
                return m_FirstName, m_LastName,  m_age;
            
        }
        public int Age
        {
            get
            {
                 return m_age;
            }
            set
            {
                m_age = value;
            }
        }

        public string FirstName
        {
            get
            {
                return m_FirstName;
            }
            
            set
            {
                m_FirstName = value; 
            }
        }

        public string HairColor
        {
            get
            {
                return m_hairColor;
            }
            set
            {
                m_hairColor = value;
            }
        }

        public string LastName
        {
            get
            {
                return m_LastName;
            }
            set
            {
                m_LastName = value;
            }
        }

        public string GetFirstName
        {
         
            get
            {
               return m_FirstName;
            }

        }

        public int  NumberReferences
        {
            get
            {
               return m_NumberReferences;

            }
        }

        public void Person_two_overloads()
        {
            ();
        }

        public void PrintOutContent()
        {
            throw new System.NotImplementedException();
        }

        public void SetFirstName()
        {
           
        }
    }
}
