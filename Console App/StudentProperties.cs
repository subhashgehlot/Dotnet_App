namespace ConsoleApp {
    public class StudentProperties : Student {
        public string StudentID {
            get{return ID;} 
            set{ID = value;}
        }
        public string StudentName {
            get{return Name;}
            set{Name = value;}
        }
        public int StudentRollNo {
            get{return RollNo;}
            set{RollNo = value;}
        }
        public char StudentGrade {
            get{return Grade;}
            set{Grade = value;}
        }
        public float StudentMarks {
            get{return Marks;}
            set{Marks = value;}
        }
    }
    
}