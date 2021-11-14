using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3._5
{
	class Program
	{
		static void Main(string[] args)
		{
			float[,] a = new float[5, 5];
			float[,] b = new float[5, 5];
			float[,] ans = new float[5, 5];

			Random rand = new Random();
			for (byte i = 0; i < 5; i++)
				for (byte j = 0; j < 5; j++)
				{
					a[i, j] = (float)rand.Next(1000) / 10;
					b[i, j] = (float)rand.Next(1000) / 10;
				}

			Console.WriteLine("Эта программа случайно генерирует 2 матрицы и вычисляет их произведение\n\n1я Матрица:\n");
			for (byte i = 0; i < 5; i++)
				for (byte j = 0; j < 5; j++)
					Console.Write(a[i, j] + (j == 4 ? "\n" : "\t"));
			Console.WriteLine("\n2я Матрица:\n");
			for (byte i = 0; i < 5; i++)
				for (byte j = 0; j < 5; j++)
					Console.Write(b[i, j] + (j == 4 ? "\n" : "\t"));
			Console.WriteLine("\nОтвет:\n");
			for (byte i = 0; i < 5; i++)
				for (byte j = 0; j < 5; j++)
				{
					ans[i, j] = a[i, j] * b[i, j];
					Console.Write(ans[i, j] + (j == 4 ? "\n" : "\t"));
				}
		}
	}
}
