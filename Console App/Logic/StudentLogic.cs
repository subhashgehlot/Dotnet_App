using System;
using ConsoleApp.Models;

namespace ConsoleApp.Logic {
    public class StudentLogic {
        public static void GiveStudentDetails() {
            Console.Write("Enter Student ID: ");
            Student.StudentID = Console.ReadLine();

            Console.Write("Enter Student Name: ");
            Student.StudentName = Console.ReadLine();

            Console.Write("Enter Student Roll No.: ");
            Student.StudentRollNo = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Student Grade: ");
            Student.StudentGrade = Convert.ToChar(Console.ReadLine());

            Console.Write("Enter Student Marks: ");
            Student.StudentMarks = Convert.ToSingle(Console.ReadLine());
        }
    }
}