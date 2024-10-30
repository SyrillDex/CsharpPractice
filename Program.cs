using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Globalization;

namespace CsharpPrac
{
    class Program
    {
        static void Main(string[] args)
        {
            Employees students = new Employees("John", "Doe", "2024", "CPe", "CAlimbo", 70, 90);
            students.introduceSelf();
            Console.WriteLine(students.evaluateGrade());
        }

    }
}