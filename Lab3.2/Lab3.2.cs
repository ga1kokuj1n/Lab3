using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3._2
{
	class Program
	{
		static void Main(string[] args)
		{
			Random rand = new Random();
			byte[,] arr = new byte[7, 7];
			Console.WriteLine("Получившийся массив:\n");
			for (byte i = 0; i < 7; i++)
				for (byte j = 0; j < 7; j++)
				{
					arr[i, j] = (byte)rand.Next(10);
					Console.Write(arr[i, j] + (j == 6 ? "\n" : " "));
				}
			byte c;
			for (byte i = 0; i < 3; i++)
				for (byte j = 0; j < 6 - i*2; j++)
				{
					c = arr[i, j + i];
					arr[i, j + i] = arr[6 - j - i, i];
					arr[6 - j - i, i] = arr[6 - i, 6 - j - i];
					arr[6 - i, 6 - j - i] = arr[j + i, 6 - i];
					arr[j + i, 6 - i] = c;
				}
			Console.WriteLine("\nПосле поворота на 90 градусов вправо:\n");
			for (int i = 0; i < 7; i++)
				for (int j = 0; j < 7; j++)
					Console.Write(arr[i, j] + (j == 6 ? "\n" : " "));
		}
	}
}
