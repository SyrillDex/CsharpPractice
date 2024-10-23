using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Globalization;

namespace CsharpPrac
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Month: ");
            int month = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Day  : ");
            int day = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Year : ");
            int year = Convert.ToInt32(Console.ReadLine());

            if (day > 31)
            {
                Console.WriteLine("Invalid day");
            }
            else
            {
                switch (month)
                {
                    case 1:
                        Console.WriteLine("January " + day + ", " + year);
                        break;
                    case 2:
                        Console.WriteLine("February " + day + ", " + year);
                        break;
                    case 3:
                        Console.WriteLine("March " + day + ", " + year);
                        break;
                    case 4:
                        Console.WriteLine("April " + day + ", " + year);
                        break;
                    case 5:
                        Console.WriteLine("May " + day + ", " + year);
                        break;
                    case 6:
                        Console.WriteLine("June " + day + ", " + year);
                        break;
                    case 7:
                        Console.WriteLine("July " + day + ", " + year);
                        break;
                    case 8:
                        Console.WriteLine("August " + day + ", " + year);
                        break;
                    case 9:
                        Console.WriteLine("September " + day + ", " + year);
                        break;
                    case 10:
                        Console.WriteLine("October " + day + ", " + year);
                        break;
                    case 11:
                        Console.WriteLine("November " + day + ", " + year);
                        break;
                    case 12:
                        Console.WriteLine("December " + day + ", " + year);
                        break;
                    default:
                        Console.WriteLine("Invalid Input");
                        break;
                }
            }

            
            
        }
    }
}