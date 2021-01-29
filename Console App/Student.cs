using System;

namespace ConsoleApp
{

    public class Student : School {
        public string ID;
        public string Name;
        public int RollNo;
        public char Grade;
        public float Marks;

        // To Enter Student Details
        public override void StudentDetails() {
            Console.Write("\nEnter Student Unique ID: ");
            ID = Console.ReadLine();
                    
            Console.Write("\nEnter Student Name: ");
            Name = Console.ReadLine();
                    
            Console.Write("Enter Student Roll No.: ");
            RollNo = Convert.ToInt32(Console.ReadLine());
                    
            Console.Write("Enter Student Grade: ");
            Grade = Convert.ToChar(Console.ReadLine());
                    
            Console.Write("Enter Student Marks: ");
            Marks = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Check The Database....Data has Updated!!!");
        }        
    }
}