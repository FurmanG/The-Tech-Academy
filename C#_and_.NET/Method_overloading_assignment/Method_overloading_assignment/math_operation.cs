using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_overloading_assignment
{

    //1. Create a class. create a method that will take in an integer,
    //create a math operation for this integer (addition, subtraction, etc.),
    //then return the answer as an integer.
    public class math_operation
    {
        public int Add(int x = 1)
        {
            int answer = x + x;
            return answer;
        }

        //3. Add a second method to the class with the same name
        //that will take in a decimal, create a different math
        //operation for it, then return the answer as an integer.
        public int Add(decimal x = 1.0m)
        {
            int z = Convert.ToInt32(x);
            int answer = z + z + z;
            return answer;
        }

        //5. Add a third method to the class, with the same name,
        //that will take in a string, convert it to an integer
        //if possible, do a different math operation to it,
        //then return the answer as an integer.
        public int Add(string x = "1")
        {
            int y = Int32.Parse(x);
            int answer = y + y + y + y ;
            return answer;
        }


    }
}
