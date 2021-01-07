using System;
using System.Configuration;
using MySqlConnector;

namespace MySql.Data.MySqlClient
{

    public class Student : School {

        public Student() {

        }
        
        public static int numStudent;
        public override void numOfStudent() {

            Console.Write("\n\tEnter Number of Student's details to store: ");
            numStudent = Convert.ToInt32(Console.ReadLine());
        }

        public string[] studID = new string[numStudent];
        public string[] studName = new string[numStudent];
        public int[] studRollNo = new int[numStudent];
        public char[] studGrade = new char[numStudent];
        public float[] studMark = new float[numStudent];

        // To Enter Student Details
        public override void studentDetails() {

            for(int i = 0; i < numStudent; i++) {

                Console.Write("\nEnter Student "+ (i+1) +" Unique ID: ");
                studID[i] = Console.ReadLine();
                Console.Write("\nEnter Student "+ (i+1) +" Name: ");
                studName[i] = Console.ReadLine();
                Console.Write("Enter Student "+ (i+1) +" Roll No.: ");
                studRollNo[i] = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter Student "+ (i+1) +" Grade: ");
                studGrade[i] = Convert.ToChar(Console.ReadLine());
                Console.Write("Enter Student "+ (i+1) +" Marks: ");
                studMark[i] = Convert.ToSingle(Console.ReadLine());
            }

            if(numStudent > 1) {

                for(int i = 0; i < numStudent; i++) {

                    for(int j = i; j < numStudent; j++) {
                    
                        if((studID[i] == studID[j]) || (studRollNo[i] == studRollNo[j])) {

                            Console.WriteLine("Already Exists...!!!\nPlease Enter differ Roll No. OR Student ID!!!");
                            Environment.Exit(-1);
                        }
                    }
                }
            }

            Console.WriteLine("Check The Database....Data has Updated!!!");
        }

        // To store the Entered Details in the Database
        public override void mySQLConn() {

            // connection string in which the user, database, server and password is stored.
            string connectionStrings = ConfigurationManager.ConnectionStrings["Connection"].ToString();

            MySqlConnection conn = new MySqlConnection(connectionStrings);

            try {

                Console.WriteLine("Connecting to MySQL...");
                conn.Open();
            
                for(int i = 0; i < numStudent; i++) {

                    // Insert values into studentdetails table
                    string sql = "INSERT INTO studentdetails(Student_Id, Student_Name, Student_Roll_no, Student_Grade, Student_Marks) VALUES(@studID, @studName, @studRollNo, @studGrade, @studMark)";

                    MySqlCommand cmd = new MySqlCommand(sql, conn);

                    cmd.Parameters.AddWithValue("@studID", studID[i]);
                    cmd.Parameters.AddWithValue("@studName", studName[i]);
                    cmd.Parameters.AddWithValue("@studRollNo", studRollNo[i]);
                    cmd.Parameters.AddWithValue("@studGrade", studGrade[i]);
                    cmd.Parameters.AddWithValue("@studMark", studMark[i]);

                    cmd.ExecuteNonQuery();
                }
                
                conn.Close();
                Console.WriteLine("Done.");
            }                
            
            catch (Exception ex) {

                Console.WriteLine(ex.ToString());
            }
        }

        public override void dataFetch() {

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