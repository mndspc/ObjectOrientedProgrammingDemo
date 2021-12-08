using System;


namespace OOPDemo
{
    class AbstractDemo
    {
        static void Main()
        {
            //Vehicle vehicle = new Vehicle();//error
            TwoWheeler twoWheeler = new TwoWheeler(1233, "Tata Nexon", "2017");
            Console.WriteLine(twoWheeler.Start());
            Console.WriteLine(twoWheeler.Stop());
            Console.WriteLine(twoWheeler.AboutVehicle());
            Console.WriteLine(twoWheeler.FuelType("Diesel"));
            Console.ReadLine();
        }
    }
}
