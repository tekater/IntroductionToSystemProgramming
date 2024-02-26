using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Threading;

namespace Car
{
	internal class Car
	{
		static readonly int MAX_SPEED_LOW_LIMIT = 100;
		static readonly int MAX_SPEED_HIGH_LIMIT = 400;
		readonly int MAX_SPEED;
		bool driver_inside;

		Engine engine;
		Tank tank;

		struct Threads
		{
			public Thread PanelThread { get; set; }
		}
		Threads threads;

		public Car(double consumption, int volume, int max_speed = 250)
		{
			engine = new Engine(consumption);
			tank = new Tank(volume);
			driver_inside = false;
			threads = new Threads();
			if (max_speed < MAX_SPEED_LOW_LIMIT) { max_speed = MAX_SPEED_LOW_LIMIT; }
			if (max_speed > MAX_SPEED_HIGH_LIMIT) { max_speed = MAX_SPEED_HIGH_LIMIT; }
			this.MAX_SPEED = max_speed;
		}
		~Car()
		{
            Console.WriteLine("Car is over");
        }
		public void GetIn()
		{
			driver_inside = true;
			threads.PanelThread = new Thread(Panel);
			threads.PanelThread.Start();

		}
		public void GetOut()
		{
			driver_inside = false;
			threads.PanelThread.Join();
            Console.WriteLine("You are out of the car");
        }

		public void Tanker()
		{
			Console.WriteLine("TANK");
			Console.Write("===-===\n");
			if (tank.FuelLevel >= tank.Volume * 0.25)
			{
				Console.Write(" =---= \n");
			}
			else
			{
				Console.Write(" =   = \n");
			}

			if (tank.FuelLevel >= tank.Volume * 0.5)
			{
				Console.Write(" =---= \n");
			}
			else
			{
				Console.Write(" =   = \n");
			}

			if (tank.FuelLevel >= tank.Volume * 0.75)
			{
				Console.Write(" =---= \n");
			}
			else
			{
				Console.Write(" =   = \n");
			}

			if (tank.FuelLevel != 0)
			{
				Console.Write(" =---= \n");
			}
			else
			{
				Console.Write(" =   = \n");
			}

			Console.Write("===-===\n");
		}
		void Panel()
		{
			while (driver_inside)
			{
				Console.Clear();
				Tanker();
				Console.WriteLine($"Fuel level: {tank.FuelLevel} liters");
				if(tank.FuelLevel < 5)
				{
                    Console.WriteLine("LOW FUEL");
                }
				Console.WriteLine($"Engine is {(engine.Started ? "started" : "stopped")}");
				Thread.Sleep(200);
			}
		}
		public void Info()
		{
			engine.Info();
			tank.Info();
			Console.WriteLine($"Max speed: {MAX_SPEED}km/h");
		}

		void engine_idle()
		{
			while(engine.Started) 
			{
				tank.give_fuel(engine.ConsumptionPerSecond);
				Thread.Sleep(1000);
			}
		}
		public void Control()
		{
            Console.WriteLine("Your car is ready. Press Enter to get in");
            ConsoleKey key;
			do
			{
				key = Console.ReadKey(true).Key;
				switch (key)
				{
						case ConsoleKey.Enter:
						if (driver_inside)
						{
							GetOut();
						}
						else
						{
							GetIn();
						}
						break;

						case ConsoleKey.Escape:
						GetOut();
						break;

					case ConsoleKey.R:
						if (driver_inside)
						{
							if (!engine.Started)
							{
								engine.Start();
								engine_idle();
							}
							else
							{
								engine.Stop();
							}
						}
						else
						{
							Console.WriteLine("Get in of the car");
						}
						break;

					case ConsoleKey.F:
						if (!driver_inside)
						{
							Console.Write("Введите объём топлива: ");
							double amount = Convert.ToInt32(Console.ReadLine());
							tank.Fill(amount);
						}
						else
						{
							Console.WriteLine("Get out of the car");
						}
						break;

						
                }

			} while (key != ConsoleKey.Escape) ;
		}
	}
}
