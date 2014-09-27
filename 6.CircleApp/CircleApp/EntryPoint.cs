using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircleApp
{
    class EntryPoint
    {
        private static void Main()
        {
            CircleCalculation calculation=new CircleCalculation();
            double radius;
            Console.WriteLine("Enter Radius :   ");
            radius=Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("\nDiameter "+calculation.GetDiameter(radius));
            Console.WriteLine("\nPerameter  " + calculation.GetPerimeter(radius));
            Console.WriteLine("\nArea  " + calculation.GetArea(radius));


            Console.ReadKey();



        }
    }
}
