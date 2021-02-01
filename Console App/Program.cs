using System;
using ConsoleApp.Models;
using ConsoleApp.DataLayer;

namespace ConsoleApp {
    public class Program {
        public static void Main(String[] args) {

            Student StudentData = new Student();
            StudentDataLayer StudentDetails = new StudentDataLayer();
            char Agree;

            do {
                Console.WriteLine("\n\t**********DashBoard**********");
                Console.WriteLine("\t1. Enter Details of Students to store in database.");
                Console.WriteLine("\t2. To retrieve any student detail by entering ID.");
                Console.Write("\nEnter choice to perform task: ");
                int Choice = Convert.ToInt32(Console.ReadLine());        

                switch(Choice) {
                    case 1:
                        // call to GiveStudentDetail to enter student's details
                        StudentData.GiveStudentDetails();
                        // call to AddStudent method to store entered details in Database 
                        StudentDetails.AddStudent();
                        break;

                    case 2:
                        // call to GetStudent method to fetch data from Database
                        StudentDetails.GetStudent(); 
                        break;

                    default:
                        Console.WriteLine("Please enter Correct choice!!!");
                        break;
                }
                Console.Write("Do you want to continue(N/Y): ");
                Agree = Convert.ToChar(Console.ReadLine());
            } while(Agree == 'y' || Agree == 'Y');
        }
    }
}