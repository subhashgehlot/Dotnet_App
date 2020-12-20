using System;
using System.Data;

using MySql.Data;
using MySql.Data.MySqlClient;

namespace MySql.Data.MySqlClient
{
    public class School
    {

        public string name;
        public int staff;
        public static int len;

        public void ArrSize() {
        
            Console.Write("\nEnter the Number of Student Data You want to Enter: ");
            len = Convert.ToInt32(Console.ReadLine());
        }

        public int l = len;

        public School()
        {

        }
        public School(string name, int staff)
        {
            
            Console.WriteLine("Established in 1990's");
            this.name = name;
            this.staff = staff;
            Console.WriteLine("School Name: " + name);
            Console.WriteLine("Staff: " + staff + " Teachers.");
        }

        public virtual void studentDetail()
        {

            Console.WriteLine("Please Enter Details!!!");
        }
    }
}
