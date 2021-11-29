using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3._5
{
	class Program
	{
		static void Main(string[] args)
		{
			float[,] arrA = new float[5, 5];
			float[,] arrB = new float[5, 5];
			float[,] result = new float[5, 5];
			Console.WriteLine("Эта программа случайно генерирует 2 матрицы и вычисляет их произведение\n\n1я Матрица:\n");
            for (byte i = 0; i < 5; i++)
                for (byte j = 0; j < 5; j++)
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

            Console.WriteLine("\n2я Матрица:\n");
			for (byte i = 0; i < 5; i++)
				for (byte j = 0; j < 5; j++)
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
			for (byte i = 0; i < 5; i++)
				Console.WriteLine($"{arrA[i, 0]}\t{arrA[i, 1]}\t{arrA[i, 2]}\t{arrA[i, 3]}\t{arrA[i, 4]}\t| {arrB[i, 0]}\t{arrB[i, 1]}\t{arrB[i, 2]}\t{arrB[i, 3]}\t{arrB[i, 4]}");
			Console.WriteLine();

			Console.WriteLine("\nОтвет:\n");
			for (byte i = 0; i < 5; i++)
				for (byte j = 0; j < 5; j++)
				{
					result[i, j] = 0;
					for (byte k = 0; k < 5; k++)
						result[i, j] += arrA[i, k] * arrB[k, j];
					Console.Write($"{result[i, j]}" + (j == 4 ? "\n" : "\t"));
				}
		}
	}
}
