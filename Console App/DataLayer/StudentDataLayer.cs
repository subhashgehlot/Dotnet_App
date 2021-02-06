using System;
using System.Configuration;
using MySqlConnector;
using ConsoleApp.Models;

namespace ConsoleApp.DataLayer {
    public class StudentDataLayer {
        // connection string in which the user, database, server and password is stored.
        string ConnectionString = ConfigurationManager.ConnectionStrings["Connection"].ToString();

        public void AddStudent() {

            MySqlConnection Connection = new MySqlConnection(ConnectionString);
    
                Console.WriteLine("Connecting to MySQL...");
            try {
                Connection.Open();

                // Insert values into studentdetails table
                string InsertString = "INSERT INTO studentdetails(Student_Id, Student_Name, Student_Roll_no, Student_Grade, Student_Marks) VALUES(@StudentID, @StudentName, @StudentRollNo, @StudentGrade, @StudentMarks)";

                MySqlCommand Command = new MySqlCommand(InsertString, Connection);

                Command.Parameters.AddWithValue("@StudentID", Student.StudentID);
                Command.Parameters.AddWithValue("@StudentName", Student.StudentName);
                Command.Parameters.AddWithValue("@StudentRollNo", Student.StudentRollNo);
                Command.Parameters.AddWithValue("@StudentGrade", Student.StudentGrade);
                Command.Parameters.AddWithValue("@StudentMarks", Student.StudentMarks);

                Command.ExecuteNonQuery();
                
                Connection.Close();
                Console.WriteLine("Done.");
            } catch (Exception ex) {

                Console.WriteLine(ex.ToString());
            }
        } 
        public void GetStudent() {
            MySqlConnection Connection = new MySqlConnection(ConnectionString);

            Console.Write("Enter a Student ID to search in Database: ");
            String ID = Console.ReadLine();
        
            bool Temp = false;

                Console.WriteLine("Fetching The Data from Database...");
            try {
                Connection.Open();

                string FetchString = "SELECT Student_Name, Student_Roll_no FROM studentdetails WHERE Student_Id = '" + ID + "'";
                
                MySqlCommand Command = new MySqlCommand(FetchString, Connection);
                MySqlDataReader Data = Command.ExecuteReader();

                while(Data.Read()) {
                    Console.WriteLine("Name: " + Data[0]);
                    Console.WriteLine("Roll No: " + Data[1]);
                    Temp = true;            
                }

                if(Temp == false) {
                    Console.WriteLine("Student with given ID is not present");
                }
                Data.Close();
            } catch(Exception ex) {
                Console.WriteLine(ex.ToString());
            }

            Connection.Close();
            Console.WriteLine("Done.");
        }
    }
}
