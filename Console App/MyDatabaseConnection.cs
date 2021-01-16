using System;
using System.Configuration;
using MySqlConnector;

namespace MySql.Data.MySqlClient {
    public class MyDatabaseConnection : Student {

        public string StudentID {
            get{return studentID;} 
            set{studentID = value;}
        }
        public string StudentName {
            get{return studentName;}
            set{studentName = value;}
        }
        public int StudentRollNo {
            get{return studentRollNo;}
            set{studentRollNo = value;}
        }
        public char StudentGrade {
            get{return studentGrade;}
            set{studentGrade = value;}
        }
        public float StudentMarks {
            get{return studentMarks;}
            set{studentMarks = value;}
         }

        public void mySQLConn() {

        // connection string in which the user, database, server and password is stored.
        string connectionStrings = ConfigurationManager.ConnectionStrings["Connection"].ToString();

        MySqlConnection conn = new MySqlConnection(connectionStrings);

        try {

            Console.WriteLine("Connecting to MySQL...");
            conn.Open();

            // Insert values into studentdetails table
            string sql = "INSERT INTO studentdetails(Student_Id, Student_Name, Student_Roll_no, Student_Grade, Student_Marks) VALUES(@StudentID, @StudentName, @StudentRollNo, @StudentGrade, @StudentMarks)";

            MySqlCommand cmd = new MySqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("@StudentID", studentID);
            cmd.Parameters.AddWithValue("@StudentName", studentName);
            cmd.Parameters.AddWithValue("@StudentRollNo", studentRollNo);
            cmd.Parameters.AddWithValue("@StudentGrade", studentGrade);
            cmd.Parameters.AddWithValue("@StudentMark", studentMarks);

            cmd.ExecuteNonQuery();
                
            conn.Close();
            Console.WriteLine("Done.");
        }                
            
        catch (Exception ex) {

            Console.WriteLine(ex.ToString());
        }
        }

    
    public void dataFetch() {

            String connectionString = ConfigurationManager.ConnectionStrings["Connection"].ToString();

            MySqlConnection conn = new MySqlConnection(connectionString);

            Console.Write("Enter a Student ID to search in Database: ");
            String id = Console.ReadLine();
            bool temp = false;

            try {

                Console.WriteLine("Fetching The Data from Database...");
                conn.Open();

                string sql = "SELECT Student_Name, Student_Roll_no FROM studentdetails WHERE Student_Id = '" + id + "'";
                
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader data = cmd.ExecuteReader();

                while(data.Read()) {

                    Console.WriteLine("Name: " + data[0]);
                    Console.WriteLine("Roll No: " + data[1]);
                    temp = true;
                    
                }

                if(temp == false) {

                    Console.WriteLine("Student with given ID is not present");
                }

                data.Close();
            }
            catch(Exception ex) {

                Console.WriteLine(ex.ToString());
            }

            conn.Close();
            Console.WriteLine("Done.");
        }
    }
}
