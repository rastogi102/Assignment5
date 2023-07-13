using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConAssignment5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string correctUsername = "admin";
            string correctPassword = "pass123";
            int attempts = 3;

            while (attempts > 0)
            {
                Console.Write("Enter username: ");
                string username = Console.ReadLine();

                Console.Write("Enter password: ");
                string password = Console.ReadLine();

                if (username == correctUsername)
                {
                    if (password == correctPassword)
                    {
                        Console.WriteLine("Login successful.");
                        return; // Terminate the program after successful login
                    }
                    else
                    {
                        Console.WriteLine("Invalid password.");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid username.");
                }

                attempts--;
            }

            Console.WriteLine("Login failed.");
        }
    }
}
