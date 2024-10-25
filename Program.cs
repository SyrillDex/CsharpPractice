using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Globalization;

namespace CsharpPrac
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] usernames = { "Syrill", "Whilnhet", "Love", "Bebi" };
            string[] passwords = {"Syrill123", "Whilnhet123", "Love123", "Bebi123" };

            Console.Write("Username: ");
            string username = Console.ReadLine();

            Console.Write("Password: ");
            string password = Console.ReadLine();

            Console.WriteLine();

            for (int i = 0; i < usernames.Length; i++) 
            { 
                if (username.Equals(usernames[i]) && password.Equals(passwords[i]))
                {
                    Console.WriteLine("Welcome " + usernames[i]);
                    break;
                }
                else
                {
                    Console.WriteLine("User Not Found, Please try again");
                    Console.WriteLine();
                }
            }

        }
    }
}