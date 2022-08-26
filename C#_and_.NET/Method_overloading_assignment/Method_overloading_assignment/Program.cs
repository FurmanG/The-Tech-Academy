using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_overloading_assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //2. instantiate the class and call the one method,
            //passing in an integer. Display the result to the screen.
            Console.WriteLine("Select a number (int) to perform the calculation:");
            int num1 = Convert.ToInt32(Console.ReadLine());
            math_operation math = new math_operation();
            Console.WriteLine(num1 + " + " + num1 + " = " + math.Add(num1));

            //4. In the Main() method of the console app,
            //instantiate the class and call the second method,
            //passing in a decimal. Display the result to the screen.
            Console.WriteLine("Select a number (decimal) to perform the calculation:");
            decimal num2 = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine(num2 + " + " + num2 + " + " + num2 + " = " + math.Add(num2));

            //6. In the Main() method of the console app,
            //instantiate the class and call the third method,
            //passing in a string that equates to an integer.
            //Display the result to the screen.
            Console.WriteLine("Select a number (string) to perform the calculation:");
            string num3 = Console.ReadLine();
            Console.WriteLine(num3 + " + " + num3 + " + " + num3 + " + " + num3 + " = " + math.Add(num3));




            Console.ReadLine();

        }
    }
}
