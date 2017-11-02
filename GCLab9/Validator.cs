using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GCLab9
{
    class Validator
    {
        public static bool Continue(string answer)
        {
            Console.Write(answer);
            string input = Console.ReadLine().ToLower();
            if (input == "y")
            {
                return true;
            }
            else if (input == "n")
            {
                return false;
            }
            else
            {
                Console.Write("Sorry, invalid input!");
                return Continue(answer);
            }
        }

        public static double GetRadius(string answer)
        {
            double radius = 0;
            bool success = false;
            while (!success)
            {
                Console.Write(answer);
                string input = Console.ReadLine();
                success = double.TryParse(input, out radius);

                if (radius <= 0.0)
                {
                    Console.WriteLine("Sorry, invalid input! Try again: ");
                    success = false;
                }
            }
            return radius;
        }
    }
}