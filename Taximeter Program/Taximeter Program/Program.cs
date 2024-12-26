using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taximeter_Program
{
    class Program
    {
        static void Main(string[] args)
        {
            double r = Road();
            RoadToll(r);

            Console.Read();

        }

        static double Road()
        {
            Console.Write("How many km did you travel?:");
            double roadLength = Convert.ToDouble(Console.ReadLine());

            return roadLength;
        }

        static double RoadToll(double roadLength)
        {
            int beginning = 10;
            int minFee = 20;
            double kmFee = 2.20;

            double roadToll = (roadLength * kmFee) + beginning;

            if (roadToll < minFee)
            {
                roadToll = minFee;
            }

            Console.Write("Road toll" + roadToll);


            return roadToll;


        }
    }
}
