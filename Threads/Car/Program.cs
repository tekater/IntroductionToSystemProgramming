using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Tank tank = new Tank(15);
			tank.Info();
			Console.Read();
		}
	}
}
