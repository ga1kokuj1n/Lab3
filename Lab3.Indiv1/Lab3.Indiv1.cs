using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3.Indiv1
{
	class Program
	{
		static void Main(string[] args)
		{
			byte[,] arr = new byte[9, 9];
			Random rand = new Random();
			for (byte i = 0; i < 9; i++)
				for (byte j = 0; j < 9; j++)
					arr[i, j] = (byte)rand.Next(10);
			for (byte i = 0; i < 9; i++)
				arr[i, 8 - i] = arr[i, i];
			for (byte i = 0; i < 9; i++)
				for (byte j = 0; j < 9; j++)
					Console.Write(arr[i, j] + (j == 8 ? "\n" : " "));
		}
	}
}
