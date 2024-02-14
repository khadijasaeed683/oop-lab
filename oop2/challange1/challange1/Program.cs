using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace challange1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();
            string choice;
            do
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("******   STUDENT MANAGEMENT SYSTEM   ******");
                Console.WriteLine("1. Add Student.\r\n2. Show Students.\r\n3. Calculate Aggregate\r\n4. Top Students\r\n5. Exit.");
                Console.WriteLine("Enter your choice: ");
                choice = Console.ReadLine();
                if (choice == "1")
                {
                    AddStudent(students);
                }
                else if (choice == "2")
                {
                    ShowStudents(students);
                }
                else if (choice == "3")
                {
                    CalAggregate(students);
                }
                else if (choice == "4")
                {
                    ShowTopStudents(students);
                }
                else
                    Console.WriteLine("INVALID OPTION ");
                Console.ReadLine();
            } while (choice != "5");
            Console.ReadLine();
        }
        public static void AddStudent(List<Student> students)
        {
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("Enter Name of student: ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter Matric Marks of student: ");
            int matricMarks = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter FSC marks: ");
            int fscMarks = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter ecat marks: ");
            int ecatMarks = int.Parse(Console.ReadLine());
            Student NewStudent = new Student(name, matricMarks, fscMarks, ecatMarks);
            students.Add(NewStudent);
            Console.WriteLine("^Student added successfuly^");
        }
        public static void CalAggregate(List<Student> students)
        {
            if (students.Count == 0)
            {
                Console.WriteLine("No students added yet.");
                return;
            }

            double totalAggregate = 0;
            foreach (var student in students)
            {
                totalAggregate += student.CalculateAggregate();
            }
            double averageAggregate = totalAggregate / students.Count;
            Console.WriteLine($"Average aggregate of all students: {averageAggregate}");
        }
        public static void ShowStudents(List<Student> students)
        {
            Console.WriteLine("Students:");
            foreach (var student in students)
            {
                Console.WriteLine(student.Name);
            }
        }
        public static void ShowTopStudents(List<Student> students)
        {
            if (students.Count == 0)
            {
                Console.WriteLine("No students added yet.");
                return;
            }

            var sortedStudents = students.OrderByDescending(s => s.CalculateAggregate()).Take(3);
            Console.WriteLine("Top 3 Students:");
            foreach (var student in sortedStudents)
            {
                Console.WriteLine(student.Name + "  " + student.CalculateAggregate());
            }
        }
    }
}
