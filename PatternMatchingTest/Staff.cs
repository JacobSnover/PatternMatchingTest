using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternMatchingTest
{
    //built struct to use with pattern matching
    struct Staff
    {
        public int Age { get; set; }
        public int Salary { get; set; }

        public Staff(int age, int salary)
        {
            Age = age;
            Salary = salary;
        }

        public override string ToString()
        {
            return $"Staff age = {Age} Salary = {Salary}";
        }
    }
}
