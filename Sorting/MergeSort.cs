using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
	public static class MergeSort
	{
		public static void Fun_SimpleMerge(int[] numbers, int left, int mid, int right)
		{
			int[] temp = new int[25];
			int i, eol, num, pos;
			eol = (mid - 1);
			pos = left;
			num = (right - left + 1);

			while ((left <= eol) && (mid <= right))
			{
				if (numbers[left] <= numbers[mid])
					temp[pos++] = numbers[left++];
				else
					temp[pos++] = numbers[mid++];
			}
			while (left <= eol)
				temp[pos++] = numbers[left++];
			while (mid <= right)
				temp[pos++] = numbers[mid++];
			for (i = 0; i < num; i++)
			{
				numbers[right] = temp[right];
				right--;
			}
		}

		public static void Fun_MergeSort(int[] a, int l, int r)
		{
			int mid;
			
			if (l < r)
			{
				mid = (l + r) / 2;
				Fun_MergeSort(a, l, mid);
				Fun_MergeSort(a, mid + 1, r);
				Fun_SimpleMerge(a, l, mid + 1, r);
			}
		}
	}
}
