using System;

namespace Program  {

    public class Student : School {

        public Student() {

        }

        public void studentDetail() {

            Console.Write("\nEnter the Number of Student Data You want to Enter: ");
            int len = Convert.ToInt32(Console.ReadLine());

            String[] name = new String[len];
            int[] rollNo = new int[len];
            String[] grade = new String[len];
            float[] mark = new float[len];

            for(int i = 0; i < len; i++) {

                Console.Write("\nEnter Student "+ (i+1) +" Name: ");
                name[i] = Console.ReadLine();
                Console.Write("Enter Student "+ (i+1) +" Roll No.: ");
                rollNo[i] = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter Student "+ (i+1) +" Grade: ");
                grade[i] = Console.ReadLine();
                Console.Write("Enter Student "+ (i+1) +" Marks: ");
                mark[i] = Convert.ToSingle(Console.ReadLine());
            }

            Console.WriteLine("Student Details are Given Below: \n");
            Console.WriteLine("\tRoll No.\t\tName\t\tMarks\t\tGrade");
            for(int i = 0; i < len; i++) {

                Console.WriteLine("\t\t" + rollNo[i] + "\t\t" + name[i] + "\t\t" + mark[i] + "\t\t" + grade[i]);
            }
        }
    }
}