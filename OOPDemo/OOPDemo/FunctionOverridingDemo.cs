using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPDemo
{
    class FunctionOverridingDemo
    {
        static void Main()
        {
            MyMath1 myMath1 = new MyMath1();
            Console.WriteLine(myMath1.Increment(20));
            Employee employee = new Employee(100,"Scott");
            int num = 20;
            //Console.WriteLine( num.ToString());
            Console.WriteLine(employee.ToString());
            Console.ReadLine();
        }
    }
}
