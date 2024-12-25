using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPA
{
    class Program
    {
        static void Main(string[] args)
        {
            Gpa();

            Console.Read();
        }

        static void Gpa()
        {
            try
            {
                int total = 0;
                Console.Write("Please enter the number of how many lessons you have in total:");

                int lesson = Convert.ToInt32(Console.ReadLine());

                for (int i = 0; i < lesson; i++)
                {
                    Console.Write((i + 1) + ". enter the lesson:");
                    int grade = Convert.ToInt32(Console.ReadLine());

                    if (grade>100 || grade<0)
                    {
                        Console.WriteLine("Error");
                        Console.Write((i + 1) + ". enter the lesson:");
                        grade = Convert.ToInt32(Console.ReadLine());
                    }

                    total += grade;
                }

                int average = total / lesson;

                string result = (average > 60) ? "You Passed the Class" : "You Failed the Class";

                Console.Write("Your result:" + result);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error" + ex);
            }


        }
    }
}
