using System;


namespace OOPDemo
{
    //  This program demo. how to use single inheritance.
    class Program
    {
        static void Main(string[] args)
        {
            //NOKIA1400 nokia1400 = new NOKIA1400();
            NOKIA1400 nokia1400 = new NOKIA1400(123,"NOKIA1400",2010);
            //nokia1400.ModelNo = 123;
            //nokia1400.ModelName = "NOKIA1400";
            //nokia1400.Year = 2005;

            //Console.WriteLine(nokia1400.AboutMobilePhone());
            Console.WriteLine(nokia1400.Calling());
            Console.WriteLine(nokia1400.SMS());
            Console.WriteLine(nokia1400.MP3());
            Console.ReadLine();
        }
    }
}
