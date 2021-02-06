using System;
using System.Configuration;
using MySqlConnector;
using ConsoleApp.Models;

namespace ConsoleApp.DataLayer {
<<<<<<< HEAD:Console App/DataLayer/MyDatabaseConnection.cs
    public class MyDatabaseConnection {
        // connection string in which the user, database, server and password is stored.
        string ConnectionString = ConfigurationManager.ConnectionStrings["Connection"].ToString();

        public void AddStudent(Student student) {

            MySqlConnection Connection = new MySqlConnection(ConnectionString);

            Console.WriteLine("Connecting to MySQL...");

=======
    public class StudentDataLayer {
        // connection string in which the user, database, server and password is stored.
        string ConnectionString = ConfigurationManager.ConnectionStrings["Connection"].ToString();

        public void AddStudent() {

            MySqlConnection Connection = new MySqlConnection(ConnectionString);
    
                Console.WriteLine("Connecting to MySQL...");
>>>>>>> d4db70cab8b6d299883cf6024f413d01bc854cf3:Console App/DataLayer/StudentDataLayer.cs
            try {
                Connection.Open();

                // Insert values into studentdetails table
                string InsertString = "INSERT INTO studentdetails(ID, Name, Roll_No, Grade, Marks) VALUES(@ID, @Name, @RollNo, @Grade, @Marks)";

                MySqlCommand Command = new MySqlCommand(InsertString, Connection);

<<<<<<< HEAD:Console App/DataLayer/MyDatabaseConnection.cs
                Command.Parameters.AddWithValue("@ID", student.ID);
                Command.Parameters.AddWithValue("@Name", student.Name);
                Command.Parameters.AddWithValue("@RollNo", student.RollNo);
                Command.Parameters.AddWithValue("@Grade", student.Grade);
                Command.Parameters.AddWithValue("@Marks", student.Marks);
=======
                Command.Parameters.AddWithValue("@StudentID", Student.StudentID);
                Command.Parameters.AddWithValue("@StudentName", Student.StudentName);
                Command.Parameters.AddWithValue("@StudentRollNo", Student.StudentRollNo);
                Command.Parameters.AddWithValue("@StudentGrade", Student.StudentGrade);
                Command.Parameters.AddWithValue("@StudentMarks", Student.StudentMarks);
>>>>>>> d4db70cab8b6d299883cf6024f413d01bc854cf3:Console App/DataLayer/StudentDataLayer.cs

                Command.ExecuteNonQuery();
                
                Connection.Close();
                Console.WriteLine("Done.");
            } catch (MySqlException ex) {

                Console.WriteLine(ex.ToString());
            }
        } 
        public void GetStudent() {
            MySqlConnection Connection = new MySqlConnection(ConnectionString);

            Console.Write("Enter a Student ID to search in Database: ");
            String ID = Console.ReadLine();

<<<<<<< HEAD:Console App/DataLayer/MyDatabaseConnection.cs
            bool Temp = false;
            Console.WriteLine("Fetching The Data from Database...");
            
=======
                Console.WriteLine("Fetching The Data from Database...");
>>>>>>> d4db70cab8b6d299883cf6024f413d01bc854cf3:Console App/DataLayer/StudentDataLayer.cs
            try {
                Connection.Open();

                string FetchString = "SELECT Name, Roll_No FROM studentdetails WHERE ID = '" + ID + "'";
                
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
            } catch(MySqlException ex) {
                Console.WriteLine(ex.ToString());
            }

            Connection.Close();
            Console.WriteLine("Done.");
        }
    }
}
