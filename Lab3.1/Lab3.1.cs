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
			ulong n = 0;
		t1:
			Console.Write("Введите кол-во элементов массива: ");
			try
			{
				n = ulong.Parse(Console.ReadLine());
				if (n == 0)
                {
                    Console.WriteLine("Пожалуйста, введите положительное целое число!");
					goto t1;
                }
			}
            catch (FormatException)
            {
				Console.WriteLine("Пожалуйста, введите положительное целое число!");
				goto t1;
			}
			catch (OverflowException)
            {
				Console.WriteLine("Это число слишком большое, пожалуйста, используйте другое");
            }

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
            Console.WriteLine("\n\nВ обратном порядке без отрицательных\n");
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
