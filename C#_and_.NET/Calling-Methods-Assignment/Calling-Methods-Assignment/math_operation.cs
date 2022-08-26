using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Calling_Methods_Assignment
{

    //Create a class. In that class, create three methods,
    //each of which will take one integer parameter in
    //and return an integer.
    //The methods should do some math operation on the received parameter.
    //Put this class in a separate .cs file in the application.

    public class math_operation
    {
        public int Square (int x)
        {
            return (x * x);
        }
        public int Double (int x)
        {
            return (2 * x);
        }
        public int Cube (int x)
        {
            return (x * x * x);
        }


    }
}
