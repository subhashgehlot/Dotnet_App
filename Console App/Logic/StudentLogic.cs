using System;
using ConsoleApp.Models;

namespace ConsoleApp.Logic
{
    public class StudentLogic 
    {
        public Student GetStudentDetails() 
        {
            Student student = new Student();
            Console.Write("\nEnter Student Unique ID: ");
            student.ID = Console.ReadLine();
                        
            Console.Write("\nEnter Student Name: ");
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