using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoubleLinkedList
{
    public class DoubleLinkedList
    {
        private Node? _head;
        public DoubleLinkedList()
        {
            _head = null;
        }
        public void InsertElementAtStart()
        {
            Node newNode = new Node();
            Console.WriteLine("Enter the value of Node");
            int val = Convert.ToInt32(Console.ReadLine());
            newNode.Data = val;
            if (_head == null)
            {
                _head = newNode;
            }
            else
            {
                _head.Prev = newNode;
                newNode.Next = _head;
                _head = newNode;
            }
        }
        public void InsertElementAtEnd()
        {
            Node newNode = new Node();
            Console.WriteLine("Enter the value of Node");
            int val = Convert.ToInt32(Console.ReadLine());
            newNode.Data = val;
            if (_head == null)
            {
                _head = newNode;
            }
            else
            {
                Node? temp = new Node();
                temp = _head;
                while (temp.Next != null)
                {
                    temp = temp.Next;
                }
                temp.Next = newNode;
                newNode.Prev = temp;
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
                    _head.Prev = newNode;
                    newNode.Next = _head;
                    _head = newNode;
                }
            }
            else
            {
                Node temp = new Node();
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
                    newNode.Prev = temp;
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
                if (_head != null)
                {
                    _head.Prev = null;
                }
            }
        }
        public void DeleteEnd()
        {
            Node? temp = new Node();
            temp = _head;
            if (temp == null)
            {
                Console.WriteLine("There are no elements in the linked list");
            }
            else if (temp.Next == null)
            {
                _head = null;
            }
            else
            {
                Node? lastnode = new Node();
                while (temp.Next.Next != null)
                {
                    temp = temp.Next;
                }
                lastnode = temp.Next;
                temp.Next = null;
                lastnode.Prev = null;
                lastnode = null;
            }
        }
        public void DisplayElements()
        {
            Node? Temp = new Node();
            Temp = _head;
            if (_head == null)
            {
                Console.WriteLine("There are no elements in the linked list");
            }
            else
            {
                while (Temp != null)
                {
                    Console.WriteLine(Temp.Data);
                    Temp = Temp.Next;
                }
            }
        }
        public void CountElements()
        {
            Node? temp = new Node();
            int count = 1;
            if (_head == null)
            {
                Console.WriteLine("There are no elements in the linked list : ");
            }
            else
            {
                temp = _head;
                while (temp.Next != null)
                {
                    count++;
                    temp = temp.Next;
                }
                Console.WriteLine("There are " + count + " elements in the linked list");
            }
        }
    }
}
