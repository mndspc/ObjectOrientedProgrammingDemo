using System;


namespace OOPDemo
{
    //  This is Single Inheritance
    class NOKIA1400:MobilePhone
    {
        public NOKIA1400()
        {
            Console.WriteLine("Default constructor of NOKIA1400");
        }
        public NOKIA1400(int modelNo, string modelName, int year) :base(modelNo,modelName,year)
        {
        Console.WriteLine($"Model No={modelNo}\nModelName={modelName}\nYear={year}");
        }
        public string MP3()
        {
            return "MP3() calling from NOKIA1400";
        }
    }
}
