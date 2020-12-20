using System;
using System.Data;

using MySql.Data;
using MySql.Data.MySqlClient;

namespace MySql.Data.MySqlClient
{
    public class Program
    {
        public static void Main(String[] args)
        {

            School details = new School("Sinhagad School", 55);
            details.ArrSize();
            School obj = new Student();
            obj.studentDetail();

            Student detail = new Student();

            string connStr = "server=127.0.0.1;user=root;database=console app;port=3306;password=123456";
            MySqlConnector.MySqlConnection conn = new MySqlConnector.MySqlConnection(connStr);
            
           for(int i = 0; i < detail.l; i++) {
            
                try
                {
                    Console.WriteLine("Connecting to MySQL...");
                    conn.Open();

                    const string sql = "INSERT INTO details(Student_Name, Student_Roll_no, Student_Grade, Student_Marks) VALUES(@Name, @rollNo, @grade, @mark)";

                    MySqlConnector.MySqlCommand cmd = new MySqlConnector.MySqlCommand(sql, conn);

                    cmd.Parameters.AddWithValue("@Name", detail.Name[i]);
                    //cmd.Parameters["Name"].Value = detail.Name[i];
                    cmd.Parameters.AddWithValue("?rollNo", detail.rollNo[i]);
                    cmd.Parameters.AddWithValue("?grade", detail.grade[i]);
                    cmd.Parameters.AddWithValue("?mark", detail.mark[i]);

                    cmd.ExecuteNonQuery();
                }                
            
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }

                conn.Close();
                Console.WriteLine("Done.");
            }
        }
    }
}