using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Searching
{
    public class LinearSearch
    {
        public void sortArrayElements(int[] arr)
        {
            Console.WriteLine("Enter the value to be searched");
            int value = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < arr.Length; i++)
            {
                if(arr[i]==value)
                {
                    Console.WriteLine("The value is found at " + i + " index postion");
                    break; 
                }
            }
        }
    }
}
