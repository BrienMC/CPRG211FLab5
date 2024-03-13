using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPRG_211_F_Lab_5
{
    public class Circle
    {
        public double radius;


        // Blank circle constructor
        public Circle()
        {

        }


        // Circle constructor with radius attribute
        public Circle(double circleRadius)
        {
            radius = circleRadius;
        }


        // Sets the radius to the user input. First checks to see if input is valid, if invalid then throws an InvalidRadiusException that compares the input.
        public virtual void SetRadius(double radiusInput)
        {
            // InvalidRadiusException object is created to be able to throw the custom exception.
            // Also is using the constructor that takes the inputted radius and compares it.
            InvalidRadiusException invalidRadius = new InvalidRadiusException(radiusInput);

            if (radiusInput <= 0)
            {
                // Throws the InvalidRadiusException message if the radius is invalid.
                throw new Exception(invalidRadius.exceptionMessage);
            }
            else
            {   
                // Sets the radius to the input if it is valid.
                this.radius = radiusInput;
            }
            
        }

        // ToString method.
        public virtual void ToString()
        {
            Console.WriteLine($"The radius of the circle is {radius}.");
        }

    }
}
