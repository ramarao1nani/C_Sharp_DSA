using System;
using System.Diagnostics.CodeAnalysis;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Linq;

namespace SingleLinkedList
{
    public class LinkedList
    {
        private Node? _head;
        public LinkedList()
        {
            _head = null;
        }
        public void DisplayElements()
        {
            if (_head == null)
            {
                Console.WriteLine("There are no elements in the linked list");
            }
            else
            {
                Console.WriteLine("The elements in the list are : ");
                Node? temp = new Node();
                temp = _head;
                while (temp != null)
                {
                    Console.WriteLine(temp.Data + " ");
                    temp = temp.Next;
                }
            }
        }
        public void AddElementAtStart()
        {
            //create a new node
            Node newNode = new Node();
            Console.WriteLine("Enter the value of Node");
            int val = Convert.ToInt32(Console.ReadLine());
            newNode.Data = val;
            if (_head == null)
            {
                //if head is null then we directly assign the created node to head
                _head = newNode;
            }
            else
            {
                //assign next of new node to head
                newNode.Next = _head;
                //assign head to new node
                _head = newNode;
            }
            DisplayElements();
        }
        public void AddElementAtEnd()
        {
            Node newNode = new Node();
            Console.WriteLine("Enter the value of Node");
            int val = Convert.ToInt32(Console.ReadLine());
            newNode.Data = val;
            newNode.Next = null;
            if (_head == null)
            {
                _head = newNode;
            }
            else
            {
                Node temp = new Node();
                temp = _head;
                while (temp.Next != null)
                {
                    temp = temp.Next;
                }
                temp.Next = newNode;
            }
            DisplayElements();
        }
        public void CountOfElements()
        {
            int count = 1;
            if (_head == null)
            {
                Console.WriteLine("There are no elements :");
            }
            else
            {
                Node temp = _head;
                while (temp.Next != null)
                {
                    count++;
                    temp = temp.Next;
                }
                Console.WriteLine("The number of elements in the list are : " + count);
            }
        }
        public void InsertElementAt()
        {
            Node newNode = new Node();
            Console.WriteLine("Enter the position where element needs to be inserted : ");
            int position = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the value of Node");
            int val = Convert.ToInt32(Console.ReadLine());
            newNode.Data = val;
            if (position < 1)
            {
                Console.WriteLine("Please neter a valid input");
            }
            else if (position == 1)
            {
                if (_head == null)
                {
                    _head = newNode;
                }
                else
                {
                    newNode.Next = _head;
                    _head = newNode;
                }
            }
            else
            {
                Node? temp = new Node();
                temp = _head;
                for (int i = 1; i < position - 1; i++)
                {
                    if (temp != null)
                    {
                        temp = temp.Next;
                    }
                }
                if (temp != null)
                {
                    newNode.Next = temp.Next;
                    temp.Next = newNode;
                    DisplayElements();
                }
                else
                {
                    Console.WriteLine("The previous node is null");
                }
            }
        }
        public void DeleteStart()
        {
            if (_head == null)
            {
                Console.WriteLine("There are no elements in the linked list");
            }
            else
            {
                Node? temp = new Node();
                temp = _head;
                _head = _head.Next;
                temp = null;
                DisplayElements();
            }
        }
        public void DeleteEnd()
        {
            if (_head == null)
            {
                Console.WriteLine("Linked List is empty");
            }
            else if (_head.Next == null)
            {
                _head = null;
            }
            else
            {
                Node? temp = _head;
                while (temp.Next.Next != null)
                {
                    temp = temp.Next;
                }
                Node? LastNode = temp.Next;
                temp.Next = null;
                LastNode = null;
            }
        }
        public void DeleteAllNodes()
        {
            if (_head == null)
            {
                Console.WriteLine("Linked List is empty");
            }
            else
            {
                Node? temp = new Node();
                while (_head != null)
                {
                    temp = _head;
                    _head = _head.Next;
                    temp = null;
                }
            }
        }
    }
}
