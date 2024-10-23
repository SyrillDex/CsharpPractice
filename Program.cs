using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Globalization;

namespace CsharpPrac
{
    class Program
    {
        static void Main(string[] args)
        {
            string day = "pizza";

            switch (day)
            {
                case "Monday":
                    Console.WriteLine("It is " + day);
                    break;
                case "Tuesday":
                    Console.WriteLine("It is " + day);
                    break;
                case "Wednesday":
                    Console.WriteLine("It is " + day);
                    break;
                case "Thursday":
                    Console.WriteLine("It is " + day);
                    break;
                case "Friday":
                    Console.WriteLine("It is " + day);
                    break;
                case "Saturday":
                    Console.WriteLine("It is " + day);
                    break;
                case "Sunday":
                    Console.WriteLine("It is " + day);
                    break;
                default:
                    Console.WriteLine(day + "It is not a day");
                    break;
                //Practice Switch on C#
            }
        }
    }
}