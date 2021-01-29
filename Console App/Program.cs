using System;

namespace ConsoleApp {
    public class Program {
        public static void Main(String[] args) {
            MyDatabaseConnection MyConnection = new MyDatabaseConnection(); 
            char Agree;

            do {
                Console.WriteLine("\n\t**********DashBoard**********");
                Console.WriteLine("\t1. Enter Details of Students to store in database.");
                Console.WriteLine("\t2. To retrieve any student detail by entering ID.");
                Console.Write("\nEnter choice to perform task: ");
                int Choice = Convert.ToInt32(Console.ReadLine());        

                switch(Choice) {
                    case 1:
                        // call to studentDetail to enter student's details
                        MyConnection.StudentDetails();
                        // call to mySQLConn() method to store entered details in Database 
                        MyConnection.MySQLConn();
                        break;

                    case 2:
                        // call to dataFetch() method to fetch data from Database
                        MyConnection.DataFetch(); 
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