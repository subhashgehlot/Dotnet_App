using System;

namespace MySql.Data.MySqlClient {
    public class Program {

        public static void Main(String[] args) {

            //call to School constructor
            School schoolInfo = new School("Sinhagad School", 55);
                    
            School studentDetail = new Student();
            
            char ch;
            do{

                Console.WriteLine("\n\t**********DashBoard**********");
                Console.WriteLine("\t1. Enter Details of Students to store in database.");
                Console.WriteLine("\t2. To retrieve any student detail by entering ID.");
                Console.Write("\nEnter choice to perform task: ");
                int num = Convert.ToInt32(Console.ReadLine());        

                
                switch(num) {

                    case 1:
                        // call to num of student's data to enter method.
                        studentDetail.numOfStudent();
                        // call to studentDetail to enter student's details
                        studentDetail.studentDetails();
                        // call to mySQLConn() method to store entered details in Database 
                        studentDetail.mySQLConn();
                        break;

                    case 2:
                        // call to dataFetch() method to fetch data from Database
                        studentDetail.dataFetch(); 
                        break;

                    default:
                        Console.WriteLine("Please enter Correct choice!!!");
                        break;
                }

                Console.Write("Do you want to continue(N/Y): ");
                ch = Convert.ToChar(Console.ReadLine());
            } while(ch == 'y' || ch == 'Y');
        }
    }
}