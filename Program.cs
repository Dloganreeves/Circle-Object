using System.ComponentModel.Design;

namespace Circle_Objects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double radius;
            bool loop1 = true;
            Console.WriteLine("Welcome to the Circle tool. Please enter in the radius of your circle.");
            while (double.TryParse(Console.ReadLine(), out radius) == false || radius <= 0)
            {
                Console.WriteLine("Error: Please enter a valid radius");
            }

           Circle circle1 = new Circle(radius);
            while (loop1)
            {
                Console.WriteLine($"The diameter is: {circle1.CalculateDiameter(circle1.GetRadius())}");
                Console.WriteLine($"The circumference is: {circle1.CalculateCircumference(circle1.GetRadius())}");
                Console.WriteLine($"The Area is: {circle1.CalculateArea(circle1.GetRadius())}");
                Console.WriteLine("Should the circle grow? ('y' or 'n')");
                string choice = Console.ReadLine().ToLower().Trim();
                if (choice == "y")
                {
                    Console.WriteLine("The circle is magically growing.");
                    circle1.Grow(circle1.GetRadius());
                }
                else if (choice == "n")
                {
                    Console.WriteLine($"Goodbye. The ciricle's final radius is {circle1.GetRadius()}");
                    loop1 = false;

                }
                else
                {
                    Console.WriteLine("Please only enter'y' or 'n'");
                }
            }
        }
    } 
}
