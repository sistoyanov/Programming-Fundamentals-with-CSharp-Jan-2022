using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Company_Roster
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            List<Employee> employees = new List<Employee>();
            List<Department> departments = new List<Department>();

            for (int i = 1; i <= count; i++)
            {
                string[] employeeArg = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string name = employeeArg[0];
                decimal salary = decimal.Parse(employeeArg[1]);
                string depatment = employeeArg[2];

                employees.Add(new Employee(name, salary));

                if (!departments.Any(d => d.DeparmentName == depatment))
                {
                    departments.Add(new Department(depatment));
                }

                Department departmentToAdd = departments.Find(d => d.DeparmentName == depatment);
                departmentToAdd.AddNewEmployee(name, salary);
            }

            Department bestDepartment = departments.OrderByDescending(d => d.TotalSalaries / d.Employees.Count()).First();

            Console.WriteLine($"Highest Average Salary: {bestDepartment.DeparmentName}");

            foreach (var employee in bestDepartment.Employees.OrderByDescending(e => e.Salary))
            {
                Console.WriteLine($"{employee.Name} {employee.Salary:F2}");
            }

        }
    }

    class Employee
    {
        public Employee(string name, decimal salary)
        {
            this.Name = name;
            this.Salary = salary;
        }
        public string Name { get; set; }
        public decimal Salary { get; set; }
    }

    class Department
    {
        public Department(string department)
        {
            this.DeparmentName = department;
            this.Employees = new List<Employee>();
        }
        public string DeparmentName { get; set; }
        public List<Employee> Employees { get; set;}
        public decimal TotalSalaries { get; set; }

        public void AddNewEmployee(string employeeName, decimal employeeSalary)
        {
            this.TotalSalaries += employeeSalary;
            this.Employees.Add(new Employee(employeeName, employeeSalary));
        }


    }
}
