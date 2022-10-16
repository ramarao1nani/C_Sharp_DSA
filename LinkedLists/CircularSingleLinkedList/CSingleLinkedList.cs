using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CircularSingleLinkedList
{
    public class CSingleLinkedList
    {
        private Node? _head;
        public CSingleLinkedList()
        {
            _head = null;
        }
        public void CountElements()
        {
            if (_head == null)
            {
                Console.WriteLine("There are no elements in the linked list");
            }
            else
            {
                int count = 1;
                Node? temp = _head;
                while (temp.Next != _head)
                {
                    temp = temp.Next;
                    count++;
                }
                Console.WriteLine("There are " + count + " elements in the linked list");
            }
        }
        public void DisplayElements()
        {
            if (_head == null)
            {
                Console.WriteLine("There are no elements in the linked list");
            }
            else
            {
                Console.WriteLine("The elements in the linked list are as follows : ");
                Node? temp = new Node();
                temp = _head;
                while (temp != null)
                {
                    Console.WriteLine(temp.Data);
                    temp = temp.Next;
                    if (temp == _head)
                    {
                        break;
                    }
                }
            }
        }
        public void DeleteStart()
        {
            Node? temp = new Node();
            Node firstNode = new Node();
            firstNode = _head;
            temp = _head;
            if (temp == null)
            {
                Console.WriteLine("The linked list is empty");
            }
            else if (_head.Next == _head)
            {
                _head = null;
            }
            else
            {
                while (temp.Next != _head)
                {
                    temp = temp.Next;
                }
                _head = _head.Next;
                temp.Next = _head;
                firstNode = null;
            }
        }
        public void DeleteEnd()
        {
            Node? temp = new Node();
            Node lastNode = new Node();
            lastNode = _head;
            temp = _head;
            if (temp == null)
            {
                Console.WriteLine("The linked list is empty");
            }
            else if (_head.Next == _head)
            {
                _head = null;
            }
            else
            {
                while (temp.Next.Next != _head)
                {
                    temp = temp.Next;
                }
                lastNode = temp.Next;
                temp.Next = _head;
                lastNode = null;
            }
        }
        public void InsertStart()
        {
            Console.WriteLine("Enter the value of the element : ");
            int value = Convert.ToInt32(Console.ReadLine());
            Node? newNode = new Node();
            newNode.Data = value;
            newNode.Next = null;
            if (_head == null)
            {
                _head = newNode;
                _head.Next = _head;
            }
            else
            {
                Node? temp = new Node();
                temp = _head;
                while (temp.Next != _head)
                {
                    temp = temp.Next;
                }
                temp.Next = newNode;
                newNode.Next = _head;
                _head = newNode;
            }
        }
        public void InsertEnd()
        {
            Console.WriteLine("Enter the value of the element : ");
            int value = Convert.ToInt32(Console.ReadLine());
            Node? newNode = new Node();
            newNode.Data = value;
            newNode.Next = null;
            if (_head == null)
            {
                _head = newNode;
                newNode.Next = _head;
            }
            else
            {
                Node? temp = new Node();
                temp = _head;
                while (temp.Next != _head)
                {
                    temp = temp.Next;
                }
                temp.Next = newNode;
                newNode.Next = _head;
            }
        }
    }
}
