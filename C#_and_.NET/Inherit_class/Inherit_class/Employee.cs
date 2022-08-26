using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inherit_class
{

    //3. Create another class called Employee and have it inherit from
    //the Person class. Give the Employee class a property
    //called Id and have it be of data type int.
    public class Employee : Person
    {
        public Employee(string First, string Last)
        {
            FirstName = First;
            LastName = Last;
        }
    
            int Id = 1234;

    }
}
