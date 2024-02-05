using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circle_Objects
{
    internal class Circle
    {
        //properties
        private double Radius { get; set; }

        //Constructer 
        public  Circle (double _radius)
        {
            Radius = _radius;
        }

        //METHODS

        //Diameter
        public double CalculateDiameter(double radius)
        {
            double diameter = 2 * radius;
            return diameter;
        }

        //Circumference
        public double CalculateCircumference(double radius)
        {
            double circumference = 2 * Math.PI * radius;
            return circumference;
        }

        //Area 
        public double CalculateArea (double radius)
        {
            double area = Math.PI * radius * radius;
            return area;
        }

        //Grow
        public void Grow(double radius)
        {
           Radius = 2 * radius;
        }
        // final radius 
        public double GetRadius()
        {
            return Radius;
        }















    }
}
