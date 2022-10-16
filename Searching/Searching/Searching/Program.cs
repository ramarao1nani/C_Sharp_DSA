using System;
using System.Collections.Immutable;

namespace Searching // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinearSearch linearSearch = new LinearSearch();
            Console.WriteLine("Enter the size of the array");
            int size = Convert.ToInt32(Console.ReadLine()); 
            int[] arr = new int[size];
            Console.WriteLine("Enter the elements of the array");
            for(int i=0; i < size; i++)
            {
                arr[i]= Convert.ToInt32(Console.ReadLine());
            }
            
            linearSearch.sortArrayElements(arr);
        }
    }
}