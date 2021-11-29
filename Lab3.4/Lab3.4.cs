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
			float[,] Sum(float[,] a, float[,] b, float[,] avg)
			{
				float[,] ans = new float[3,3];
				for (int i = 0; i < 3; i++)
					for (int j = 0; j < 3; j++)
					{
						ans[i, j] = a[i, j] + b[i, j];
						avg[i, j] = ans[i, j] / 2;
					}
				return ans;
			}

			float[,] Diff(float[,] a, float[,] b, float[,] avg)
			{
				float[,] ans = new float[3, 3];
				for (int i = 0; i < 3; i++)
					for (int j = 0; j < 3; j++)
					{
						ans[i, j] = a[i, j] - b[i, j];
						avg[i, j] = (a[i, j] + b[i, j]) / 2;
					}
				return ans;
			}

			float[,] arrA = new float[3, 3];
			float[,] arrB = new float[3, 3];

			Console.WriteLine("Эта программа складывает или вычитает, а также вычисляет среднее значение элементов двух масивов 3х3\n\n1й Массив:\n");
			for (byte i = 0; i < 3; i++)
				for (byte j = 0; j < 3; j++)
					while (true)
					{
						Console.Write($"[{i + 1}, {j + 1}]: ");
						try
						{
							arrA[i, j] = float.Parse(Console.ReadLine());
						}
						catch (FormatException)
						{
							Console.WriteLine("Пожалуйста, введите вещественное число");
							continue;
						}
						catch (OverflowException)
						{
							Console.WriteLine("Это число слишком большое, пожалуйста, используйте другое");
							continue;
						}
						break;
					}// arrA[i, j] = ...

			Console.WriteLine("\n2й Массив:\n");
			for (byte i = 0; i < 3; i++)
				for (byte j = 0; j < 3; j++)
					while (true)
					{
						Console.Write($"[{i + 1}, {j + 1}]: ");
						try
						{
							arrB[i, j] = float.Parse(Console.ReadLine());
						}
						catch (FormatException)
						{
							Console.WriteLine("Пожалуйста, введите вещественное число");
							continue;
						}
						catch (OverflowException)
						{
							Console.WriteLine("Это число слишком большое, пожалуйста, используйте другое");
							continue;
						}
						break;
					}// arrB[i, j] = ...

			Console.Clear();
			for (byte i = 0; i < 3; i++)
				Console.WriteLine($"{arrA[i, 0]} {arrA[i, 1]} {arrA[i, 2]}\t| {arrB[i, 0]} {arrB[i, 1]} {arrB[i, 2]}");
			Console.WriteLine();

			char oper;
			while (true)
			{
				Console.Write("Какое действие выполнить(+/-): ");
				try
				{
					oper = char.Parse(Console.ReadLine());
					if (oper != '+' && oper != '-')
						throw new Exception();
				}
				catch
				{
					Console.WriteLine("Пожалуйста, введите знак нужной операции (+ или -)!");
					continue;
				}
				break;
			}// oper = ...

			float[,] aver = new float[3, 3];
			float[,] result = new float[3, 3];
			switch (oper)
            {
				case '+':
					result = Sum(arrA, arrB, aver);
					break;
				case '-':
					result = Diff(arrA, arrB, aver);
					break;
            }

			Console.WriteLine("\nОтвет: ");
			for (byte i = 0; i < 3; i++)
				Console.WriteLine($"{result[i, 0]}\t{result[i, 1]}\t{result[i, 2]}");
			Console.WriteLine("\nСреднее: ");
			for (byte i = 0; i < 3; i++)
				Console.WriteLine($"{aver[i, 0]}\t{aver[i, 1]}\t{aver[i, 2]}");
		}
	}
}
