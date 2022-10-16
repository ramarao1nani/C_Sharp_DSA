using System;

namespace DoubleLinkedList
{
    public class Program
    {
        static void Main(string[] args)
        {
            DoubleLinkedList list = new DoubleLinkedList();
            Console.WriteLine("The following are the Single linked list operations that you can perform");

            while (true)
            {
                Console.WriteLine("-------------------------");
                Console.WriteLine("1. Add element at start");
                Console.WriteLine("2. Add element at end");
                Console.WriteLine("3. Display Elements");
                Console.WriteLine("4. Count the number of elements");
                Console.WriteLine("5. DeleteStart");
                Console.WriteLine("6. DeleteEnd");
                Console.WriteLine("7. InsertElementAt");
                Console.WriteLine("Enter your choice");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        list.InsertElementAtStart();
                        break;
                    case 2:
                        list.InsertElementAtEnd();
                        break;
                    case 3:
                        list.DisplayElements();
                        break;
                    case 4:
                        list.CountElements();
                        break;
                    case 5:
                        list.DeleteStart();
                        break;
                    case 6:
                        list.DeleteEnd();
                        break;
                    case 7:
                        list.InsertElementAt();
                        break;
                }
            }
        }
    }
}