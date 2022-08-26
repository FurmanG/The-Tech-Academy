using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace car_insurance
{
    class Program
    {
        static void Main(string[] args)
        {
            //a basic approval program for car insurance. It will ask the applicant
            //some questions and return a “true” or “false” at the end to determine
            //whether or not the applicant qualified for car insurance.
            Console.WriteLine("What is your age?");
            string ageStr = Console.ReadLine();
            int age = Convert.ToInt32(ageStr);

            Console.WriteLine("Have you ever had a DUI?");
            string duiStr = Console.ReadLine();
            bool dui = Convert.ToBoolean(duiStr);

            Console.WriteLine("How many speeding tickets do you have?");
            string ticketsStr = Console.ReadLine();
            int tickets = Convert.ToInt32(ticketsStr);

            //Qualifies for car insurance:
            //Applicants must be over 15 years old.
            //Applicants must not have any DUI’s.
            //Applicants must not have more than 3 speeding tickets.

            Console.WriteLine("Qualified?");
            bool Qualified = (age > 15 && dui == false && tickets <= 3);
            Console.WriteLine(Qualified);

            Console.ReadLine();

        }
    }
}
