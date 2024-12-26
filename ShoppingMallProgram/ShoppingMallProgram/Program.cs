using System;

namespace ShoppingMallProgram
{
    class Program
    {
        enum Fruit
        {
            PEAR = 214,  // The price is 2.14 TL, but we keep the penny as an exact number.
            APPLE = 367,
            TOMATO = 111,
            BANANAS = 95,
            EGGPLANT = 500
        }

        static void Main(string[] args)
        {
            double totalAmount = 0.0;

            // We take the kilogram values for each fruit from the user.
            foreach (Fruit fruit in Enum.GetValues(typeof(Fruit)))
            {
                Console.WriteLine($"{fruit} how many kg?");
                double kg = Convert.ToDouble(Console.ReadLine());

                double fruitPrice = (int)fruit / 100.0;// We take the fruit price as a penny and convert it to TL by dividing by 100.
                totalAmount += fruitPrice * kg;
            }

            Console.WriteLine($"Total Amount: {totalAmount:F2} TL");

            Console.ReadLine();
        }
    }
}
