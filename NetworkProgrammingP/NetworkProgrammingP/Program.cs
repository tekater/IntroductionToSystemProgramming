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
			Console.Write("Введите IP-Адрес: ");
			string ip = Console.ReadLine();

			Console.Write("Введите Mask Адреса: ");
			string mask = Console.ReadLine();

			//Friday friday = new Friday("192.168.0.1", "255.255.255.0");

			Friday friday = new Friday(ip,mask);
			friday.Print();
			Console.ReadLine();
		}
	}
}
