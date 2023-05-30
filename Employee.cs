using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktika2023Day3
{
    internal class Employee
    { 
            private static int counter = 0;

            private int id;
            private string fullName;
            private int department;
            private decimal wage;

            public Employee(string fullName, int department, decimal wage)
            {
                id = ++counter;
                this.fullName = fullName;
                this.department = department;
                this.wage = wage;
            }

            public int Id
            {
                get { return id; }
            }

            public string FullName
            {
                get { return fullName; }
            }

            public int Department
            {
                get { return department; }
                set { department = value; }
            }

            public decimal Wage
            {
                get { return wage; }
                set { wage = value; }
            }

            public static void DisplayAllEmployees(Employee[] employees)
            {
                foreach (Employee employee in employees)
                {
                    Console.WriteLine("ID: {0}, ФИО: {1}, Отдел: {2}, Зарплата: {3}", employee.Id, employee.FullName, employee.Department, employee.Wage);
                }
            }

            public static decimal CalculateTotalWage(Employee[] employees)
            {
                decimal totalWage = 0;
                foreach (Employee employee in employees)
                {
                    totalWage += employee.Wage;
                }
                return totalWage;
            }

            public static Employee FindEmployeeWithMinWage(Employee[] employees)
            {
                Employee employeeWithMinWage = employees[0];
                for (int i = 1; i < employees.Length; i++)
                {
                    if (employees[i].Wage < employeeWithMinWage.Wage)
                    {
                        employeeWithMinWage = employees[i];
                    }
                }
                return employeeWithMinWage;
            }

            public static Employee FindEmployeeWithMaxWage(Employee[] employees)
            {
                Employee employeeWithMaxWage = employees[0];
                for (int i = 1; i < employees.Length; i++)
                {
                    if (employees[i].Wage > employeeWithMaxWage.Wage)
                    {
                        employeeWithMaxWage = employees[i];
                    }
                }
                return employeeWithMaxWage;
            }

            public static decimal CalculateAverageWage(Employee[] employees)
            {
                decimal totalWage = CalculateTotalWage(employees);
                decimal averageWage = totalWage / employees.Length;
                return averageWage;
            }

            public static void DisplayAllEmployeeNames(Employee[] employees)
            {
                foreach (Employee employee in employees)
                {
                    Console.WriteLine("ФИО: {0}", employee.FullName);
                }
                }
            }
        }
    
