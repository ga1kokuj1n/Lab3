using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3._4
{
	class Program
	{
		static void Main(string[] args)
		{
			double[,] Sum(double[,] a, double[,] b, double[,] avg)
			{
				double[,] ans = new double[3,3];
				for (int i = 0; i < 3; i++)
					for (int j = 0; j < 3; j++)
					{
						ans[i, j] = a[i, j] + b[i, j];
						avg[i, j] = ans[i, j] / 2;
					}
				return ans;
			}

			double[,] Diff(double[,] a, double[,] b, double[,] avg)
			{
				double[,] ans = new double[3, 3];
				for (int i = 0; i < 3; i++)
					for (int j = 0; j < 3; j++)
					{
						ans[i, j] = a[i, j] - b[i, j];
						avg[i, j] = (a[i, j] + b[i, j]) / 2;
					}
				return ans;
			}

			Random rand = new Random();
			double[,] x = new double[3, 3];
			double[,] y = new double[3, 3];
			double[,] z = new double[3, 3];
			double[,] aver = new double[3, 3];
			for (byte i = 0; i < 3; i++)
				for (byte j = 0; j < 3; j++)
				{
					x[i, j] = (double)rand.Next(1000) / 10;
					y[i, j] = (double)rand.Next(1000) / 10;
				}

			Console.WriteLine("Эта программа складывает или вычитает, а также вычисляет среднее значение элементов двух масивов 3х3\n\n1й Массив:\n");
			for (byte i = 0; i < 3; i++)
				for (byte j = 0; j < 3; j++)
					Console.Write(x[i, j] + (j == 2 ? "\n" : "\t"));

			Console.WriteLine("\n2й Массив:\n");
			for (byte i = 0; i < 3; i++)
				for (byte j = 0; j < 3; j++)
					Console.Write(y[i, j] + (j == 2 ? "\n" : "\t"));

			t1:
			Console.Write("\nКакое действие произвести? (+/-):");
			try
			{
				char oper = char.Parse(Console.ReadLine());

				switch (oper)
				{
					case '+':
						z = Sum(x, y, aver);
						break;
					case '-':
						z = Diff(x, y, aver);
						break;
					default:
						Console.WriteLine("Некорректный ответ. Пожалуйста, введите знак нужного действия");
						goto t1;
				}
			}catch (FormatException)
			{
				Console.WriteLine("Некорректный ответ. Пожалуйста, введите знак нужного действия");
				goto t1;
			}

			Console.WriteLine("\nОтвет:\n");
			for (byte i = 0; i < 3; i++)
				for (byte j = 0; j < 3; j++)
					Console.Write(z[i, j] + (j == 2 ? "\n" : "\t"));

			Console.WriteLine("\n\nСреднее:\n");
			for (byte i = 0; i < 3; i++)
				for (byte j = 0; j < 3; j++)
					Console.Write(aver[i, j] + (j == 2 ? "\n" : "\t"));
		}
	}
}
