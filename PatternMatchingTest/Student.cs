using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternMatchingTest
{
    class Student
    {
        //make student class to use with pattern matching
        public int Age { get; set; }
        public int Salary { get; set; }

        public Student() { }

        public Student(int age, int salary)
        {
            Age = age;
            Salary = salary;
        }

        public override string ToString()
        {
            return $"Student age = {Age} Salary = {Salary}";
        }
    }
}
