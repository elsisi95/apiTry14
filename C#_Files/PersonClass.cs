using System;

namespace ReviseCS
{

    class Person
    {
        int age;
        string name;
        public void SayHi()
        {
            Console.WriteLine("Hi");
        }
    }

    class MainClass
    {
        public static void Main(string[] args)
        {
            Person p1 = new Person();
            p1.SayHi();
        }
    }
}
