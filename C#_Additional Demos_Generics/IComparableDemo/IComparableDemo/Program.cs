using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IComparableDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create an arary of emp objects.      
            Employee[] arrayOfEmployees = new Employee[6]
            {
            new Employee("Suresh",32),new Employee("Rekha",28),
            new Employee("Anitha",29),new Employee("Ekta",32),
            new Employee("Bala",49),new Employee("Dinesh",37)
            };
            
            Console.WriteLine("Array - Unsorted\n");
            foreach (Employee e in arrayOfEmployees)
                Console.WriteLine(e.Name + "\t\t" + e.Age);

            // Demo IComparable by sorting array with "default" sort order.
            Array.Sort(arrayOfEmployees);
            Console.WriteLine("\nArray - Sorted by Name (Ascending - IComparable)\n");
            foreach (Employee e in arrayOfEmployees)
            {
                Console.WriteLine(e.Name + "\t\t" + e.Age);
            }
            Console.ReadKey();
        }
    }
}
