using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.Java;
class StudentResult
{
    public static void Show()
    {
        List<Student> students = new List<Student>()
        {
            new Student{Id = 101, Name = "Isra", Marks = 85 },
            new Student{Id = 102, Name = "Irtaza", Marks = 88 },
            new Student{Id = 103, Name = "Hira", Marks = 55 },
            new Student{Id = 104, Name = "Aina", Marks = 95 },
            new Student{Id = 105, Name = "Zayad", Marks = 50 },
        };
        var passedStudents = students.Where(S => S.Marks > 50);
        Console.WriteLine("Passed Students: ");
        foreach(var student in passedStudents)
        {
            Console.WriteLine(student.Name + " - " + student.Marks);
        }
        var ranking = students.OrderByDescending(s => s.Marks);
        Console.WriteLine("\nStudent Ranking:");
        foreach(var student in ranking)
        {
            Console.WriteLine(student.Name + "-" + student.Marks);
        }
        double average = students.Average(s => s.Marks);
        Console.WriteLine("\n Average marks: " + average);
        bool anyTopStudent = students.Any(s => s.Marks > 90);
        Console.WriteLine("Any student scored 90 or above: " + anyTopStudent);
        bool allPassed = students.All(s => s.Marks >= 50);
        Console.WriteLine("All students passed : " + allPassed);
    }
}