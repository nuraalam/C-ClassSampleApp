using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircleApp
{
    public class CircleCalculation
    {
       
        
        public double GetDiameter(double radius)

        {
            return 2*radius;
        }
        public double GetPerimeter(double radius)
        {
            return 2 *Math.PI* radius;
        }
        public double GetArea(double radius)
        {
            return 2 * Math.PI*radius*radius;
        }

        public static void Main()
        {
            double radius = 2.2;
            //Console.WriteLine();
            // Console.ReadLine("Enter radius  : ");


        }
    }
}
