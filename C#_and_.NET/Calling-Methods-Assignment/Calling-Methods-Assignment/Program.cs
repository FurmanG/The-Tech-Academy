using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Calling_Methods_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //In the Main() program, ask the user what number
            //they want to do the math operations on.
            Console.WriteLine("Select a number to perform the calculation:");
            try
            {
                int num = Convert.ToInt32(Console.ReadLine());
            
                //Call each method in turn, passing the user input
                //to the method. Display the returned integer to the screen.

                math_operation math = new math_operation();
                Console.WriteLine(num + " multiple 2 is: " + math.Double(num));
                Console.WriteLine("The square of " + num + " is: " + math.Square(num));
                Console.WriteLine("The cube of " + num + " is: " + math.Cube(num));
                Console.ReadLine();
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.ReadLine();
            }
        }
     }
}
