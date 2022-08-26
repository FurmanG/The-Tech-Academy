using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyReport
{
    class Program
    {
        static void Main(string[] args)
        {
            //C# AND .NET COURSE / Step: 163
            // DAILY REPORT SUBMISSION ASSIGNMENT
            // Daily report(DR) for students of The Tech Academy


           Console.WriteLine("The Tech Academy.");
            Console.WriteLine("Student Daily Report.");

            Console.WriteLine("What is your name?");
            string yourName = Console.ReadLine();

            Console.WriteLine("What course are you on?");
            string courseOn = Console.ReadLine();

            Console.WriteLine("What page number?");
            string pageNumberStr = Console.ReadLine();
            int pageNumber = Convert.ToInt32(pageNumberStr);

            Console.WriteLine("Do you need help with anything? Please answer /“true/” or /“false./”");
            string needHelpStr = Console.ReadLine();
            bool needHelp = needHelpStr == "true";

            Console.WriteLine("Were there any positive experiences you’d like to share? Please give specifics.");
            string positiveExperiences = Console.ReadLine();

            Console.WriteLine("Is there any other feedback you’d like to provide? Please be specific");
            string otherFeedback = Console.ReadLine();

            Console.WriteLine("How many hours did you study today?");
            string studyHoursStr = Console.ReadLine();
            int studyHours = Convert.ToInt32(studyHoursStr);

            Console.WriteLine("Thank you for your answers. An Instructor will respond to this shortly. Have a great day!");

            Console.ReadLine();
          

        }
    }
}
