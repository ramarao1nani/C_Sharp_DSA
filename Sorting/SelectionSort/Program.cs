using System;

namespace SelectionSort // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SelectionSort selectionSort = new SelectionSort();
            Console.WriteLine("Enter the size of array");
            int size = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[size];
            Console.WriteLine("Enter the elements of array");
            for (int i = 0; i < size; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            selectionSort.sort(arr);
        }
    }
}