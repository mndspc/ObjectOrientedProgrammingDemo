using System;


namespace OOPDemo
{
    class PropDemo
    {
        static void Main()
        {
            //Product product = new Product();
            //product.ProCode = 100;
            //product.ProName = "Rice";
            // product.ProCategory = ""; //Error

            Product product = new Product {ProCode=100,ProName="Rice" };
            Console.WriteLine($"Code={product.ProCode}\tName={product.ProName}");

            Order order1 = new Order {CustomerId=13233,OrderStatus="Placed" };
            Delivery delivery1 = new Delivery { OrderNo = 3434, PaymentType = "Cash", OrderInfo = order1 };

            Console.WriteLine($"{delivery1.OrderInfo.CustomerId}\t{delivery1.OrderInfo.OrderStatus}\t{delivery1.OrderNo}\t{delivery1.PaymentType}");
            Console.ReadLine();
        }
    }
}
