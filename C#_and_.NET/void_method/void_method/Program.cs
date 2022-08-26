using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace void_method
{
    class Program
    {
        static void Main(string[] args)
        {
            //2. In the Main() method of the console app, instantiate the class.
            void_math math = new void_math();

            //3. Call the method in the class, passing in two numbers.
            math.math2(3, 6);

            //4. Call the method in the class, specifying the parameters by name.
            int x1 = 9;
            int x2 = 11;
            math.math2(firstNumber: x1, secondNumber: x2);


            Console.ReadLine();
        }
    }
}
