using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Password_Control
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = "pass123456";

            Console.Write("Please enter your password:");
            string pass = Console.ReadLine();

            if (password == pass)
            {
                Console.Write("The password is correct.");
            }

            else if (password != pass)
            {
                Console.WriteLine("The password is wrong!!!! Would you like to try again?(Y/N):");

                char choice = Convert.ToChar(Console.ReadLine());

                switch (choice)
                {
                    case 'Y':
                        Console.WriteLine("Please enter your password:");
                        string pass1 = Console.ReadLine();
                        if (password == pass1)
                        {
                            Console.WriteLine("The password is correct.");
                        }
                        else
                        {
                            Console.WriteLine("The password is wrong!!!! Set a new password!!!");
                            Console.Write("Enter your new password:");
                            string newPassword = Console.ReadLine();
                            password = newPassword;
                            Console.WriteLine("The password was successfully updated. " + password);

                        }
                        break;
                    case 'N':
                        break;
                    default:
                        break;
                }
            }


            Console.Read();
        }
    }
}
