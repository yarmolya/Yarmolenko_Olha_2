using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba2
{
	class Car
	{
		public String Manufacturer { set; get; }
		public String Type { set; get; }
		public String Model { set; get; }
		public String Color { set; get; }

		public int Price { set; get; }
		public int Year { set; get; }
		public int Mileage { set; get; }

		public int MaxSpeed { set; get; }
		public float Acceleration { set; get; }

		public int SeatsNumber { set; get; }

		public String FuelType { set; get; }
		public int FuelTankCapacity { set; get; }
		public int FuelEconomy { set; get; }



		public Car(String manufacturer, String type, string model, string color, int price, int year, int maxSpeed, int mileage,
			float acceleration, int seatsNumber, string fuelType,
			int fuelTankCapacity, int fuelEconomy)
		{
			Manufacturer = manufacturer;
			Type = type;
			Model = model;
			Color = color;
			Price = price;
			Year = year;
			Mileage = mileage;
			MaxSpeed = maxSpeed;
			Acceleration = acceleration;
			SeatsNumber = seatsNumber;
			FuelType = fuelType;
			FuelTankCapacity = fuelTankCapacity;
			FuelEconomy = fuelEconomy;


		}

		public override string ToString()
		{
			String carInfo = $"Manufacturer: {Manufacturer}, Type: {Type}, Model: {Model}, Color: {Color}, Price: {Price}, Year: {Year}, MaxSpeed: {MaxSpeed}, Mileage: {Mileage}," +
				 $" Acceleration: {Acceleration}, Seats Number: {SeatsNumber}, Fuel type: {FuelType}, Fuel tank capacity: {FuelTankCapacity}, Fuel economy: {FuelEconomy}";

			return carInfo;
		}

	}
}
