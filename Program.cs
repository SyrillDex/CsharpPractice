using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Globalization;

namespace CsharpPrac
{
    class Program
    {
        static void Main(string[] args)
        {

            Students firstYear = new FirstYear("Kupal", 12);
            Students secondYear = new SecondYear("Asim", 32);

            firstYear.studentInfo();
            secondYear.studentInfo();

        }
    }

    abstract class Students
    {
        public string name { get; set; }
        public int age { get; set; }

        public Students(string name, int age)
        {
            this.name = name;
            this.age = age;
        }
        public abstract void studentInfo();

    }

    class FirstYear : Students
    {
        public FirstYear(string name, int age)
            : base(name, age) { }

        public override void studentInfo()
        {
            Console.WriteLine("Name : " + name);
            Console.WriteLine("Age  : " + age);
        }
    }

    class SecondYear : Students
    {
        public SecondYear(string name, int age)
            : base(name, age) { }

        public override void studentInfo()
        {
            Console.WriteLine("Name : " + name);
            Console.WriteLine("Age  : " + age);
        }
    }
}