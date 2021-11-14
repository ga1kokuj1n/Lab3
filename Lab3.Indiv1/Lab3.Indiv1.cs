using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3.Indiv1
{
	class Program
	{
		static void Main(string[] args)
		{
			Random rand = new Random();
			int[,] arr = new int[9, 9];

			byte i = 0, j = 0, dir = 1, num = 1, lim1 = 8, lim2 = 8, lim3 = 0, lim4 = 1;
			while(i != 4 || j != 4)
			{
				arr[i, j] = num++;
				switch (dir)
				{
					case 1:
						if (j == lim1)
						{
							dir = 2;
							i++;
							lim1--;
						}
						else
							j++;
						break;
					case 2:
						if (i == lim2)
						{
							dir = 3;
							j--;
							lim2--;
						}
						else
							i++;
						break;
					case 3:
						if (j == lim3)
						{
							dir = 4;
							i--;
							lim3++;
						}
						else
							j--;
						break;
					case 4:
						if (i == lim4)
						{
							dir = 1;
							j++;
							lim4++;
						}
						else
							i--;
						break;
				}
			}
			arr[4, 4] = num;

			for (byte y = 0; y < 9; y++)
				for (byte x = 0; x < 9; x++)
					Console.Write(arr[y, x] + (x == 8 ? "\n" : "\t"));

		}
	}
}
