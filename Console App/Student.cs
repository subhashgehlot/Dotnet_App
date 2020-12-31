using System;
using System.Configuration;

namespace MySql.Data.MySqlClient
{

    public class Student : School {

        public Student() {

        }

        String[] Name = new String[numStudent];
        int[] rollNo = new int[numStudent];
        String[] grade = new String[numStudent];
        float[] mark = new float[numStudent];

        public override void studentDetails() {

            for(int i = 0; i < numStudent; i++) {

                Console.Write("\nEnter Student "+ (i+1) +" Name: ");
                Name[i] = Console.ReadLine();
                Console.Write("Enter Student "+ (i+1) +" Roll No.: ");
                rollNo[i] = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter Student "+ (i+1) +" Grade: ");
                grade[i] = Console.ReadLine();
                Console.Write("Enter Student "+ (i+1) +" Marks: ");
                mark[i] = Convert.ToSingle(Console.ReadLine());
            }

            Console.WriteLine("Check The Database....Data has Updated!!!");
            Console.WriteLine(ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None).FilePath);
        }
        public void mySQLConn() {

            //string connectionString = "server=127.0.0.1;user=root;database=console app;port=3306;password=123456";
            string ConnectionStrings = ConfigurationManager.ConnectionStrings["Connection"].ToString();

            MySqlConnector.MySqlConnection conn = new MySqlConnector.MySqlConnection(ConnectionStrings);

            try {

                Console.WriteLine("Connecting to MySQL...");
                conn.Open();
            
                for(int i = 0; i < numStudent; i++) {

                    string sql = "INSERT INTO details(Student_Name, Student_Roll_no, Student_Grade, Student_Marks) VALUES(@Name, @rollNo, @grade, @mark)";

                    MySqlConnector.MySqlCommand cmd = new MySqlConnector.MySqlCommand(sql, conn);

                    cmd.Parameters.AddWithValue("@Name", Name[i]);
                    cmd.Parameters.AddWithValue("@rollNo", rollNo[i]);
                    cmd.Parameters.AddWithValue("@grade", grade[i]);
                    cmd.Parameters.AddWithValue("@mark", mark[i]);

                    cmd.ExecuteNonQuery();
                }
                
                conn.Close();
                Console.WriteLine("Done.");
            }                
            
            catch (Exception ex) {

                Console.WriteLine(ex.ToString());
            }
        }
    }
}