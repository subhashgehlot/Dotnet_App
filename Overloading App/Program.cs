using System;

namespace Overloading_App
{
    public class Demo1 {

    }

    public class Demo2 {

    }

    public class Test {

        public void m1(Demo1 d1) {

            Console.WriteLine("Method of class Abc");
        }

        public void m1(Demo2 d2) {

            Console.WriteLine("Method of class Xyz");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Test obj = new Test();

            obj.m1(new Demo1());
            obj.m1(new Demo2());
        }
    }
}
