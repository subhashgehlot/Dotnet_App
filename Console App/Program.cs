using System;

namespace MySql.Data.MySqlClient {
    public class Program {

        public static void Main(String[] args) {

            //call to School constructor
            School schoolInfo = new School("Sinhagad School", 55);
            schoolInfo.numOfStudent();

            //call to studentDetail and MySQLConn to store values and store in database
            Student studentDetail = new Student();
            studentDetail.studentDetails();
            studentDetail.mySQLConn();
        }
    }
}