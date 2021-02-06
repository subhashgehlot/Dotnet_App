namespace ConsoleApp.Models {
    public class Student {
<<<<<<< HEAD
        public string ID {get; set;}
        public string Name {get; set;}
        public int RollNo {get; set;}
        public char Grade{get; set;}
        public float Marks{get; set;}
=======
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
>>>>>>> d4db70cab8b6d299883cf6024f413d01bc854cf3
    }
}