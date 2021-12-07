using System;

namespace OOPDemo
{
    //  This program demo how to call constructor
    class ConstructorDemo
    {
        static void Main()
        {
            Student student = new Student(100,"Scott");
            Student student1 = new Student(student);
            Console.WriteLine($"RollNo={student1.StdRollNo}\tName={student1.StdName}");
            Console.ReadLine();
        }
    }
}
