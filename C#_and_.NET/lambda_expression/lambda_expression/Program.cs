using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lambda_expression
{
    class Program
    {
        static void Main(string[] args)
        {
            //2. In the Main() method, create a list of at least 10 employees.
            //At least two employees should have the first name “Joe”.

            List<Employee> EmployeeX = new List<Employee>();

            EmployeeX.Add(new Employee(1, "Joe", "Smith"));
            EmployeeX.Add(new Employee(2, "Robert", "Johnson"));
            EmployeeX.Add(new Employee(3, "James", "Williams"));
            EmployeeX.Add(new Employee(4, "Joe", "Brown"));
            EmployeeX.Add(new Employee(5, "David", "Jones"));
            EmployeeX.Add(new Employee(6, "William", "Garcia"));
            EmployeeX.Add(new Employee(7, "Charles", "Miller"));
            EmployeeX.Add(new Employee(8, "Mark", "Davis"));
            EmployeeX.Add(new Employee(9, "Donald", "Rodriguez"));
            EmployeeX.Add(new Employee(10, "Kevin", "Wilson"));
                        
            //3. Using a foreach loop, create a new list of all employees
            //with the first name “Joe”. In your comparison statement,
            //remember to reference the property of the object you are checking.

            List<Employee> EmployeeY = new List<Employee>();

            foreach( Employee Emp in EmployeeX)
            {
                if (Emp.FirstName == "Joe")
                {
                    EmployeeY.Add(Emp);
                }
            }


            foreach( Employee Emp in EmployeeY)
            {
                Console.WriteLine(Emp.FirstName + " " + Emp.LastName + " " + Emp.Id);
 
            }

            Console.WriteLine("");


            //4. Perform the same action again, but this time with a lambda expression.

            List<Employee> newList = EmployeeX.Where(x => x.FirstName == "Joe").ToList();

            foreach (Employee Emp in newList)
            {
                Console.WriteLine(Emp.FirstName + " " + Emp.LastName + " " + Emp.Id);

            }

            Console.WriteLine("");

            //5. Using a lambda expression, make a list of all employees with an Id number greater than 5.

            List<Employee> newList2 = EmployeeX.Where(x => x.Id > 5).ToList();

            foreach (Employee Emp in newList2)
            {
                Console.WriteLine(Emp.FirstName + " " + Emp.LastName + " " + Emp.Id);

            }

            Console.ReadLine();
        }
    }
}
