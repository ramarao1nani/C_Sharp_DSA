using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinearSearch
{
    public class LinearSearch
    {
        public void search(int val, int[] arr)
        {
            int count = 1;
           for(int i = 0; i < arr.Length; i++)
            {
                if(val== arr[i])
                {
                    Console.WriteLine("The element found at : "+i);
                    count = 1;
                    break;
                }
                else
                {
                    count = 0;                                                                                                                                                                                      
                }
            }
           if(count==0)
            {
                Console.WriteLine("Element not found");
            }
        }
    }
}
