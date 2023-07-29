using System;
using System.Collections.Generic;
using System.Text;

namespace Final
{
    internal class ConcuricGenericQueue<T>
    {
        private T[] queue;
        private int frontVar;
        private int backVar;
        private int length;

        public ConcuricGenericQueue(int maxLength)
        {
            queue = new T[maxLength];
            frontVar = 0;
            backVar = -1;
            length = 0;
        }

        public void Enqueue(T item)
        {
            lock (queue)
            {
                if (length < queue.Length)
                {
                    backVar = (backVar + 1) % queue.Length;
                    queue[backVar] = item;
                    length++;
                }
                else
                {
                    throw new InvalidOperationException("Queue is full.");
                }
            }
        }

        public T Dequeue()
        {
            lock (queue)
            {
                if (length > 0)
                {
                    T item = queue[frontVar];
                    frontVar = (frontVar + 1) % queue.Length;
                    length--;
                    return item;
                }
                else
                {
                    throw new InvalidOperationException("Queue is empty.");
                }
            }
        }

        public int GetCurrentLength()
        {
            lock (queue)
            {
                return length;
            }
        }

        public T Peek()
        {
            lock (queue)
            {
                if (length > 0)
                {
                    return queue[frontVar];
                }
                else
                {
                    throw new InvalidOperationException("Queue is empty.");
                }
            }
        }
    }
}
