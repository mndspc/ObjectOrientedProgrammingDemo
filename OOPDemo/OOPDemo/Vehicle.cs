using System;


namespace OOPDemo
{
    public abstract class Vehicle
    {
        public int ModelNo { get; set; }
        public string ModelName { get; set; }
        public string Year { get; set; }

        //  abstract property
        public abstract string StartType { get; set; }
        public Vehicle(int modelNo, string modelName, string year)
        {
            this.ModelNo = modelNo;
            this.ModelName = modelName;
            this.Year = year;
        }
        public string AboutVehicle()
        {
            return $"Model No={this.ModelNo} Name={this.ModelName} Year={this.Year}";
        }
        public string Start()
        {
            return "Start() calling from Vehicle";
        }
        public string Stop()
        {
            return "Stop() calling from Vehicle";
        }
        // abstract function
        public abstract string FuelType(string fuleType);
    }

    class TwoWheeler : Vehicle
    {
        public TwoWheeler(int modelNo, string modelName, string year) : base(modelNo, modelName, year)
        {

        }
        private string startType;
        public override string StartType
        {
            get
            {
                return startType;
            }
            set
            {
                startType = value;
            }
        }

        public override string FuelType(string fuelType)
        {
            return $"This two wheeler is {fuelType}";
        }
    }
    class ThreeWheeler : TwoWheeler
    {
        public ThreeWheeler(int modelNo, string modelName, string year) : base(modelNo, modelName, year)
        {

        }

        public sealed override string FuelType(string fuelType)
        {
            return $"This two wheeler is {fuelType}";
        }
    }
   sealed class FourWheeler : ThreeWheeler
    {
        public FourWheeler(int modelNo, string modelName, string year) : base(modelNo, modelName, year)
        {

        }

        //Error due to sealed
        //public sealed override string FuelType(string fuelType)
        //{
        //    return $"This two wheeler is {fuelType}";
        //}
    }

    //class SixWheeler : FourWheeler
    //{

    //}
}
