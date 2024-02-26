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
		int volume;
		double fuel_level;
		public int Volume
		{
			get => volume;
			private set
			{
				if (value < MIN_VOLUME)
				{
					value = MIN_VOLUME;
				}

				if (value > MAX_VOLUME)
				{
					value = MAX_VOLUME;
				}
				volume = value;
			}
		}

		public double FuelLevel
		{
			get => fuel_level;
		}
		public Tank(int volume) 
		{
			Volume = volume;
			fuel_level = 0;
		}

		void Fill(double amount)
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
