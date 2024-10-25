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
            bool isFound = false;

            Console.Write("Username: ");
            string username = Console.ReadLine();

            Console.Write("Password: ");
            string password = Console.ReadLine();

            Console.WriteLine();

            for (int i = 0; i < usernames.Length; i++) 
            { 
                if (username.Equals(usernames[i]) && password.Equals(passwords[i]))
                {
                    isFound = true;
                    Console.WriteLine("Welcome " + usernames[i]);
                    break;
                }
            }
            if (isFound = false) Console.WriteLine("Not found");

        }
    }
}