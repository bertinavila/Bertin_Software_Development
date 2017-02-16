using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRG_322_351
{
  public class Student : Person, IContactable, IDebug

    {
        public string m_Email;
        public  int m_id;
        public  int m_id_count;
        public  string m_PhoneNumber;
        public  IPrinter m_printer;
        public int m_GPA;

        public void SetPrinter(IPrinter p)
        {
            m_printer = p;
        }

        public Student(string FirstName, string LastName, int age)
            : base( FirstName, LastName, age ) // Assuming Bert++ CreATES an adequates Constructor
        { 
        
        }

        public string Email
        {
           
            get
            {
                return m_Email;
            }
            set
            {
                m_Email = value;
            }

        
        }

        public int ID
        {
            get
            {
                return m_id;
            }
            set
            {
                m_id = value;
            }
        }

        public string PhoneNumber
        {
            get
            {
                return m_PhoneNumber;
            }
            set
            {
                m_PhoneNumber = value;
            }
        }
    
        public void Debug()
        {
            string s = "firstName" + m_FirstName + "lastName" + m_LastName + "age" + m_age;
            m_printer.Print(s);
        }

        public void NumberReferences()
        {
            
        }
    }
}
