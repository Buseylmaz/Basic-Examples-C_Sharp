using System;

namespace The_Program_that_Finds_the_Hypotenuse
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the first edge: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the second edge: ");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the third edge: ");
            int c = Convert.ToInt32(Console.ReadLine());

            Hypotenuse(a, b);
            TriangleArea(a, b, c);

            Console.Read();
        }

        static int Hypotenuse(int edge1, int edge2)
        {
            int edge3 = (edge1 * edge1) + (edge2 * edge2);
            double a = Math.Sqrt(edge3);
            Console.WriteLine("Hypotenuse edge:" + a);
            return edge3;
        }

        static int TriangleArea(int edge1, int edge2, int edge3)
        {
            int u = (edge1 + edge2 + edge3) / 2;
            int area = (u * (u - edge1) * (u - edge2) * (u - edge3));

            Console.WriteLine("Triangle area:" + area);
            return area;


        }
    }
}
