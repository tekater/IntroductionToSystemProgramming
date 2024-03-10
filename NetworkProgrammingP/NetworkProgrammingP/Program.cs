using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace NetworkProgrammingP
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Friday friday = new Friday("192.168.0.1", "255.255.255.0");

			friday.Print();

			Console.ReadLine();
		}
	}
}
