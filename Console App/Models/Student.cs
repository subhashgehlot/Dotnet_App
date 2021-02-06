namespace ConsoleApp.Models {
    public class Student {
        public static string ID;
        public  static string Name;
        public static int RollNo;
        public static char Grade;
        public static float Marks;

        public static string StudentID { get => ID; set => StudentID = ID; }
        public static string StudentName {get => Name; set => StudentName = Name;}
        public static int StudentRollNo {get => RollNo; set => StudentRollNo = RollNo;}
        public static char StudentGrade {get => Grade; set => StudentGrade = Grade;} 
        public static float StudentMarks {get => Marks; set => StudentMarks = Marks;}
    }
}