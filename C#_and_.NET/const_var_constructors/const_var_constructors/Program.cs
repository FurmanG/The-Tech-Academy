using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace const_var_constructors
{
    class Program
    {
        static void Main(string[] args)
        {

            //1. Create a const variable.
            const string wisePhrase = "Use your time wisely.";
            Console.WriteLine(wisePhrase);
            Console.WriteLine("=========================");

            //2. Create a variable using the keyword “var.”
            var num = 10;  // Implicity typed.
            Console.WriteLine(num);
            Console.WriteLine("=========================");


            // Creating user with first name only.
            User user1 = new User("Joe");
            Console.WriteLine(user1.firstName + " " + user1.lastName);

            // Creating user with full name.
            User user2 = new User("Joe", "Smith");
            Console.WriteLine(user2.firstName + " " + user2.lastName);




            Console.ReadLine();
        }
    }


    //3. Chain two constructors together.
    public class User
    {
        public string firstName;
        public string lastName;

        public User (string firstName) : this(firstName, "lastName_X")
        {

        }

        public User (string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }
    }
}
