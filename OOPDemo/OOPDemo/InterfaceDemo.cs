using System;


namespace OOPDemo
{
    //  This program demo how to use interface
    class InterfaceDemo
    {
        static void Main()
        {
            //  Calling explicite implementation
            //IWifi wifi = new NokiaLumia();
            //Console.WriteLine(wifi.StartWifi());
            //Console.WriteLine(wifi.StopWifi());
            //Console.WriteLine(wifi.TrubleShoot());

            //  Calling implicite implementation
            NokiaLumia nokiaLumia = new NokiaLumia();
          
            Console.WriteLine(nokiaLumia.Calling());
            Console.WriteLine(nokiaLumia.SMS());
            Console.WriteLine(nokiaLumia.StartWifi());
            Console.WriteLine(nokiaLumia.StopWifi());
            Console.WriteLine(nokiaLumia.PushMessage());
            //nokiaLumia.TrubleShoot();

            Console.ReadLine();
        }
    }
}
