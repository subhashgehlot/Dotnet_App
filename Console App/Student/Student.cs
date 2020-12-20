using System;
using System.Data;

using MySql.Data;
using MySql.Data.MySqlClient;

namespace MySql.Data.MySqlClient
{

    public class Student : School {

        public Student() {

        }
        
        public String[] Name = new String[len];
        public int[] rollNo = new int[len];
        public String[] grade = new String[len];
        public float[] mark = new float[len];
        public override void studentDetail() {

            for(int i = 0; i < len; i++) {

                Console.Write("\nEnter Student "+ (i+1) +" Name: ");
                Name[i] = Console.ReadLine();
                Console.Write("Enter Student "+ (i+1) +" Roll No.: ");
                rollNo[i] = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter Student "+ (i+1) +" Grade: ");
                grade[i] = Console.ReadLine();
                Console.Write("Enter Student "+ (i+1) +" Marks: ");
                mark[i] = Convert.ToSingle(Console.ReadLine());
            }

            Console.WriteLine("Check The Database....Data has Entered!!!");
        }
    }
}