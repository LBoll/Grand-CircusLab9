using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GCLab9
{
    class Circle
    {
        public static int numCircles = 0;
        const double PI = Math.PI;
        public double radius { get; set; }

        public Circle(double radius)
        {
            this.radius = radius;
            numCircles++;
        }

        public double GetCircumference()
        {
            return radius * PI * 2;
        }

        public String GetFormattedCircumference()
        {
            return FormatNumber(GetCircumference());
        }

        public double GetArea()
        {
            return (radius * radius) * PI;
        }

        public String GetFormattedArea()
        {
            return FormatNumber(GetArea());
        }

        private String FormatNumber(double x)
        {
            return $"{x,0:N2}";
        }
    }
}