using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPDemo
{
    class HybridInheritanceDemo
    {
        static void Main()
        {
            NOKIA2700 nokia2700 = new NOKIA2700();
            nokia2700.ModelNo = 43535;
            nokia2700.ModelName = "NOKIA2700";
            nokia2700.Year = 2010;

            Console.WriteLine(nokia2700.AboutMobilePhone());
            Console.WriteLine(nokia2700.Calling());
            Console.WriteLine(nokia2700.SMS());
            Console.WriteLine(nokia2700.Camera());
            Console.ReadLine();
        }
    }
}
