using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Course> courses = new List<Course>();

        while (true)
        {
            Console.WriteLine("\n===== MENU =====");
            Console.WriteLine("1. Create Course");
            Console.WriteLine("2. Add Student");
            Console.WriteLine("3. Show Data");
            Console.WriteLine("4. Exit");
            Console.Write("Choose: ");
            string choice = Console.ReadLine();

            if (choice == "1")
            {
                Console.Write("Course Name: ");
                string name = Console.ReadLine();

                Console.Write("Course Code: ");
                string code = Console.ReadLine();

                courses.Add(new Course(name, code));
                Console.WriteLine(" Course created!");
            }
            else if (choice == "2")
            {
                if (courses.Count == 0)
                {
                    Console.WriteLine(" No course available.");
                    continue;
                }

                for (int i = 0; i < courses.Count; i++)
                {
                    Console.WriteLine($"{i}. Course");
                }

                Console.Write("Select course index: ");
                int index = int.Parse(Console.ReadLine());

                Console.Write("Student Name: ");
                string name = Console.ReadLine();

                Console.Write("Student ID: ");
                string id = Console.ReadLine();

                Console.Write("Score: ");
                double score = double.Parse(Console.ReadLine());

                courses[index].AddStudent(new Student(name, id, score));
                Console.WriteLine(" Student added!");
            }
            else if (choice == "3")
            {
                foreach (var c in courses)
                {
                    c.ShowAllStudents();
                    c.ShowStatistics();
                }
            }
            else if (choice == "4")
            {
                Console.WriteLine(" Exit program");
                break;
            }
            else
            {
                Console.WriteLine(" Invalid choice");
            }
        }
    }
}