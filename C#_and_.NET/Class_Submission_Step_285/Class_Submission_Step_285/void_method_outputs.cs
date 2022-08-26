using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Submission_Step_285
{
    //1. Create a class. In that class, create a void method that
    //outputs an integer. Have the method divide the data passed to it by 2.
    class void_method_outputs
    {
        public void Math1(int x)
        {
            int y = x / 2;
            Console.WriteLine(y);
        }


        //4. Create a method with output parameters.
        public void Math2(out int number)
        {
            number = 10;
        }

        //5. Overload a method.
        public void Math2(out decimal number)
        {
            number = 10.01m;
        }


    }
}
