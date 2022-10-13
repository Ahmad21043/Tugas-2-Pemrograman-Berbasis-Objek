using System;

namespace MyApplication
{

    class Student
    {
        public string name = "Aryandi";

        public void print()
        {
            Console.WriteLine("Hello, i'm from information system class");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {

            // creating object of Student class
            Student student1 = new Student();

            // accessing name field and printing it
            Console.WriteLine("Name: " + student1.name);

            // accessing print method from Student
            student1.print();
            Console.ReadLine();
        }
    }
}
/*
 Output:
Name : Aryandi
hello, i'm fom information system class
*/