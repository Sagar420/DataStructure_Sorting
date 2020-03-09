using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
	public static class QuickSort
	{
		public static int Fun_Partion(int[] a, int l, int r)
		{
			int i, j, y, t;
			i=l;
			j = r;
			y = a[l];

			while (i < j)
			{
				while (i < r && a[i] <= y) i++;
				while (a[j] > y) j--;
				if (i < j)
				{
					t = a[i];
					a[i] = a[j];
					a[j] = t;
				}
			}

			t = a[j];a[j] = a[l];a[l] = t;
			return j;
		}

		public static void Fun_QuickSort(int [] a,int l,int r)
		{
			int p;
			if (l < r)
			{
				p = Fun_Partion(a, l, r);
				Fun_QuickSort(a, l, p - 1);
				Fun_QuickSort(a, p+1, r);
			}
		}
	}
}
