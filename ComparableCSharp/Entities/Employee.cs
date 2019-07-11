using System;
using System.Globalization;

namespace ComparableCSharp.Entities
{
    class Employee : IComparable
    {
        public string Name { get; set; }
        public double Salary { get; set; }

        public Employee (string csvEmployee)
        {
            string[] employee = csvEmployee.Split(',');
            Name = employee[0];
            Salary = double.Parse(employee[1], CultureInfo.InvariantCulture);
        }

        public override string ToString()
        {
            return Name + ", " + Salary.ToString("F2", CultureInfo.InvariantCulture);
        }

        public int CompareTo(object obj)
        {
            if(!(obj is Employee))
            {
                throw new ArgumentException("Comparing error: argument is not an Employee");
            }
            Employee other = obj as Employee;

            return Salary.CompareTo(other.Salary);
        }
    }
}
