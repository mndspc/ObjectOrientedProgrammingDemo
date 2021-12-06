using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPDemo
{
    //  This program demo. how to call overloaded functions.
    class FunctionOverloadingDemo
    {
        static void Main()
        {
            MyMath myMath = new MyMath();
            Console.WriteLine(myMath.Add(10, 30));
            Console.WriteLine(myMath.Add("Function ", "Overloading"));
            Console.ReadLine();
        }
    }
}
