using System;
using System.Collections.Generic;
using System.Linq;

class Course
{
    private string courseName;
    private string courseCode;
    private List<Student> students = new List<Student>();

    public Course(string name, string code)
    {
        courseName = name;
        courseCode = code;
    }

    public void AddStudent(Student s)
    {
        students.Add(s);
    }

    public void ShowAllStudents()
    {
        Console.WriteLine($"\n📚 Course: {courseName} ({courseCode})");

        foreach (var s in students)
        {
            s.ShowInfo();
        }
    }

    public void ShowStatistics()
    {
        if (students.Count == 0)
        {
            Console.WriteLine("No students.");
            return;
        }

        double max = students.Max(s => s.GetScore());
        double min = students.Min(s => s.GetScore());
        double avg = students.Average(s => s.GetScore());

        Console.WriteLine($"\n Max Score: {max}");
        Console.WriteLine($" Min Score: {min}");
        Console.WriteLine($" Average Score: {avg:F2}");
    }
}