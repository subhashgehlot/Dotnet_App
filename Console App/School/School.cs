using System;

namespace Program {
    public class School {

        String name;
        int staff;

        public School() {
            
            Console.WriteLine("Established in 1990's");
        }
        public School(String name, int staff) {

            this.name = name;
            this.staff = staff;
            Console.WriteLine("School Name: " + name);
            Console.WriteLine("Staff: " + staff + " Teachers.");
        }

        public void studentDetails() {

            Console.WriteLine("Please Enter Details!!!");
        }
    }
}
