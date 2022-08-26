using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Income_comparison
{
    class Program
    {
        static void Main(string[] args)
        {
            //The program must start by printing “Anonymous Income Comparison Program” to the screen.
            Console.WriteLine("Anonymous Income Comparison Program");

            //It must then print “Person 1” to the screen and get the following details from user input:
            Console.WriteLine("Person 1");
            Console.WriteLine("Hourly Rate?");
            string hourRate1Str = Console.ReadLine();
            int hourRate1 = Convert.ToInt32(hourRate1Str);

            Console.WriteLine("Hours worked per week?");
            string hourPerWeek1Str = Console.ReadLine();
            int hourPerWeek1 = Convert.ToInt32(hourPerWeek1Str);

            //It must then print “Person 2” to the screen and then get the following details from user input:
            Console.WriteLine("Person 2");
            Console.WriteLine("Hourly Rate?");
            string hourRate2Str = Console.ReadLine();
            int hourRate2 = Convert.ToInt32(hourRate2Str);

            Console.WriteLine("Hours worked per week?");
            string hourPerWeek2Str = Console.ReadLine();
            int hourPerWeek2 = Convert.ToInt32(hourPerWeek2Str);


            //It must then print to the screen “Annual salary of Person 1:” and display the exact salary below it.
            Console.WriteLine("Annual salary of Person 1:");
            int annual1 = hourRate1 * hourPerWeek1 * 52;
            Console.WriteLine(annual1);

            //It must then print to the screen “Annual salary of Person 2:” and display the exact salary below it.
            Console.WriteLine("Annual salary of Person 2:");
            int annual2 = hourRate2 * hourPerWeek2 * 52;
            Console.WriteLine(annual2);

            //It must then print to the screen “Does Person 1 make more money than Person 2?”
            //and write the true or false value of this statement below it.
            Console.WriteLine("Does Person 1 make more money than Person 2 ?");
            bool person1MoreThenPerson2 = annual1 > annual2;
            Console.WriteLine(person1MoreThenPerson2);

            Console.ReadLine();

        }

    }
}
