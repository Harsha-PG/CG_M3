using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace IComparableDemo
{
    class Employee: IComparable
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Employee(string name, int age)
        {
            Name = name;
            Age = age;
        }



        int IComparable.CompareTo(object obj)
        {
            Employee c = (Employee)obj;
            return string.Compare(this.Name, c.Name);
        }

        public class SampleComparer:IComparer
        {
            int IComparer.Compare(object a, object b)
            {
                Employee c1 = (Employee)a;
                Employee c2 = (Employee)b;

                if (c1.Age > c2.Age)
                    return 1;
                if (c1.Age < c2.Age)
                    return -1;
                else
                    return 0;
            }
        }
        }
    }


