using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
	public static class InsertionSort
	{
		public static void Fun_InsertionSort(int [] a)
		{
			int i, j, t;
			for (i = 1; i <= a.Length-1; i++)
			{
				t = a[i];j = i;
				while(j>0 && a[j-1]>t)
				{
					a[j] = a[j - 1];
					j = j - 1;
				}
				a[j] = t;
			}
		}
	}
}
