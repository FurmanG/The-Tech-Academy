using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace overload_operator
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee1 = new Employee(100, "Dan", "Smith");
            Employee employee2 = new Employee(101, "Ban", "Jonse");

            employee1.employeeData();
            employee2.employeeData();

            //checks if two Employee objects are equal by
            //comparing their Id property.

            if (employee1 == employee2)
            {
                Console.WriteLine("Same Id number, Error!!!!!!");
            }
            else
            {
                Console.WriteLine("Different ID number = no problem!");
            }



            Console.ReadLine();
        }
    }
}
