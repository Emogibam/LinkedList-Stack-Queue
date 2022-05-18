using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListStackQueue
{
    class LinkedList<T>
    {
        public int linkedListCount = 0;
        public Node<T> head;

        /// <summary>
        /// Adds data from the bottom
        /// </summary>
        /// <param name="Add"></param>
        /// <returns></returns>
        public int Add(T Data)
        {
            Node<T> newNode = new Node<T>(Data);
            if (head == null)
            {
                head = newNode;
            }
            else
            {
                Node<T> temp = head;
                while (temp.Next != null)
                {
                    temp = temp.Next;
                }
                temp.Next = newNode;
            }
            linkedListCount++;
            return linkedListCount;
        }


        /// <summary>
        /// Removes the data from bottom
        /// </summary>
        /// <param name="Remove"></param>
        /// <returns></returns>
        public bool Remove(T input)
        {
            if (head == null)
            {
                return false;
            }
            else if (head.Data.Equals(input))
            {
                head = head.Next;
                return true;
            }
            Node<T> temp = head;
            while (temp.Next != null)
            {
                if (temp.Next.Data.Equals(input))
                {
                    temp.Next = temp.Next.Next;
                    return true;
                }
                temp = temp.Next;
            }
            return false;
        }

        /// <summary>
        /// checks for a specified item in the linked list. Returns a boolean
        /// </summary>
        /// <param name="Check"></param>
        /// <returns></returns>
        public bool Check(T input) => Index(input) >= 0;

        /// <summary>
        /// - returns the index of an item or returns -1 if the item isn’t found
        /// </summary>
        /// <param name="Index"></param>
        /// <returns></returns>
        public int Index(T input)
        {
            int count = 0;
            Node<T> temp = head;
            while (temp != null)
            {
                if (temp.Data.Equals(input))
                {
                    return count;
                }
                temp = temp.Next;
                count++;
            }
            return -1;
        }

        /// <summary>
        /// Adds from the top
        /// </summary>
        /// <param name="AddFirst"></param>
        public void AddFirst(T input)
        {
            Node<T> newNode = new Node<T>(input);
            if (head == null)
            {
                head = newNode;
                linkedListCount++;
            }
            else
            {
                Node<T> temp = head;
                head = newNode;
                head.Next = temp;
                linkedListCount++;
            }
        }

        public void Print()
        {
            Node<T> runner = head;
            while (runner != null)
            {
                Console.WriteLine(runner.Data);
                runner = runner.Next;

            }
        }


    }



}
