using System;

namespace ConsoleApp.Models {
    public class Student {
        private static string ID;
        private static string Name;
        private static int RollNo;
        private static char Grade;
        private static float Marks;
        public void GiveStudentDetails() {
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
        }

        public static string StudentID { get => ID; set => StudentID = ID; }
        public static string StudentName {get => Name; set => StudentName = Name;}
        public static int StudentRollNo {get => RollNo; set => StudentRollNo = RollNo;}
        public static char StudentGrade {get => Grade; set => StudentGrade = Grade;} 
        public static float StudentMarks {get => Marks; set => StudentMarks = Marks;}
    }
}