using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GCLab9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Circle Maker!");

            bool repeat = true;
            while (repeat)
            {
                double radius = Validator.GetRadius("Please enter the radius of the circle: ");

                Circle circle1 = new Circle(radius);

                double circumference = circle1.GetCircumference();
                double area = circle1.GetArea();

                Console.WriteLine($"\nCircumference: {circle1.GetFormattedCircumference()}");
                Console.WriteLine($"Area : {circle1.GetFormattedArea()}");

                repeat = Validator.Continue("\nWould you like to make another Circle? (y/n): ");
            }
            Console.Write($"\nYou made {Circle.numCircles} Circle(s)! \nThank you for making Circles! ");
            Console.ReadLine();
        }
    }
}