using System;
namespace laba2
{
    class Motorcycle : Car
    {
        public int Weight { set; get; }
        public int NumberOfWheels { set; get; }

        public Motorcycle(string manufacturer, string type, string model, string color, int price, int year, int maxSpeed, int mileage,
            float acceleration, int seatsNumber, string fuelType,
            int fuelTankCapacity, int fuelEconomy, int weight, int numberOfWheels):base(manufacturer, type, model, color, price, year, maxSpeed, mileage,  acceleration, seatsNumber, fuelType, fuelTankCapacity,fuelEconomy)
        {
            Weight = weight;
            NumberOfWheels = numberOfWheels;

        }

        public override string ToString()
        {
            return "Motorcycle: " + base.ToString() + $", Weight: {Weight} kg, Number of wheels: {NumberOfWheels}";
        }
    }
}
