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
		t1:
			Console.Write("Введите n: ");
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
		t2:
			Console.Write("Введите k: ");
			try
			{
				k = ulong.Parse(Console.ReadLine());
				if (k == 0)
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


			Random rand = new Random();
			byte[] arr = new byte[n];
			ulong i = 0;
            Console.WriteLine("\nПолучившийся массив:\n");
			foreach (byte o in arr)
            {
				arr[i] = (byte)rand.Next(100);
                Console.Write(arr[i] + (i + 1 % 10 == 0 ? "\n" : "\t"));
				i++;
            }

			while (k >= n)
				k -= n;
			
			for (ulong j = 0; j < k; j++)
            {
				byte c = arr[0];
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
		}
	}
}
