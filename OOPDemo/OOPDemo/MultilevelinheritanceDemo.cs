using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPDemo
{
    class MultilevelinheritanceDemo
    {
        static void Main()
        {
            NOKIA1100 nokia1100 = new NOKIA1100();
            nokia1100.ModelNo = 12345;
            nokia1100.ModelName = "NOKIA100";
            nokia1100.Year = 2008;
            Console.WriteLine(nokia1100.AboutMobilePhone());
            Console.WriteLine(nokia1100.Calling());
            Console.WriteLine(nokia1100.SMS());
            Console.WriteLine(nokia1100.MP3());
            Console.WriteLine(nokia1100.MP4());
            Console.ReadLine();
        }
    }
}
