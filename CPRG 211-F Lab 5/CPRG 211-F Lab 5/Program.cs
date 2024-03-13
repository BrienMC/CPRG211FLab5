namespace CPRG_211_F_Lab_5
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Circle circleOne = new Circle();
            Circle circleTwo = new Circle();
            Circle circleThree = new Circle();

            // Takes user input to create three new circles with the radii's inputted.

            // First circle
            Console.Write("Please input a valid radius for the first circle: ");
            string radiusInput = Console.ReadLine();
            double radiusOne = double.Parse(radiusInput);

            // If the user input is less than or equal to 0, InvalidRadiusException is thrown. 
            circleOne.SetRadius(radiusOne);

            // Repeated for the next two circles.


            // Second circle
            Console.Write("Please input a valid radius for the second circle: ");
            radiusInput = Console.ReadLine();
            double radiusTwo = double.Parse(radiusInput);

            circleTwo.SetRadius(radiusTwo);


            // Third circle
            Console.Write("Please input a valid radius for the third circle: ");
            radiusInput = Console.ReadLine();
            double radiusThree = double.Parse(radiusInput);

            circleThree.SetRadius(radiusThree);


            // Prints out all the circle's ToString methods to verify all radii are greater than 0.

            Console.WriteLine();
            circleOne.ToString();
            circleTwo.ToString();
            circleThree.ToString();

        }
    }
}
