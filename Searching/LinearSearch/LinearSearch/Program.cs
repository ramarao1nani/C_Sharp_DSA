using System;

namespace LinearSearch // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinearSearch linearSearch= new LinearSearch();
            Console.WriteLine("Enter the size of array");
            int size=Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[size];
            Console.WriteLine("Enter the elements of array");
            for(int i=0;i<size;i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());   
            }
            Console.WriteLine("Enter the element to be searched");
            int value=Convert.ToInt32(Console.ReadLine());
            linearSearch.search(value,arr);
        }
    }
}