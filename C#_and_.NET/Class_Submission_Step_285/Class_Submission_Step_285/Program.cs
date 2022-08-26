using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Submission_Step_285
{
    //6. Declare a class to be static.
    public static class Example 
    {
        public static float PI = 3.14159f;
        public static int square (int x) { return x * x; }
        public static int sum (int x, int y) { return x + y; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //2. In the Main() method, instantiate that class.
            void_method_outputs math = new void_method_outputs();

            //3. Have the user enter a number. Call the method on that number.
            //Display the output to the screen. It should be the entered number, divided by two.
            Console.WriteLine("Enter a number: ");
            int num = Convert.ToInt32(Console.ReadLine());
            math.Math1(num);

            // 4. Calling a method with output parameters.
            int a = 100;
            Console.WriteLine("a =  " + a);
            math.Math2(out a);
            Console.WriteLine("a =  " + a);

            //5. Calling an overload method with output parameters.
            decimal b = 100.01m;
            Console.WriteLine("b =  " + b);
            math.Math2(out b);
            Console.WriteLine("b =  " + b);

            //6. Calling the static class.
            Console.WriteLine("PI = " + Example.PI);
            Console.WriteLine("Square of 5 = " + Example.square(5));
            Console.WriteLine("Sum of 5 and 6 = " + Example.sum(5,6));

            Console.ReadLine();
        }
    }
}
