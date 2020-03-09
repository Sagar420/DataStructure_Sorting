using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("-------------------Sorting Demo Project---------------------");
			int[] a = { 45, 85, 12, 6, 74, 96, 156, 1000, 862, 456, 2, 1, 89, 302 };
			Console.WriteLine("Size of an array:- " + a.Count() + "\n");
			Console.WriteLine("Before Sorting :- ");
			for (int i = 0; i < a.Length; i++)
			{
				Console.Write(a[i]);
				if (i < a.Length - 1)
				{
					Console.Write(",");
				}
			}
			Console.WriteLine("\n\nSelect Sorting Technique:- \n" +
							  " 1: Bubble Sort \t 2: Selection Sort \t 3:Insertion Sort \t 4:MergeSort \t 5:QuickSort");
			int ch = Convert.ToInt32(Console.ReadLine());
			switch (ch)
			{
				case 1:
					BubbleSort.Fun_BubbleSort(a);
				break;
				case 2:
					SelectionSort.Fun_SelectionSort(a);
				break;
				case 3:
					InsertionSort.Fun_InsertionSort(a);
					break;
				case 4:
					MergeSort.Fun_MergeSort(a, 0, a.Length - 1);
					break;
				case 5:
					QuickSort.Fun_QuickSort(a, 0, a.Length - 1);
					break;
				default:
					Console.WriteLine("\n\nSelect Proper Choice");
					break;
			}
			Console.WriteLine("\n\nAfter Sorting :- ");

			for (int i = 0; i < a.Length; i++)
			{
				Console.Write(a[i]);
				if (i < a.Length - 1)
				{
					Console.Write(",");
				}
			}
			Console.WriteLine("\n\n-------------------------------------------------------------");
			Console.ReadLine();
		}
	}
}
