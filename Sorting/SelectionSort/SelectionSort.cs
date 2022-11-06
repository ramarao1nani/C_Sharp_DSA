using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelectionSort
{
    internal class SelectionSort
    {
        public void sort(int[] arr)
        {
            int size = arr.Length;
            int temp;
            for (int i = 0; i < size - 1; i++)
            {
                int minvalue= i;
                for(int j=i;j<size;j++)
                {
                    if(arr[j] < arr[minvalue])
                    {
                        minvalue=j;
                    }
                }
                temp = arr[i];
                arr[i] = arr[minvalue];
                arr[minvalue] = temp;
            }
            Console.WriteLine("The sorted Array is :");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }
    }
}
