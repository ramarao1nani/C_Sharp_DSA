using System;

namespace CircularDoubleLinkedList // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CDoubleLinkedList cDoubleSingleLinkedList = new CDoubleLinkedList();
            while (true)
            {
                Console.WriteLine("Enter your choice : ");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        cDoubleSingleLinkedList.InsertStart();
                        break;
                    case 2:
                        cDoubleSingleLinkedList.DisplayElements();
                        break;
                    case 3:
                        cDoubleSingleLinkedList.InsertEnd();
                        break;
                    case 4:
                        cDoubleSingleLinkedList.DeleteStart();
                        break;
                    case 5:
                        cDoubleSingleLinkedList.DeleteEnd();
                        break;
                    case 6:
                        cDoubleSingleLinkedList.CountElements();
                        break;
                }
            }
        }
    }
}