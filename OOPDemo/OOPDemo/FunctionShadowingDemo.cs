using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPDemo
{
    class FunctionShadowingDemo
    {
        //  This program demo. how to call shadowed Functions.
        static void Main()
        {
            MyMath1 myMath1 = new MyMath1();
            Console.WriteLine(myMath1.Add(30.4, 20.5));
            Console.ReadLine();
        }
    }
}
