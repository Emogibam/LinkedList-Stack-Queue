using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListStackQueue
{
    class Node<T>
    {
        public T Data;
        public Node<T> Next;
        public Node(T input)
        {

            Data = input;
        }

    }
}
