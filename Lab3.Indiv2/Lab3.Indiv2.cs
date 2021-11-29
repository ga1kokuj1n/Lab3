using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3.Indiv2
{
	class Program
	{
		static void Main(string[] args)
		{
			int n;
			while (true)
			{
				Console.Write("Введите ЧЁТНОЕ кол-во элементов массива: ");
				try
				{
					n = int.Parse(Console.ReadLine());
					if (n < 1 || n % 2 != 0)
						throw new FormatException();
				}
				catch (FormatException)
				{
					Console.WriteLine("Пожалуйста, введите чётное натуральное число");
					continue;
				}
				catch (OverflowException)
				{
					Console.WriteLine("Это число слишком большое, пожалуйста, используйте другое");
					continue;
				}
				break;
			}// n = ...

			float[] arr = new float[n];
			Console.WriteLine("Введите элементы массива: ");
			for (int i = 0; i < n; i++)
				while (true)
				{
					Console.Write($"[{i + 1}]: ");
					try
					{
						arr[i] = float.Parse(Console.ReadLine());
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

			bool isSeq = true;
            for (int i = 1; i < n; i++)
                if (arr[i] < arr[i - 1])
                {
					isSeq = false;
					break;
                }
			if (isSeq)
            {
				Console.WriteLine("TRUE: массив - возрастающая последовательность!");
            }
            else
            {
				Console.WriteLine("FALSE: массив - не возрастающая последовательность!");
			}
		}
	}
}
