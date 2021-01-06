using System;

namespace MySql.Data.MySqlClient
{
    public class School
    {

        public string schoolName;
        public int staff;
        public School()
        {

        }

        public virtual void numOfStudent() {

            Console.WriteLine("No. of Student's data to Enter.");
        }
        public School(string schoolName, int staff)
        {
            
            Console.WriteLine("Established in 1990's");
            this.schoolName = schoolName;
            this.staff = staff;
            Console.WriteLine("School Name: " + schoolName);
            Console.WriteLine("Staff: " + staff + " Teachers.");
        }

        public virtual void studentDetails()
        {

            Console.WriteLine("Please Enter Details!!!");
        }

        public virtual void mySQLConn() {

            Console.WriteLine("Connection to Database");
        }

        public virtual void dataFetch() {

            Console.WriteLine("Fetching Data from Database....");
        }
    }
}
