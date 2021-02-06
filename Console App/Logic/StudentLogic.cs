using System;
using ConsoleApp.Models;

namespace ConsoleApp.Logic {
    public class StudentLogic {
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
        }
    }
}