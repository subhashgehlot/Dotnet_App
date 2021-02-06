namespace ConsoleApp.Models {
    public class Student {
        private static string id;
        private static string name;
        private static int rollNo;
        private static char grade;
        private static float marks;

        public static string StudentID { get => id; set => StudentID = id; }
        public static string StudentName {get => name; set => StudentName = name;}
        public static int StudentRollNo {get => rollNo; set => StudentRollNo = rollNo;}
        public static char StudentGrade {get => grade; set => StudentGrade = grade;} 
        public static float StudentMarks {get => marks; set => StudentMarks = marks;}
    }
}