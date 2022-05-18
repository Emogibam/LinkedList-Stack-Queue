using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListStackQueue
{
    class Stack<T>
    {
        public LinkedList<T> LinkedStack;
        public int count = 0;

        /// <summary>
        /// Constructs the the value of LinkedList
        /// </summary>
        public Stack()
        {
            LinkedStack = new LinkedList<T>();
        }

        /// <summary>
        /// returns true if the stack is empty and false is it isn’t
        /// </summary>
        /// <returns></returns>
        public bool IsEmpty() => count == 0;

        /// <summary>
        ///  shows the number of items currently in the stack
        /// </summary>
        /// <returns></returns>
        public int Size() => count;

        /// <summary>
        ///  adds an item to the tail of the stack
        /// </summary>
        /// <param name="Push"></param>
        public void Push(T input)
        {
            LinkedStack.AddFirst(input);
        }

        /// <summary>
        ///  removes and returns the last item added to the stack and throws an exception when the stack is empty
        /// </summary>
        /// <returns></returns>
        /// <param name="Pop"></param>
        public T Pop()
        {
            if (count == 0)
            {
                throw new Exception("Empty Stack");
            }
            else
            {
                T delete = LinkedStack.head.Data;
                LinkedStack.Remove(LinkedStack.head.Data);
                count--;
                return delete;
            }
        }

        /// <summary>
        /// returns the last item added to the stack and throws exception when the stack is empty
        /// </summary>
        /// <returns></returns>
        /// <param name="Peek"></param>
        public T Peek()
        {
            if (LinkedStack.head == null)
            {
                throw new Exception("Empty Stack");
            }
            else
            {
                return LinkedStack.head.Data;
            }

        }

        public void Print()
        {
            Node<T> runner = LinkedStack.head;
            while (runner != null)
            {
                Console.WriteLine(runner.Data);
                runner = runner.Next;

            }
        }

    }
}
