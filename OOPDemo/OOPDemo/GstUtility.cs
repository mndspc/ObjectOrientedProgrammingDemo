using System;


namespace OOPDemo
{
   static class GstUtility
    {
        static GstUtility()
        {
            Console.WriteLine("Static Constructor of GstUtility");
        }
        public static double TotalProAmount { get; set; }
        public static double GstAmount { get; set; }

        public static void CalculateGst(double proAmt, double gstPer)
        {
            double gstAmount = proAmt / 100 * gstPer;
            double total = proAmt + gstAmount;
            TotalProAmount = total;
            GstAmount = gstAmount;
        }
    }
}
