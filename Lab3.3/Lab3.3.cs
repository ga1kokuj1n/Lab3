using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3._3
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Эта программа генерирует массив n чисел и циклично сдвигает его на k элементов вправо\n");
			ulong n = 0, k = 0;
			while (true)
			{
				Console.Write("Введите n: ");
				try
				{
					n = ulong.Parse(Console.ReadLine());
					if (n == 0)
						throw new FormatException();
				}
				catch (FormatException)
				{
					Console.WriteLine("Пожалуйста, введите положительное целое число");
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
			Console.WriteLine("Введите элементы массива:");
			for (ulong j = 0; j < n; j++)
				while (true)
				{
					Console.Write($"[{j + 1}]: ");
					try
					{
						arr[j] = double.Parse(Console.ReadLine());
					}
					catch (FormatException)
					{
						Console.WriteLine("Пожалуйста, введите положительное целое число");
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
			int i = 0;
			Console.WriteLine("\nПолучившийся массив:\n");
			foreach (byte o in arr)
			{
				Console.Write(arr[i] + (i + 1 % 10 == 0 ? "\n" : "\t"));
				i++;
			}
			Console.WriteLine("\n");

			while (true)
			{
				Console.Write("Введите k: ");
				try
				{
					k = ulong.Parse(Console.ReadLine());
					if (k == 0)
					{
						Console.WriteLine("Пожалуйста, введите положительное целое число");
						continue;
					}
				}
				catch (FormatException)
				{
					Console.WriteLine("Пожалуйста, введите положительное целое число");
					continue;
				}
				catch (OverflowException)
				{
					Console.WriteLine("Это число слишком большое, пожалуйста, используйте другое");
					continue;
				}
				break;
			}// k = ...

			while (k >= n)
				k -= n;
			
			for (ulong j = 0; j < k; j++)
			{
				double c = arr[0];
				for (ulong l = 1; l < n; l++)
				{
					arr[l - 1] = arr[l];
				}
				arr[n - 1] = c;
			}

			Console.WriteLine("\n\nМассив после сдвига:\n");
			i = 0;
			foreach (byte o in arr)
			{
				Console.Write(arr[i] + (i + 1 % 10 == 0 ? "\n" : "\t"));
				i++;
			}
			Console.Write('\n');

			Console.ReadLine();
		}
	}
}
