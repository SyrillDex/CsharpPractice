using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Globalization;

namespace CsharpPrac
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input name: ");
            string name = Console.ReadLine();

            Console.Write("Input position: ");
            string position = Console.ReadLine();

            Console.Write("Input salary: ");
            float salary = Convert.ToSingle(Console.ReadLine());

            Console.Write("Input ratings: ");
            char ratings = (char) Convert.ToChar(Console.ReadLine());

            Employees employees = new Employees(name, position, salary, ratings);
        }

    }
}