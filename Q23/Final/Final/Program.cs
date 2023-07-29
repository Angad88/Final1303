using System;

namespace Final
{


    internal class Program
    {
        static void Main(string[] args)
        {
            ConcuricGenericQueue<int> queue = new ConcuricGenericQueue<int>(5);
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);

            Console.WriteLine("The Peek: " + queue.Peek());
            Console.WriteLine("Length: " + queue.GetCurrentLength());

            int firstItem = queue.Dequeue();
            int secondItem = queue.Dequeue();

            Console.WriteLine("Length: " + queue.GetCurrentLength());
            Console.WriteLine("The Peek: " + firstItem + ", " + secondItem);
        }
    }
}
