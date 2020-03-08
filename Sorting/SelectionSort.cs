using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
	public static class SelectionSort
	{
		public static void Fun_SelectionSort(int[] a)
		{
			int i, j, t, min, p;
			for (i = 0; i <= a.Length - 2; i++)
			{
				min = a[i]; p = i;
				for (j = i+1; j <= a.Length - 1; j++)
				{
					if (a[j] < min)
					{
						min = a[j];
						p = j;
					}
				}
				t = a[i];
				a[i] = a[p];
				a[p] = t;
			}
		}
	}
}
