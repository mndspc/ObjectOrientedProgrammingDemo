using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPDemo
{
    class NOKIA2700:MobilePhone
    {
        public NOKIA2700()
        {
            Console.WriteLine("Default constrcutor of NOKIA2700");
        }
        public string Camera()
        {
            return "Camera() calling from NOKIA2700";
        }
    }
}
