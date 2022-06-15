using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba2
{
	class Program
	{
		static void Main(string[] args)
		{

			List<Car> taxipool = new List<Car>
			{
				new Car("Audi", "Coupe", "T9", "black", 50000, 2017, 155, 0, 5.3f, 2, "gasoline", 50, 26),
				
				new Car("Mitsubishi", "Hatchback", "Colt", "red", 10000, 2014, 120, 50, 6.3f, 5, "gasoline", 50, 20),

				new Motorcycle("Kawasaki", "Sport", "NINJA 400", "metallic", 5500, 2022, 105, 45, 4.35f, 1, "gasoline", 14, 43, 168, 2)
				
			};
			Autopark.Print(taxipool);
			Console.WriteLine("Do you want to add a new vehicle? [y/n]");
			string b = Console.ReadLine();
			if(b == "y")
            {
				Autopark.FillTheList(taxipool);
				Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
				Autopark.Print(taxipool);

			}


			Console.WriteLine("Calculating total taxi pool cost ");
			long carsCost = Autopark.CalculateCarsCost(taxipool);
			Console.WriteLine($"Autopark total cost is ${carsCost}");

			Console.WriteLine();
			Console.WriteLine("Searching cars by speed: ");
			Console.Write("From ");
			int speed_min = Convert.ToInt32(Console.ReadLine());
			Console.Write("to ");
			int speed_max = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("km/h");
			List<Car> carsBySpeed = Autopark.SearchBySpeed(taxipool, speed_min, speed_max);


			if (carsBySpeed.Count == 0)
			{
				Console.WriteLine("There are no cars with defined maximum speed");
			}
			else
			{
				foreach (Car car in carsBySpeed)
				{
					Console.WriteLine(car);
				}
			}

			Console.WriteLine();
			Console.WriteLine("Sorting cars by fuel economy");
			List<Car> sortedListByFuelEconomy = Autopark.SortByFuelEconomy(taxipool);
			foreach (var car in sortedListByFuelEconomy)
			{
				Console.WriteLine(car);
			}

			Console.WriteLine();
			
			

		}
	}
}