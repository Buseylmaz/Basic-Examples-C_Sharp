using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KDV
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter the Amount of Money:");
            double amount_money = Convert.ToDouble(Console.ReadLine());

            if (amount_money < 0)
            {
                Console.WriteLine("The Amount of Money cannot be less than 0.");
            }

            double kdv = DetermineTheKDVRate(amount_money);
            double calculate_money = CalculateMoney(amount_money, kdv);


            Console.Write("Your Amount of Money:" + calculate_money);
            Console.Read();
        }

        static double DetermineTheKDVRate(double money)
        {
            return money < 1000 ? 0.18 : 0.08;
        }

        static double CalculateMoney(double money, double kdv)
        {
            return (money * kdv) + money;
        }
    }
}
