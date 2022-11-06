using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queues
{
    public class Queue
    {
        public int front { get; set; }
        public int rear { get; set; }  
        public int maxSize { get; set; }
        int[] arr;
        public Queue()
        {
            front= -1;
            rear= -1;
            maxSize = 7;
            arr = new int[maxSize];
        }
        public void enqueue()
        {
            if(rear==maxSize-1)
            {
                Console.WriteLine("Queue is full");
            }
            else
            {
                Console.WriteLine("Enter the value to be inserted : ");
                int val = Convert.ToInt32(Console.ReadLine());
                if(front==-1)
                {
                    front = front + 1;
                }
                rear = rear + 1;
                arr[rear]=val;
            }
        }
        public void dequeue()
        {
            if(front==-1 && rear==-1)
            {
                Console.WriteLine("Queue is empty");
            }
            else if(front==rear)
            {
                front = rear = -1;
            }
            else
            {
                front++;
            }
        }
        public void showfront()
        {
            if(front==-1)
            {
                Console.WriteLine("Queue is empty");
            }
            else
            {
                Console.WriteLine(arr[front]);
            }
        }
        public void displayQueue()
        {
            if(front==-1 && rear==-1)
            {
                Console.WriteLine("Queue is empty");
            }
            else
            {
                for (int i = front; i <= rear; i++)
                {
                    Console.WriteLine(arr[i]);
                }
            }
        }
    }
}
