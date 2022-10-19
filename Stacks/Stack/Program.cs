using System;

namespace Stack // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack stack = new Stack();
            while(true)
            {
                Console.WriteLine("Enter your choice :");
                int choice = Convert.ToInt32(Console.ReadLine());   
                switch(choice)
                {
                    case 1: stack.push();
                        break;
                    case 2: stack.display();
                        break;
                    case 3: stack.pop();
                        break;
                    case 4: stack.peek();
                            break;
                }
            }
        }
    }
}