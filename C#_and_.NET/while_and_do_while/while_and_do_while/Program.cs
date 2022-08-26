using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace while_and_do_while
{
    class Program
    {
        static void Main(string[] args)
        {
            // boolean comparison using a do while statement, to print numbers from 0 to 10.
            int num = 0;
            int n = 10;
            do
            {
                Console.WriteLine(num);
                num++;
            }
            while ( num < n + 1 );

            //boolean comparison using a while statement, to check correct password. 
            bool continueLooping = true;
            string password = "";

            while (continueLooping)
            {
                if( password == "1234")
                {
                    Console.WriteLine("Acess granted.");
                    Console.ReadLine();
                    break;
                }
                else
                {
                    Console.WriteLine("Enter 4 digit password:");
                    password = Console.ReadLine();
                }
            }

        }
    }
}
