using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Threading;
// Suspend, Resume
namespace Threads
{
	internal class Program
	{
		static bool finish			= false;
		static bool suspend_plus	= false;
		static bool suspend_minus	= false;
		static void Main(string[] args)
		{
			Thread plus_thread = new Thread(Plus);
			Thread minus_thread = new Thread(Minus);

			plus_thread.Start();
			minus_thread.Start();
            //plus_thread.Join();
            //minus_thread.Join();
            Console.WriteLine("Press any key(almost) to stop");
			ConsoleKey key;
			do
			{
				key = Console.ReadKey(true).Key;
				switch (key)
				{
					case ConsoleKey.Escape:
						finish = true;
					break;

					case ConsoleKey.OemPlus:

					break;

				}
			} while (key != ConsoleKey.Escape);
			
			finish = true;
        }

		static void Plus()
		{
			while(!finish)
			{
                Console.Write($"+ {Thread.CurrentThread.GetHashCode()}\t");
				Thread.Sleep(500);
            }
		}
		static void Minus()
		{
			while(!finish)
			{
                Console.Write($"- {Thread.CurrentThread.GetHashCode()}\t");
				Thread.Sleep(500);
			}
		}
	}
}
