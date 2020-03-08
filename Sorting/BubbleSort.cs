using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
	public static class BubbleSort
	{
		public static void Fun_BubbleSort(int[] a)
		{
			int i, j, t;

			for (i = a.Length - 2; i >= 0; i--)
			{
				for (j=0;j<=i;j++)
				{
					if (a[j] > a[j + 1])
					{
						t = a[j];
						a[j] = a[j + 1];
						a[j + 1] = t;
					}
				}
			}
		}
	}
}
