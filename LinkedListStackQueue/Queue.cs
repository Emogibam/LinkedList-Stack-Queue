using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListStackQueue
{
    class Queue<T>
    {
        LinkedList<T> queue;
        public int count = 0;

        public Queue()
        {
            queue = new LinkedList<T>();
        }

        /// <summary>
        /// adds an item to the tail of the queue
        /// </summary>
        /// <param name="Enqueue"></param>
        public void Enqueue(T input)
        {
            queue.Add(input);
            count++;
        }

        /// <summary>
        /// removes and returns the item at the head of the queue
        /// </summary>
        /// <returns></returns>
        /// <exception name="Dequeue"></exception>
        public bool Dequeue()
        {
            if (IsEmpty())
            {
                throw new Exception("Queue empty");
            }
            count--;
            return queue.Remove(queue.head.Data);
        }
        /// <summary>
        /// returns true if the queue is empty and false is it isn’t
        /// </summary>
        /// <returns></returns>
        public bool IsEmpty() => count == 0;
        /// <summary>
        /// shows the number of items currently in the queue
        /// </summary>
        /// <returns></returns>
        public int Size() => count;

        public void Print()
        {
            Node<T> runner = queue.head;
            while (runner != null)
            {
                Console.WriteLine(runner.Data);
                runner = runner.Next;

            }
        }

    }
}
