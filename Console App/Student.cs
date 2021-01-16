using System;

namespace MySql.Data.MySqlClient
{

    public class Student : School {

        public Student() {

        }
        
        public string studentID;
        public string studentName;
        public int studentRollNo;
        public char studentGrade;
        public float studentMarks;

        // To Enter Student Details
        public override void studentDetails() {

            Console.Write("\nEnter Student Unique ID: ");
            studentID = Console.ReadLine();
                    
            Console.Write("\nEnter Student Name: ");
            studentName = Console.ReadLine();
                    
            Console.Write("Enter Student Roll No.: ");
            studentRollNo = Convert.ToInt32(Console.ReadLine());
                    
            Console.Write("Enter Student Grade: ");
            studentGrade = Convert.ToChar(Console.ReadLine());
                    
            Console.Write("Enter Student Marks: ");
            studentMarks = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Check The Database....Data has Updated!!!");
        }        
    }
}