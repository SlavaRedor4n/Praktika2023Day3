using Praktika2023Day3;
using System;

internal class Program
{
    public static void Main()
    {
        Employee[] employees = new Employee[10];

        employees[0] = new Employee("Горбачева Наталья Николаевна", 5, 57000.00m);
        employees[1] = new Employee("Приходько Степан Александрович", 3, 85000.00m);
        employees[2] = new Employee("Семенов Дмитрий Анатольевич", 2, 30000.00m);
        employees[3] = new Employee("Годунова Раиса Ивановна", 4, 63000.00m);
        employees[4] = new Employee("Раскольников Сергей Семенович", 5, 20000.00m);
        employees[5] = new Employee("Кацурова Мария Евгеньевна", 1, 27000.00m);
        employees[6] = new Employee("Донской Роман Николаевич", 1, 90000.00m);
        employees[7] = new Employee("Пирогов Степан Борисович", 4, 52000.00m);
        employees[8] = new Employee("Дементьев Александр Артемович", 3, 78000.00m);
        employees[9] = new Employee("Мизина Маргарита Дмитриевна", 5, 19000.00m);

        Employee.DisplayAllEmployees(employees);

        decimal totalWage = Employee.CalculateTotalWage(employees);
        Console.WriteLine("Общая сумма затрат на зарплаты: {0}", totalWage);

        Employee employeeWithMinWage = Employee.FindEmployeeWithMinWage(employees);
        Console.WriteLine("Сотрудник с минимальной зарплатой: {0}", employeeWithMinWage.FullName);

        Employee employeeWithMaxWage = Employee.FindEmployeeWithMaxWage(employees);
        Console.WriteLine("Сотрудник с максимальной зарплатой: {0}", employeeWithMaxWage.FullName);

        decimal averageWage = Employee.CalculateAverageWage(employees);
        Console.WriteLine("Средняя зарплата: {0}", averageWage);

        Employee.DisplayAllEmployeeNames(employees);

        // Новые методы
        decimal percent = 10;
        Employee.IndexSalary(employees, percent);
        Console.WriteLine("Зарплаты всех сотрудников увеличены на {0}%", percent);

        int department = 5;
        Employee employeeWithMinWageByDepartment = Employee.FindEmployeeWithMinWageByDepartment(employees, department);
        Console.WriteLine("Сотрудник с минимальной зарплатой в отделе {0}: {1}", department, employeeWithMinWageByDepartment.FullName);

        int department2 = 3;
        Employee employeeWithMaxWageByDepartment = Employee.FindEmployeeWithMaxWageByDepartment(employees, department2);
        Console.WriteLine("Сотрудник с максимальной зарплатой в отделе {0}: {1}", department2, employeeWithMaxWageByDepartment.FullName);

        decimal averageWageByDepartment = Employee.CalculateAverageWageByDepartment(employees, department2);
        Console.WriteLine("Средняя зарплата в отделе {0}: {1}", department2, averageWageByDepartment);

        decimal amount = 50000;
        Console.WriteLine("Сотрудники с зарплатой ниже {0}:", amount);
        Employee.DisplayEmployeesWithLowerWage(employees, amount);

        decimal amount2 = 60000;
        Console.WriteLine("Сотрудники с зарплатой выше или равной {0}:", amount2);
        Employee.DisplayEmployeesWithHigherOrEqualWage(employees, amount2);

        Console.ReadKey();
    }
}