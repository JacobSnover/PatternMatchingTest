using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternMatchingTest
{
    //make person class with interface inheritance to use in pattern matching
    //can inherit from interface but not classes if using pattern matching
    class Person : IStats
    {
        public int Age { get; set; }
        public int Salary { get; set; }

        public Person() { }

        public Person(int age, int salary)
        {
            Age = age;
            Salary = salary;
        }

        public override string ToString()
        {
            return $"Person age = {Age} Salary = {Salary}";
        }

    }
}
