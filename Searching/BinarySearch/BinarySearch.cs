using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearch
{
    internal class BinarySearch
    {
        public void search(int val, int[] arr)
        {
            int start = 0;
            int end = arr.Length - 1;
            
            while(start<=end)
            {
                int mid = (start + end) / 2;
                if (val == arr[mid])
                {
                    Console.WriteLine("The element is at position : "+mid);
                    break;
                }
                else if (val > arr[mid])
                {
                    start = mid + 1;
                }
                else if (val < arr[mid])
                {
                    end = mid - 1;
                }
                else
                {
                    Console.WriteLine("Element not found");
                    break;
                }
            }

        }
    }
}
