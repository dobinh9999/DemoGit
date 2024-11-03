using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace lab3_btvn_bai5
{
	internal class Program
	{
		private static Random random = new Random();
		private static int randomNumber;
		private static readonly object lockObj = new object();
		private static bool isRunning = true;
		static void Main(string[] args)
		{
			Thread thread1 = new Thread(GenerateRandomNumber);
			Thread thread2 = new Thread(SquareRandomNumber);

			thread1.Start();
			thread2.Start();

			// Chờ 10 giây trước khi dừng các luồng
			Thread.Sleep(10000);
			isRunning = false;

			thread1.Join();
			thread2.Join();

			Console.WriteLine("Chương trình kết thúc.");
		}

		static void GenerateRandomNumber()
		{
			while (isRunning)
			{
				int number = random.Next(1, 21); // Sinh số ngẫu nhiên từ 1 đến 20
				lock (lockObj)
				{
					randomNumber = number;
					Console.WriteLine($"Thread 1: Số ngẫu nhiên sinh ra là: {randomNumber}");
				}
				Thread.Sleep(2000); // Chờ 2 giây
			}
		}

		static void SquareRandomNumber()
		{
			while (isRunning)
			{
				lock (lockObj)
				{
					Console.WriteLine($"Thread 2: Bình phương của {randomNumber} là: {randomNumber * randomNumber}");
				}
				Thread.Sleep(2000); // Chờ 2 giây
			}
		}
	}
}
