using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpPrac
{
    class Employees
    {
        public string firstName, lastName, year, course, section;
        public int midtermGrade, finalGrade;

        public Employees(string firstName, string lastName, string year, string course, string section, int midtermGrade, int finalGrade)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.year = year;
            this.course = course;
            this.section = section;
            this.midtermGrade = midtermGrade;
            this.finalGrade = finalGrade;
        }

        public void introduceSelf()
        {
            Console.WriteLine(firstName + " " + lastName);
            Console.WriteLine(year + " " + section);
        }
        public string evaluateGrade()
        {
            int sum = (midtermGrade + finalGrade) / 2;
            if (sum > 100) return "Invalid Grade";
            else if (sum >= 98) return "With Highest Honor";
            else if (sum >= 95) return "With High Honor";
            else if (sum >= 90) return "With Honor";
            else if (sum >= 75) return "Passed";
            else return "Failed";
        }
    }
}
