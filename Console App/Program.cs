using System;

namespace Program
{
    public class Doctor {

        public String drName = "Mk Shah";
        
        public void Specialist() {

            Console.WriteLine("Neuro - Surgeon");
        }
    }

    public class Hospital {

        string hName = "XYZ Hospital";
        int totDoctors = 43;

        public Hospital() {

            Console.WriteLine("Good Specialist Doctors.");
        }

        Doctor obj = new Doctor();

        public void service() {

            Console.WriteLine("Hospital Name = " + hName);
            Console.WriteLine("Total Doctors = " + totDoctors);
            Console.WriteLine("Good Service...!!!");
            visitorDoctor();
        }

        void visitorDoctor() {

            Console.WriteLine("Doctor Name = " + obj.drName);
            obj.Specialist();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {

            Hospital p1 = new Hospital();
            p1.service();
            Console.Write("\nPress any key to exit...");
            Console.ReadKey(true);
        }
    }
}
