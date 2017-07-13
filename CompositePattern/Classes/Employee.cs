using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePattern.Classes
{
    public class Employee
    {
        private string Name;
        private string Department;
        private int Salary;
        private List<Employee> Subordinates;

        public Employee(string name, string department, int salary)
        {
            this.Name = name;
            this.Department = department;
            this.Salary = salary;
            Subordinates = new List<Employee>();
        }

        public void add(Employee e)
        {
            Subordinates.Add(e);
        }

        public void remove(Employee e)
        {
            Subordinates.Remove(e);
        }

        public List<Employee> getSubordinates()
        {
            return Subordinates;
        }

        public override string ToString()
        {
            return String.Format("Employee :[ Name: {0}, Department: {1}, Salary: {2} ]", Name, Department, Salary);
        }
    }
}
