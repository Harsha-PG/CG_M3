using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IComparerDemo
{
    class Employee : IComparable
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Employee(string name, int age)
        {
            Name = name;
            Age = age;
        }
        // Default Sorting
        int IComparable.CompareTo(object obj)
        {
            Employee c = (Employee)obj;
            return string.Compare(this.Name, c.Name);
        }

        // The role of IComparer is to provide additional comparison mechanisms. 
        // For example, you may want to provide ordering of your class on several fields or properties, 
        // ascending and descending order on the same field, or both.

        // Using IComparer is a two-step process.
        // First, declare a class that implements IComparer, 
        // and then implement the Compare method: 

        // Beginning of nested classes.
        // Nested class to do ascending sort on age property.
        private class SortEmployeeByAgeAscendingHelper : IComparer
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

        // Nested class to do descending sort on age property.
        private class SortEmployeeByAgeDescendingHelper : IComparer
        {
            int IComparer.Compare(object a, object b)
            {
                Employee c1 = (Employee)a;
                Employee c2 = (Employee)b;

                if (c1.Age < c2.Age)
                    return 1;
                if (c1.Age > c2.Age)
                    return -1;
                else
                    return 0;
            }
        }


        // The second step is to declare a method that returns 
        // an instance of your IComparer object:

        // Method to return IComparer object for sort helper.
        public static IComparer SortAgeAscending()
        {
            return (IComparer)new SortEmployeeByAgeAscendingHelper();
        }

        // Method to return IComparer object for sort helper.
        public static IComparer SortAgeDescending()
        {
            return (IComparer)new SortEmployeeByAgeDescendingHelper();
        }
    }
}
