using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPRG_211_F_Lab_5
{
    public class InvalidRadiusException
    {

        // The message shown when InvalidRadiusException is thrown.
        public string exceptionMessage;

        // Blank constructor that throws a generalized explanation.
        public InvalidRadiusException()
        {
            exceptionMessage = "The radius is less than or equal to 0.";
        }

        // Constructor that takes the radius and throws a message showing which number is invalid.
        public InvalidRadiusException(double radius)
        {
            exceptionMessage = $"The radius of {radius} is invalid because it is less than or equal to 0.";
        }
    }
}
