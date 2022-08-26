using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace overload_operator
{

    //1. Create an Employee class with Id, FirstName and LastName properties. 
    public class Employee
    {
        public int Id;
        string FirstName;
        string LastName;

        public Employee(int id, string First, string Last)
        {
            Id = id;
            FirstName = First;
            LastName = Last;
        }

        public void employeeData()
        {
            Console.WriteLine("Name: " + FirstName + " " + LastName + ". Id: " + Id);
            
        }


        //In the Employee class, overload the “==” operator
        //so it checks if two Employee objects are equal by
        //comparing their Id property. Remember that comparison
        //operators must be overloaded in pairs.

        public static bool operator ==(Employee E1, Employee E2)
        {
            if (E1.Id == E2.Id)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator !=(Employee E1, Employee E2)
        {
            if (E1.Id != E2.Id)
            {
                return true;
            }
            else
            {
                return false;
            }
        }




    }
}
