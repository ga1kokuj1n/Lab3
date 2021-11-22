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
			uint n;
			t1:
			Console.Write("Введите чётное кол-во элементов массива: ");
			try
			{
				n = uint.Parse(Console.ReadLine());
				if(n == 0 || n % 2 != 0)
				{
					Console.WriteLine("Пожалуйста, введите чётное натуральное число");
					goto t1;
				}
			}
			catch (FormatException)
            {
				Console.WriteLine("Пожалуйста, введите чётное натуральное число");
				goto t1;
			}
			catch (OverflowException)
            {
				Console.WriteLine("Это число слишком большое, пожалуйста, используйте другое");
				goto t1;
			}
			int[] arr = new int[n];
			
		}
	}
}
