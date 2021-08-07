using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorporateClass.Corporation
{
    public class Company
    {
        // Some properties
        public string Name { get; }
        public DateTime CreatedOn { get; }

        // Create a private property for holding a collection of current employees
        private List<Employee> Employees { get; set; }

        // Create a method that allows a caller to add an employee
        public void AddEmployee(Employee newHire)
        {
            Employees.Add(newHire);
        }

        // Create a method that allows a caller to remove an employee
        public bool RemoveEmployee(string name)
        {
            var employee = new Employee(name, "anything", DateTime.Now);
            return Employees.Remove(employee);
        }

        // Create a method that allows a caller to retrieve the list of employees
        public List<Employee> GetEmployees()
        {
            return Employees;
        }
        public void ListEmployees()
        {
            Console.WriteLine($"     Current Employees of {Name}:");
            Employees.ForEach(employee => Console.Write("     {0:25}, {1:25}\n", employee.Name, employee.Title));
        }

        /*
            Create a constructor method that accepts two arguments:
                1. The name of the company
                2. The date it was created
            The constructor will set the value of the public properties
        */
        public Company(string name, DateTime dateCreated)
        {
            Name = name;
            CreatedOn = dateCreated;
            Employees = new List<Employee>();
        }
    }
}
