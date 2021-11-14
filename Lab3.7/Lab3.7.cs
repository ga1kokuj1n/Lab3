using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3._7
{
	class Program
	{
		static void Main(string[] args)
		{
			ulong Fibonacci(ulong pos)
			{
				if (pos == 1 || pos == 2)
					return 1;
				else if (pos <= 0)
					return 0;
				else
					return Fibonacci(pos - 1) + Fibonacci(pos - 2);
			}

			ulong n = 0;
			t1:
			Console.Write("Эта программа рекурсивно вычисляет n-ный член ряда Фибоначчи\n\nВведите n: ");
			try
			{
				n = ulong.Parse(Console.ReadLine());
				if (n == 0)
				{
					Console.WriteLine("Пожалуйста, введите положительное целое число");
					goto t1;
				}
			}
			catch (FormatException)
			{
				Console.WriteLine("Пожалуйста, введите положительное целое число");
				goto t1;
			}
			catch (OverflowException)
			{
				Console.WriteLine("Это число слишком большое, пожалуйста, используйте другое");
				goto t1;
			}

			try
			{
				Console.WriteLine($"\nОтвет: {Fibonacci(n)}");
			}
			catch (OverflowException)
			{
				Console.WriteLine("Это число слишком большое, пожалуйста, используйте другое");
				goto t1;
			}
		}
	}
}
