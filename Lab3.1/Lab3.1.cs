using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3._1
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Эта программа генерирует случайный массив чисел от -35 до 40, а затем выводит неотрицательные значения в обратном порядке\n");
			ulong n = 0;
			
			while (true)
            {
				Console.Write("Введите кол-во элементов массива: ");
				try
				{
					n = ulong.Parse(Console.ReadLine());
					if (n == 0)
					{
						Console.WriteLine("Пожалуйста, введите положительное целое число!");
						continue;
					}
				}
				catch (FormatException)
				{
					Console.WriteLine("Пожалуйста, введите положительное целое число!");
					continue;
				}
				catch (OverflowException)
				{
					Console.WriteLine("Это число слишком большое, пожалуйста, используйте другое");
					continue;
				}
				break;
			}// n = ...

			int[] arr = new int[n];
			Random rand = new Random();
			int i = 0;
			Console.WriteLine($"\nПолучившийся массив:\n");
			foreach (int o in arr)
			{
				arr[i] = rand.Next(-30, 45);
				Console.Write(arr[i] + ((i + 1)%10 == 0 ? "\n" : "\t"));
				i++;
			}
			Console.WriteLine("\n\nВ обратном порядке без отрицательных:\n");
			i = (int)n - 1;
			foreach (int o in arr)
			{
				if (arr[i] >= 0)
					Console.Write(arr[i] + ", ");
				i--;
			}
			Console.WriteLine("\b\b\0\0");
		}
	}
}
