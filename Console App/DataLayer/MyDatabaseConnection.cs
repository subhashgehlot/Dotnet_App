using System;
using System.Configuration;
using MySqlConnector;
using ConsoleApp.Models;

namespace ConsoleApp.DataLayer {
    public class MyDatabaseConnection {
        // connection string in which the user, database, server and password is stored.
        string ConnectionString = ConfigurationManager.ConnectionStrings["Connection"].ToString();

        public void AddStudent(Student student) {

            MySqlConnection Connection = new MySqlConnection(ConnectionString);

            Console.WriteLine("Connecting to MySQL...");

            try {
                Connection.Open();

                // Insert values into studentdetails table
                string InsertString = "INSERT INTO studentdetails(ID, Name, Roll_No, Grade, Marks) VALUES(@ID, @Name, @RollNo, @Grade, @Marks)";

                MySqlCommand Command = new MySqlCommand(InsertString, Connection);

                Command.Parameters.AddWithValue("@ID", student.ID);
                Command.Parameters.AddWithValue("@Name", student.Name);
                Command.Parameters.AddWithValue("@RollNo", student.RollNo);
                Command.Parameters.AddWithValue("@Grade", student.Grade);
                Command.Parameters.AddWithValue("@Marks", student.Marks);

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

            bool Temp = false;
            Console.WriteLine("Fetching The Data from Database...");
            
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
