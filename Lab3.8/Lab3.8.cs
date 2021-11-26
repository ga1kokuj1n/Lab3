using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3._8
{
	class Program
	{
		public static double Det(double[,] matrix)
		{
			int l = matrix.GetUpperBound(0) + 1;
			if (l == 1)
				return matrix[0, 0];

			double answ = 0;
			for (int k = 0; k < l; k++)
			{
				int b;
				double[,] nextMatrix = new double[l - 1, l - 1];
				for (int i = 1; i < l; i++)
				{
					b = 0;
					for (int j = 0; j < l; j++)
					{
						if (j == k)
							continue;
						nextMatrix[i - 1, b] = matrix[i, j];
						b++;
					}
				}
				answ += Math.Pow(-1, k + 2) * Det(nextMatrix)*matrix[0, k];
			}
			return answ;
		}
		static void Main(string[] args)
		{
			Console.WriteLine("Эта программа вычисляет детерминант матрицы NxN разложением по 1 строке\n");
			int n;
			while (true)
			{
				Console.Write("Введите N: ");
				try
				{
					n = int.Parse(Console.ReadLine());
					if (n <= 0)
						throw new FormatException();
				}
				catch (FormatException)
				{
					Console.WriteLine("Пожалуйста, введите натуральное число!");
					continue;
				}
				catch (OverflowException)
				{
					Console.WriteLine("Это слишком больше число, пожалуйста, используйте другое");
					continue;
				}
				break;
			}// N = ...

			double[,] A = new double[n, n];
			Console.WriteLine("Введите элементы матрицы ([i, j])");
			for (int i = 0; i < n; i++)
				for (int j = 0; j < n; j++)
				{
					while (true)
					{
						Console.Write($"[{i + 1}, {j + 1}]: ");
						try
						{
							A[i, j] = double.Parse(Console.ReadLine());
						}
						catch (FormatException)
						{
							Console.WriteLine("Пожалуйста, введите вещественное число!");
							continue;
						}
						catch (OverflowException)
						{
							Console.WriteLine("Это слишком больше число, пожалуйста, используйте другое");
							continue;
						}
						break;
					}// A[i, j] = ...
				}

			Console.Clear();
			Console.WriteLine("Ваша матрица:\n");
			for (int i = 0; i < n; i++)
				for (int j = 0; j < n; j++)
				{
					Console.Write(A[i, j] + (j == n - 1 ? "\n" : "\t"));
				}

			Console.Write($"\nОпределитель: det A = {Det(A)}"\n);
		}
	}
}