using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternMatchingTest
{
    //basic interface to show that pattern matching works if inheriting interface, but not calss inheritance
    interface IStats
    {
        int Age { get; set; }
        int Salary { get; set; }
    }
}
