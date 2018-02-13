using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternMatchingTest
{
    class Program
    {
        static void Main(string[] args)
        {
            //make object variables to try with pattern matching
            object a = 0;
            object b = "Hello";
            object c = 2.0;

            //print variables before modifying
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
            Console.WriteLine();

            //use pattern matching to modify the variables
            a = Add(a);
            b = Add(b);
            c = Add(c);

            //print same variable after modifiying
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
            Console.WriteLine();

            //make instances of my objects to use in pattern matching
            Person p = new Person(25,100);
            Student s = new Student(25,100);
            Staff st = new Staff(25,100);

            //add object to array to show pattern matching in for loops later
            object[] temp = new object[3];
            temp[0] = p;
            temp[1] = s;
            temp[2] = st;

            //show objects before for loop
            Console.WriteLine("Before for loop.");
            Console.WriteLine(p);
            Console.WriteLine(s);
            Console.WriteLine(st);

            //use for loop and pattern matching on object array
            for (int i = 0; i < temp.Length; i++)
            {
                if (temp[i] is Person)
                {
                    var per = temp[i] as Person;
                    p.Age += 25;
                }
                else if (temp[i] is Student stu)
                {
                    s.Age += 25;
                }
                else if (temp[i] is Staff stf)
                {
                    st.Age += 25;

                }
            }

            //show objects after for loop
            Console.WriteLine("After for loop and Before switch case statement.");
            Console.WriteLine(p);
            Console.WriteLine(s);
            Console.WriteLine(st);

            //use pattern matching method to modify objects
            p.Salary = (int)Add(p);
            s.Salary = (int)Add(s);
            st.Salary = (int)Add(st);
            Console.WriteLine();

            //show objects after pattern matching
            Console.WriteLine("After switch case statement.");
            Console.WriteLine(p);
            Console.WriteLine(s);
            Console.WriteLine(st);

            //use if statement pattern matching method to modify objects
            p.Age = Older(p);
            s.Age = Older(s);
            st.Age = Older(st);
            Console.WriteLine();

            //show objects after modifying
            Console.WriteLine("After if statement");
            Console.WriteLine(p);
            Console.WriteLine(s);
            Console.WriteLine(st);
             
        }

        //pattern matching method with switch case to modify objects
        public static object Add(object human)
        {
            switch (human)
            {
                case int b:
                    return b + 20;
                case string a:
                    return a + "World";
                case double c:
                    return c + 22.5;
                case Person p when p.Salary < 1000:
                    return p.Salary + 1000;
                case Student s:
                    return s.Salary + 23;
                case Staff b:
                    return b.Salary + 50;

                default:
                    throw new ArgumentException(
                        message: "object is not a recognized human",
                        paramName: nameof(human));
            }
        }

        //pattern matching method with if's to modify objects
        public static int Older(object human)
        {
            if (human is Person)
            {
                var p = human as Person;
                return p.Age + 25;
            }
            else if (human is Student s)
            {
                return s.Age + 25;
            }
            else if (human is Staff st)
            {
                return st.Age + 25;
            }
            return 0;
        }

       
    }

    

    

    

    
}
