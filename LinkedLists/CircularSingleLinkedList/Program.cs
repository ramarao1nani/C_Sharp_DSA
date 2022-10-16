using System;

namespace CircularSingleLinkedList // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CSingleLinkedList cSingleLinkedList = new CSingleLinkedList();
            while (true)
            {
                Console.WriteLine("Enter your choice : ");
                int choice=Convert.ToInt32(Console.ReadLine());
                switch(choice)
                {
                    case 1:
                        cSingleLinkedList.InsertStart();
                        break;
                    case 2:
                        cSingleLinkedList.DisplayElements();
                        break;
                    case 3:
                        cSingleLinkedList.InsertEnd();
                        break;
                    case 4:
                        cSingleLinkedList.DeleteStart();
                        break;
                    case 5:
                        cSingleLinkedList.DeleteEnd();
                        break;
                    case 6:
                        cSingleLinkedList.CountElements();
                        break;
                }
            }
        }
    }
}