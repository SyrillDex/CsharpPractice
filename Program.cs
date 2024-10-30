using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Globalization;

namespace CsharpPrac
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Arithmetic.add(Constants.PI, Constants.GRAVITY));
        }
        
    }
}