using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Area_and_Environment_Calculation
{
    class Program
    {
        static void Main(string[] args)
        {
            double pi = 3.14;
            Console.Write("Please write the radius of the circle:");
            int r = Convert.ToInt32(Console.ReadLine());

            Console.Write("Please enter the middle angle of the circle:");
            double a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Area:" + Area(pi, r));
            Console.WriteLine("Environmental:" + Environmental(pi, r));
            Console.Write("The Area of the Quarter Circle:" + TheAreaOfTheQuarterCircle(pi, r, a));

            Console.Read();

        }

        static double Area(double pi, int r)
        {
            return pi * Math.Pow(r, 2);
        }

        static double Environmental(double pi, int r)
        {
            return 2 * pi * r;
        }

        static double TheAreaOfTheQuarterCircle(double pi, int r, double a)
        {
            return (Area(pi, r) * a) / 360;
        }
    }
}

