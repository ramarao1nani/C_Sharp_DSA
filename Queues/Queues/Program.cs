namespace Queues
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue queue = new Queue();
            while (true)
            {
                Console.WriteLine("Enter your choice :");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        queue.enqueue();
                        break;
                    case 2:
                        queue.dequeue();
                        break;
                    case 3:
                        queue.showfront();
                        break;
                    case 4:
                        queue.displayQueue();
                        break;
                }
            }
        }
    }
}