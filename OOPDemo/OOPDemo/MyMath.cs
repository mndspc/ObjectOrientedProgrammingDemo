using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPDemo
{
    //  This class demo polymorphism.
    class MyMath
    {
        public int Add(int num1, int num2)
        {
            return num1 + num2;
        }

        public string Add(string str1, string str2)
        {
            return str1 + str2;
        }

        public virtual int Increment(int x)
        {
            x++;
            return x;
        }
    }

    class MyMath1 : MyMath
    {
        public override int Increment(int x)
        {
            x = x + 5;
            return x;
        }
        public double Add(double d1, double d2)
        {
            return d1 + d2;
        }
    }

    class Employee
    {
        public int EmpCode { get; set; }
        public string EmpName { get; set; }

        public Employee(int empCode,string empName)
        {
            this.EmpCode = empCode;
            this.EmpName = empName;
        }

        public override string ToString()
        {
            return $"Code={this.EmpCode}\tName={this.EmpName}";
        }

    }
}
