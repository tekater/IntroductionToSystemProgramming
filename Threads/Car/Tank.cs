using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car
{
	internal class Tank
	{
		static readonly int MIN_VOLUME = 20;
		static readonly int MAX_VOLUME = 120;
		readonly int volume;
		double fuel_level;
		public readonly int Volume;

		public double FuelLevel
		{
			get => fuel_level;
		}
		public double GiveFuel(double amount)
		{
			fuel_level -= amount;
			if (fuel_level < 0)
			{
				fuel_level = 0;
			}
			return fuel_level;
		}
		public Tank(int volume) 
		{
			if (volume < MIN_VOLUME) {volume = MIN_VOLUME;}
			if (volume > MAX_VOLUME) {volume = MAX_VOLUME;}

			this.Volume = volume;
			fuel_level = 0;
		}
		~Tank()
		{
            Console.WriteLine("Tank is over");
        }
		public double get_Volume()
		{
			return Volume;
		}
		public void Fill(double amount)
		{
			if (fuel_level + amount <= Volume)
			{
				fuel_level += amount;
			}
			else
			{
				fuel_level = Volume;
			}
		}
		public void Info()
		{
            Console.WriteLine($"Tank volume:\t {Volume}");
            Console.WriteLine($"Fuel level:\t {FuelLevel}");
        }
	}
}
