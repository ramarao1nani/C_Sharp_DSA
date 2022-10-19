using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    public class Stack
    {
        public int top { get; set; }
        public int maxSize { get; set; }    
        int[] arr;
        public Stack()
        {
            top = -1;
            maxSize = 7;
            arr = new int[maxSize];
        }
        //public void temp()
        //{
        //    for(int i = 0; i < arr.Length; i++)
        //    {
        //        Console.WriteLine(arr[i]);
        //    }
        //}
        public void peek()
        {
            if (top == -1)
            {
                Console.WriteLine("Stack is empty");
            }
            else
            {
                Console.WriteLine("The top most element is : " + arr[top]);
            }
        }
        public void display()
        {
            if(top==-1)
            {
                Console.WriteLine("Stack is empty");
            }
            else
            {
                Console.WriteLine("The elements are : ");
                for (int i=0;i<=top;i++)
                {
                    Console.WriteLine(arr[i]);
                }
            }
        }
        public void pop()
        {
            if(top==-1)
            {
                Console.WriteLine("Stack is empty");
            }
            else
            {
                top--;
            }
        }
        public void push()
        {
            if(top==maxSize-1)
            {
                Console.WriteLine("Stack is full");
            }
            else
            {
                Console.WriteLine("Enter the value you want to insert");
                int value=Convert.ToInt32(Console.ReadLine());
                top++;
                arr[top] = value;
            }
        }
    }
}
