using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IComparerDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create an arary of Employees objects.      
            Employee[] arrayOfEmployees = new Employee[6]
            {
                new Employee("Suresh",32),new Employee("Rekha",28),new Employee("Anitha",29),
                new Employee("Ekta",32),new Employee("Bala",49), new Employee("Dinesh",37)
            };

            Console.WriteLine("Array - Unsorted\n");
            foreach (Employee c in arrayOfEmployees)
                Console.WriteLine(c.Name + "\t\t" + c.Age);

            // Demo IComparable by sorting array with "default" sort order.
            Array.Sort(arrayOfEmployees);
            Console.WriteLine("\nArray - Sorted by Name (Ascending - IComparable)\n");
            foreach (Employee c in arrayOfEmployees)
                Console.WriteLine(c.Name + "\t\t" + c.Age);

            // IComparer Implementation
            // Demo ascending sort of numeric value with IComparer.
            Array.Sort(arrayOfEmployees, Employee.SortAgeAscending());
            Console.WriteLine("\nArray - Sorted by Age (Ascending - IComparer)\n");

            foreach (Employee c in arrayOfEmployees)
                Console.WriteLine(c.Name + "\t\t" + c.Age);

            // Demo descending sort of numeric value using IComparer.
            Array.Sort(arrayOfEmployees, Employee.SortAgeDescending());
            Console.WriteLine("\nArray - Sorted by Age (Descending - IComparer)\n");

            foreach (Employee c in arrayOfEmployees)
            {
                Console.WriteLine(c.Name + "\t\t" + c.Age);
            }

            Console.Read();

        }
    }
}
