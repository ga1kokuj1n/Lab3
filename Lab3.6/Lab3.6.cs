using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3._6
{
	class Program
	{
		static void Main(string[] args)
		{
			double sumIterative(double[] arg)
			{
				double sum = 0;
				foreach (double o in arg)
					sum += o;
				return sum;
			}

			double minIterative(double[] arg)
            {
				double min = double.PositiveInfinity;
				foreach (double o in arg)
					if (o < min)
						min = o;
				return min;
            }

			double sumRecursive(double[] arg, ulong i = 0, double sum = 0)
            {
				if (i < (ulong)arg.Length)
                {
					sum += arg[i];
					return sumRecursive(arg, i + 1, sum);
                }
                else
                {
					return sum; 
                }
            }

			double minRecursive(double[] arg, ulong i = 0, double min = double.PositiveInfinity)
			{
				if (i < (ulong)arg.Length)
				{
					if (arg[i] < min)
						min = arg[i];
					return minRecursive(arg, i + 1, min);
				}
				else
				{
					return min;
				}
			}

            Console.WriteLine("Эта программа принимает массив чисел и вычисляет сумму и мимимальный элемент итеративно и рекурсивно");
			int n;
			while (true)
			{
				Console.Write("Введите кол-ао элементов массива: ");
				try
				{
					n = int.Parse(Console.ReadLine());
					if (n < 1)
						throw new FormatException();
				}
				catch (FormatException)
				{
					Console.WriteLine("Пожалуйста, введите натуральное число");
					continue;
				}
				catch (OverflowException)
				{
					Console.WriteLine("Это число слишком большое, пожалуйста, используйте другое");
					continue;
				}
				break;
			}// n = ...

			double[] arr = new double[n];
			for (int i = 0; i < n; i++)
				while (true)
				{
					Console.Write($"[{i + 1}]: ");
					try
					{
						arr[i] = double.Parse(Console.ReadLine());
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
				}// arr[i] = ...

			Console.Clear();
			Console.WriteLine("Ваш массив:");
			for (int i = 0; i < n; i++)
				Console.Write(arr[i] + ", ");
			Console.WriteLine("\b\b\0\0");

			Console.WriteLine($"\nСумма итерационно: {sumIterative(arr)}\nСумма рекурсивно: {sumRecursive(arr)}\nМинимальный элемент итерационно: {minIterative(arr)}\nМинимальный элемент рекурсивно: {minRecursive(arr)}");
		}
	}
}
