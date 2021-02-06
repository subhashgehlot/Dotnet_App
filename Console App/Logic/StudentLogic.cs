using System;
using ConsoleApp.Models;

namespace ConsoleApp.Logic {
    public class StudentLogic {
        public static void GiveStudentDetails() {
            Console.Write("Enter Student ID: ");
            Student.ID = Console.ReadLine();

            Console.Write("Enter Student Name: ");
            Student.Name = Console.ReadLine();

            Console.Write("Enter Student Roll No.: ");
            Student.RollNo = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Student Grade: ");
            Student.Grade = Convert.ToChar(Console.ReadLine());

            Console.Write("Enter Student Marks: ");
            Student.Marks = Convert.ToSingle(Console.ReadLine());
        }
    }
}