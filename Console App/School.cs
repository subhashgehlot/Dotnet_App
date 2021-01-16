using System;

namespace MySql.Data.MySqlClient
{
    public class School
    {

        private string schoolName;
        private int staff;
        public School()
        {

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
