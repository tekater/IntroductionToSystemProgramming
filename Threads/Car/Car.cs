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
		readonly		int MAX_SPEED;

		bool driver_inside;
		int speed;
		int acceleration;

		Engine engine;
		Tank tank;

		struct Threads
		{
			public Thread PanelThread			{ get; set; }
			public Thread EngineIdleThread		{ get; set; }
			public Thread FreeWheelingThread	{ get; set; }
		}
		Threads threads;

		public Car(double consumption, int volume, int max_speed = 250, int acceleration = 1)
		{
			engine	= new Engine(consumption);
			tank	= new Tank(volume);
			threads = new Threads();

			driver_inside = false;

			if (max_speed < MAX_SPEED_LOW_LIMIT) { max_speed = MAX_SPEED_LOW_LIMIT; }
			if (max_speed > MAX_SPEED_HIGH_LIMIT) { max_speed = MAX_SPEED_HIGH_LIMIT; }

			this.MAX_SPEED		= max_speed;
			this.acceleration	= acceleration;
		}
		~Car()
		{
            Console.WriteLine("Car is over");
        }

		void Accelerate()
		{
			if (engine.Started)		{ speed += acceleration;	}
			if (speed > MAX_SPEED)	{ speed = MAX_SPEED;		}

			if (threads.FreeWheelingThread == null)
			{
				threads.FreeWheelingThread = new Thread(FreeWheeling);
				threads.FreeWheelingThread.Start();
			}

			//Thread.Sleep(1000);
		}

		void SlowDown()
		{
			if (speed > 0) { speed -= acceleration; }
			if (speed < 0) { speed = 0;				}

			if(speed == 0 && threads.FreeWheelingThread != null)
			{
				threads.FreeWheelingThread.Join();
			}

			//Thread.Sleep(1000);
		}
		void FreeWheeling()
		{
			while (--speed > 0)
			{
				if (speed < 0)
				{
					speed = 0;
				}
				Thread.Sleep(1000);
			}
		}
		void EngineIdle()
		{
			while (tank.GiveFuel(engine.ConsumptionPerSecond) > 0 && engine.Started)
			{
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

					case ConsoleKey.I:
						if (engine.Started)
						{
							Stop();
						}
						else
						{
							Start();
						}
						break;

					case ConsoleKey.F:
						if (!driver_inside)
						{
							Console.Write("Введите объём топлива: ");
							string s_amount = Console.ReadLine();
							double amount = Convert.ToDouble(s_amount.Replace('.', ','));
							tank.Fill(amount);
						}
						else
						{
							Console.WriteLine("Get out of the car");
						}
						break;

					case ConsoleKey.W:
						Accelerate();
						break;

					case ConsoleKey.S:
						SlowDown();
						break;

					case ConsoleKey.Escape:
						GetOut();
						break;
				}
			} while (key != ConsoleKey.Escape);
			//Thread.Sleep(1000);

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
			Console.Clear();
            Console.WriteLine("You are out of the car");
        }

		public void Start()
		{
			engine.Start();
			threads.EngineIdleThread = new Thread(EngineIdle);
			threads.EngineIdleThread.Start();
		}
		public void Stop()
		{
			engine.Stop();
			threads.EngineIdleThread.Join();
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
				//Tanker();
				Console.Write($"Fuel level: {tank.FuelLevel} liters");
				if(tank.FuelLevel < 5)
				{
                    Console.Write("\t\t");
                    Console.BackgroundColor = ConsoleColor.Red;
					Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("LOW FUEL");
                }
				Console.ResetColor();
				Console.WriteLine();
				Console.WriteLine($"Engine is {(engine.Started ? "started" : "stopped")}");
				Console.WriteLine($"Speed: {speed}km/h");

				Thread.Sleep(200);
			}
		}
		public void Info()
		{
			engine.Info();
			tank.Info();
			Console.WriteLine($"Max speed: {MAX_SPEED}km/h");
		}
	}
}
