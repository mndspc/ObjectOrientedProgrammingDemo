using System;


namespace OOPDemo
{
    class Student
    {
        public int StdRollNo { get; set; }

        public string StdName { get; set; }

        //public Student()
        //{
        //    Console.WriteLine("Default constructor of Student");
        //}

        public Student(int stdRollNo, string stdName)
        {
            this.StdRollNo = stdRollNo;
            this.StdName = stdName;
        }

        public Student(Student student)
        {
            this.StdRollNo = student.StdRollNo;
            this.StdName = student.StdName;
        }

       
    }
}
