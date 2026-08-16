using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
class EmployeeManagement
{
    public static void Show()
    {
        List<Employee>employees = new List<Employee>()
        {
            new Employee {Id = 1, Name= "Zoha", Department= "IT", Salary= 50000 },
            new Employee {Id = 2, Name = "Arsalan", Department = "HR", Salary = 60000 },
            new Employee { Id = 3, Name = "Alamgeer", Department = "Finance", Salary = 70000 },
            new Employee { Id = 4, Name = "Sohrab", Department = "IT", Salary = 100000 },
            new Employee { Id = 5, Name = "Banafsha", Department = "HR", Salary = 50000 },
        };
        var highsalary = employees.Where(e => e.Salary > 60000); 
        Console.WriteLine("Employees having salary greater than 60000: ");
        foreach(var Employee in highsalary)
        {
            Console.WriteLine(Employee.Name + "-" + Employee.Salary);
        }
        var sortedEmployees = employees.OrderBy(e => e.Salary);
        Console.WriteLine("\n Employees sorted by salary:");
        foreach(var Employee in sortedEmployees)
        {
            Console.WriteLine(Employee.Name + "-" + Employee.Salary);
        }
        var names = employees.Select(e => e.Name);
        Console.WriteLine("\n Employees names:");
        foreach(var name in names)
        {
            Console.WriteLine(name);
        }
        Console.WriteLine("\nTotal Employees: " + employees.Count());
        Console.WriteLine("\nAverage Salary: " + employees.Average(e => e.Salary));
    }
}