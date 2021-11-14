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

            Console.WriteLine("Сгенерирован массив:\n");
			Random rand = new Random();
			double[] arr = new double[10];
			byte it = 0;
			foreach(double o in arr)
            {
				arr[it] = (double)rand.Next(1000) / 10;
				Console.Write(arr[it] + "; ");
				it++;
            }
			Console.WriteLine("\b\b\0\0");

			Console.WriteLine($"\nСумма итерационно: {sumIterative(arr)}\nСумма рекурсивно: {sumRecursive(arr)}\nМинимальный элемент итерационно: {minIterative(arr)}\nМинимальный элемент рекурсивно: {minRecursive(arr)}");
		}
	}
}
