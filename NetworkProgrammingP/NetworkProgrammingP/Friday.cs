using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

using System.Net;

namespace NetworkProgrammingP
{
	internal class Friday
	{
		private IPAddress ip;
		private IPAddress mask;

		public Friday(string ip, string bufMask) 
		{//Парсинг
			this.ip   = IPAddress.Parse(ip);
			this.mask = IPAddress.Parse(bufMask);
		}

		public IPAddress GetNetAddress()
		{
			byte[] ipBytes   = ip.GetAddressBytes();// Перевод в байты
			byte[] maskBytes = mask.GetAddressBytes();
			byte[] netBytes  = new byte[ipBytes.Length];

			for (int i = 0; i < netBytes.Length; i++)
			{
				netBytes[i] = (byte)(ipBytes[i] & maskBytes[i]); // Побитовое умножение с логическим И
			}

			return new IPAddress(netBytes);
		}

		public IPAddress GetBCAddress()
		{
			byte[] ipBytes   = ip.GetAddressBytes();// Перевод в байты
			byte[] maskBytes = mask.GetAddressBytes();

			byte[] broadcastBytes = new byte[ipBytes.Length];

			for (int i = 0; i < broadcastBytes.Length; i++)
			{ // ~ инверт
				broadcastBytes[i] = (byte)(ipBytes[i] | ~maskBytes[i]);//
			}

			return new IPAddress(broadcastBytes);
		}

		public uint GetMaxHosts()
		{
			byte[] maskBytes  = mask.GetAddressBytes();
			uint invertedMask = ~BitConverter.ToUInt32(maskBytes.Reverse().ToArray(), 0); //Конвертирует 4 Bytes из массива в 32-Bit  ~uint
			return invertedMask - 1;
		}
		public void Print()
		{
			Console.WriteLine($"Адрес сети: {GetNetAddress()}");
			Console.WriteLine($"Широковещательный адрес: {GetBCAddress()}");
			Console.WriteLine($"Максимальное количество хостов: {GetMaxHosts()}");
		}
	}
}
