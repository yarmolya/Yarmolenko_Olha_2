using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba2
{
	class Autopark
	{
		public static void Print(List<Car> cars)
        {
			foreach (var i in cars)
			{
				Console.WriteLine(i);
			}
		}
		public static List<Car> FillTheList(List<Car> cars)
		{
			Console.WriteLine("Enter the number of vehicles you want to add: ");
			int a = Convert.ToInt32(Console.ReadLine());
			for(int i = 0; i<a; i++)
            {
				Console.WriteLine("Add car or motorcycle? [c/m]");
				string b = Console.ReadLine();
				Console.Write("Manufacturer: ");
				string manufacturer = Console.ReadLine();
				Console.Write("Type: ");
				string type = Console.ReadLine();
				Console.Write("Model: ");
				string model = Console.ReadLine();
				Console.Write("Color: ");
				string color = Console.ReadLine();
				Console.Write("Price: ");
				int price = Convert.ToInt32(Console.ReadLine());
				Console.Write("Year: ");
				int year = Convert.ToInt32(Console.ReadLine());
				Console.Write("MaxSpeed: ");
				int speed = Convert.ToInt32(Console.ReadLine());
				Console.Write("Mileage: ");
				int mileage = Convert.ToInt32(Console.ReadLine());
				Console.Write("Acceleration: ");
				float acceleration = Convert.ToInt32(Console.ReadLine());
				Console.Write("Seats number: ");
				int seats = Convert.ToInt32(Console.ReadLine());
				Console.Write("Fuel type: ");
				string fuel = Console.ReadLine();
				Console.Write("Fuel tank capacity: ");
				int capacity = Convert.ToInt32(Console.ReadLine());
				Console.Write("Fuel economy: ");
				int economy = Convert.ToInt32(Console.ReadLine());
				if (b == "c")
				{

					Car car = new Car(manufacturer, type, model, color, price, year, speed, mileage, acceleration, seats, fuel, capacity, economy);
					cars.Add(car);
				}
				else if(b == "m")
                {
					Console.Write("Weight: ");
					int weight = Convert.ToInt32(Console.ReadLine());
					Console.Write("Number of wheels: ");
					int wheels = Convert.ToInt32(Console.ReadLine());


					Motorcycle motorcycle = new Motorcycle(manufacturer, type, model, color, price, year, speed, mileage, acceleration, seats, fuel, capacity, economy, weight,wheels);
					cars.Add(motorcycle);
				}
                else
                {
					Console.Write("Error");
				}
            }
			return cars;
		}

			public static long CalculateCarsCost(List<Car> cars)
		{
			long sum = 0;
			foreach (Car car in cars)
			{
				sum = sum + car.Price;
			}
			return sum;
		}

		public static List<Car> SearchBySpeed(List<Car> cars, int min, int max)
		{
			List<Car> carSelection = new List<Car>();

			foreach (Car car in cars)
			{
				if (car.MaxSpeed >= min && car.MaxSpeed <= max)
				{
					carSelection.Add(car);
				}
			}

			return carSelection;
		}

		public static List<Car> SortByFuelEconomy(List<Car> cars)
		{
			List<Car> Cars = new List<Car>();
			

			if (cars.Count == 0)
			{
				Console.WriteLine("Nothing to sort");
			}

			foreach (Car car in cars)
			{
			
				
				if (car is Car)
				{
					Cars.Add(car as Car);
				}
			}

			Cars.Sort((car1, car2) => car1.FuelEconomy.CompareTo(car2.FuelEconomy));
			

			List<Car> result = new List<Car>();
			result.AddRange(Cars);
			

			return result;
		}

	}
}