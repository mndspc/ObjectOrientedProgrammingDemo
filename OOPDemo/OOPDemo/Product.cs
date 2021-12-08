using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPDemo
{
   internal class Product
    {
        private int proCode;
        private string proName;

        public int ProCode
        {
            get
            {
                proCode++;
                return proCode;  
            }
            set
            {
                if (value >0)
                {
                    proCode = value;
                }
                else
                {
                    Console.WriteLine("Invalid Product Code");
                }
            }

        }

        public string ProName
        {
            get
            {
                return proName;
            }
            set
            {
                proName = value;
            }
        }

        public string ProCategory
        {
            get
            {
                return "MFCG";
            }
        }

        //  declare auto implemented prop.
        public int Code { get; set; }

        public string Name { get; set; }

        public string Category { get; }
    }

    class Order
    {
        public int CustomerId { get; set; }

        public string OrderStatus { get; set; }

    }
    class Delivery
    {
        public int OrderNo { get; set; }

        public string PaymentType { get; set; }

        public Order OrderInfo { get; set; }
    }
}
