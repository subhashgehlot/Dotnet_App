using System;
using ConsoleApp.Models;

namespace ConsoleApp.Logic {
    public class StudentLogic {
<<<<<<< HEAD
        public Student GetStudentDetailsFromUser() {
           
            Student student = new Student();
            
            Console.Write("Enter Student ID: ");
            student.ID = Console.ReadLine();

            Console.Write("Enter Student Name: ");
            student.Name = Console.ReadLine();

            Console.Write("Enter Student Roll No.: ");
            student.RollNo = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Student Grade: ");
            student.Grade = Convert.ToChar(Console.ReadLine());

            Console.Write("Enter Student Marks: ");
            student.Marks = Convert.ToSingle(Console.ReadLine());

            return student;
=======
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
>>>>>>> d4db70cab8b6d299883cf6024f413d01bc854cf3
        }
    }
}