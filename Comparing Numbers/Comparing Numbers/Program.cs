using System;

namespace Comparing_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Numbers();

            Console.ReadLine();
        }

        static void Numbers()
        {
            Console.Write("How many numbers will be entered?:");
            int numberArray = Convert.ToInt32(Console.ReadLine());

            int[] number = new int[numberArray];

            for (int i = 0; i < numberArray; i++)
            {
                Console.Write("Enter a number:");
                int s = Convert.ToInt32(Console.ReadLine());
                number[i] = s;
            }

            Array.Sort(number);

            Array.Reverse(number);

            foreach (var n in number)
            {
                Console.Write(n + "-");
            }



        }
    }
}
