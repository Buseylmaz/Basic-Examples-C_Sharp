using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How many numbers will you enter: ");
            int number_array = Convert.ToInt32(Console.ReadLine());


            int[] numbers = new int[number_array];

            for (int i = 0; i < number_array; i++)
            {
                Console.Write($"{i + 1} .number: ");
                int number = Convert.ToInt32(Console.ReadLine());
                numbers[i] = number;
            }

            Console.Write("The procedure you will perform:(+,-,*,/) ");
            char process = Convert.ToChar(Console.ReadLine());


            switch (process)
            {
                case '+':
                    Addition(numbers);
                    break;
                case '-':
                    Subtraction(numbers);
                    break;
                case '*':
                    Multiplication(numbers);
                    break;
                case '/':
                    Division(numbers);
                    break;
                default:
                    Console.Write("INCORRECT TRANSACTION ENTRY");
                    break;
            }

            Console.Read();
        }

        static int Addition(int[] number)
        {
            int total_addition = 0;

            for (int i = 0; i < number.Length; i++)
                total_addition += number[i];

            Console.WriteLine("Addition: " + total_addition);

            return total_addition;

        }

        static int Subtraction(int[] number)
        {
            int total_subtraction = 0;

            for (int i = 0; i < number.Length; i++)
                total_subtraction -= number[i];

            Console.WriteLine("Subtraction: " + total_subtraction);

            return total_subtraction;

        }

        static int Multiplication(int[] number)
        {
            int total_multiplication = 1;

            for (int i = 0; i < number.Length; i++)
                total_multiplication *= number[i];

            Console.WriteLine("Multiplication: " + total_multiplication);

            return total_multiplication;

        }

        static int Division(int[] number)
        {
            double total_division = number[0];

            for (int i = 1; i < number.Length; i++)
            {
                if (number[i] != 0)
                {
                    total_division /= number[i];
                }
                else
                {
                    Console.WriteLine("Error: Division by zero cannot be performed.");
                    return 0;
                }
            }

            Console.WriteLine("Division:" + total_division);
            return (int)total_division;

        }
    }
}

