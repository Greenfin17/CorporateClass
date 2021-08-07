using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorporateClass.Corporation
{
    public class Employee : IEquatable<Employee>
    {
        public string Name { get; }
        public string Title { get; }
        public DateTime HireDate { get; set; }

        public Employee(string name, string title, DateTime hireDate)
        {
            Name = name;
            Title = title;
            HireDate = hireDate;
        }

        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            Employee objasEmployee = obj as Employee;
            if (objasEmployee == null) return false;
            else return Equals(objasEmployee);
        }
        public bool Equals(Employee otherEmployee)
        {
            if (otherEmployee == null) return false;
            return (this.Name.Equals(otherEmployee.Name));
        }

        public override int GetHashCode()
        {
            return Name.GetHashCode() ^ Title.GetHashCode() ^ HireDate.GetHashCode();
        }
    }
}
