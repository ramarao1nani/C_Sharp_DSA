using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace InterpolationSearch
{
    internal class InterpolationSearch
    {
        public void search(int val, int[] arr)
        {
            int start = 0;
            int end = arr.Length - 1;

            while (start <= end && val >= arr[start] && val <= arr[end])
            {
                int pos = start + ((end - start) / (arr[end] - arr[start])) * (val - arr[start]);
                if (val == arr[pos])
                {
                    Console.WriteLine("The element is at position : " + pos);
                    break;
                }
                else if (val > arr[pos])
                {
                    start = pos + 1;
                }
                else if (val < arr[pos])
                {
                    end = pos - 1;
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
