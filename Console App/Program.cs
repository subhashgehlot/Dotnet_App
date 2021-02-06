using System;
using ConsoleApp.Models;
using ConsoleApp.DataLayer;
using ConsoleApp.Logic;

namespace ConsoleApp {
    public class Program {
<<<<<<< HEAD
        void StudentFunction() {
=======
        public static void Main(String[] args) {

            Student StudentData = new Student();
            StudentDataLayer StudentDetails = new StudentDataLayer();
            char Agree;
>>>>>>> d4db70cab8b6d299883cf6024f413d01bc854cf3

            MyDatabaseConnection studentData = new MyDatabaseConnection();
            StudentLogic studentLogic = new StudentLogic();

                Console.WriteLine("\t1. Add Students details. ");
                Console.WriteLine("\t2. Get student detail by ID.");
                Console.WriteLine("\t3. Exit.");
                Console.Write("Enter Choice: ");
                int Choice = Convert.ToInt32(Console.ReadLine());        

                switch(Choice) {
                    case 1:
                        // call to GiveStudentDetail to enter student's details
<<<<<<< HEAD
                        Student student;
                        student=studentLogic.GetStudentDetailsFromUser();
                        // call to AddStudent method to store entered details in Database 
                        studentData.AddStudent(student);
=======
                        StudentLogic.GiveStudentDetails();
                        // call to AddStudent method to store entered details in Database 
                        StudentDetails.AddStudent();
>>>>>>> d4db70cab8b6d299883cf6024f413d01bc854cf3
                        break;

                    case 2:
                        // call to GetStudent method to fetch data from Database
<<<<<<< HEAD
                        studentData.GetStudent();
                        break;

                    case 3:
                        System.Environment.Exit(0);
=======
                        StudentDetails.GetStudent(); 
>>>>>>> d4db70cab8b6d299883cf6024f413d01bc854cf3
                        break;

                    default:
                        Console.WriteLine("Please enter Correct choice!!!");
                        break;
                }
        }
        public static void Main(String[] args) {

            do {
                Program student = new Program();
                student.StudentFunction();
            } while(true);
        }
    }
}