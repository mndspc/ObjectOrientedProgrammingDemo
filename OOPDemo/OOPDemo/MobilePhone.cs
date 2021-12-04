using System;


namespace OOPDemo
{
    class MobilePhone
    {
        public int ModelNo { get; set; }
        public string ModelName { get; set; }
        public int Year { get; set; }

        public MobilePhone()
        {
            Console.WriteLine("Default constructor of MobilePhone");
        }
        public MobilePhone(int modelNo, string modelName, int year)
        {
            this.ModelNo = modelNo;
            this.ModelName = modelName;
            this.Year = year;
        }
        public string Calling()
        {
            return "Calling() from MobilePhone";
        }

        public string SMS()
        {
            return "SMS() from MobilePhone";
        }

        public string AboutMobilePhone()
        {
            return $"Model No={this.ModelNo}\nModelName={this.ModelName}\nYear={this.Year}";
        }
    }
}
