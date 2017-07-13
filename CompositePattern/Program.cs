using CompositePattern.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePattern
{
    class Program
    {
        public static void Main(string[] args)
        {
            Employee CEO = new Employee("John", "CEO", 1000000);
            Employee headSales = new Employee("Sarah", "Head Sales", 200000);
            Employee headMarketing = new Employee("Carlos", "Head Marketing", 200000);

            Employee clerk1 = new Employee("Laura", "Marketing", 60000);
            Employee clerk2 = new Employee("Bob", "Marketing", 60000);

            Employee salesExecutive1 = new Employee("Richard", "Sales", 55000);
            Employee salesExecutive2 = new Employee("Elizabeth", "Sales", 55000);

            CEO.add(headMarketing);
            CEO.add(headSales);

            headMarketing.add(clerk1);
            headMarketing.add(clerk2);

            headSales.add(salesExecutive1);
            headSales.add(salesExecutive2);

            Console.WriteLine(CEO.ToString());

            foreach (Employee headEmployee in CEO.getSubordinates())
            {
                Console.WriteLine("\n");
                Console.WriteLine(headEmployee.ToString());
                foreach (Employee employee in headEmployee.getSubordinates())
                {
                    Console.WriteLine(employee.ToString());
                }
            }

            Console.ReadLine();
        }
    }
}
