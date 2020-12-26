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

        public static int numStudent;
        public void numOfStudent() {

            Console.Write("\n\tEnter Number of Students: ");
            numStudent = Convert.ToInt32(Console.ReadLine());
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
    }
}
