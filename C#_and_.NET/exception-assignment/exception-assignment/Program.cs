using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exception_assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a list of integers.
            int[] numList = { 98, 99, 6, 70, 82, 4, 34, 91, 90, 94, 8, 5 };
            foreach ( int num in numList)
            {
                Console.Write(num + " "); 
            }
            Console.WriteLine("");
            try
            {
                 //Ask the user for a number to divide each number in the list by.
                Console.WriteLine("Choose a number to divide each number in the list by:");
                int number = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("====================");
                //Write a loop that takes each integer in the list,
                //divides it by the number the user entered,
                //and displays the result to the screen.
                //put the loop in a try/catch block

                foreach (int num in numList)
                {
                    Console.Write(num / number + " ");
                }
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (DivideByZeroException ex)
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
