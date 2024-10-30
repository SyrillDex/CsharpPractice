using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpPrac
{
    class Employees
    {
        public string name;
        public string position;
        public float salary;
        public char ratings;

        public Employees(string name, string position, float salary, char ratings)
        {
            this.name = name;
            this.position = position;
            this.salary = salary;
            this.ratings = ratings;

            Console.WriteLine("Employee name   : " + name );
            Console.WriteLine("Position        : " + position );
            Console.WriteLine("Salary          : " + salary );
            Console.WriteLine("Ratings         : " + ratings );
        }   
    }
}
