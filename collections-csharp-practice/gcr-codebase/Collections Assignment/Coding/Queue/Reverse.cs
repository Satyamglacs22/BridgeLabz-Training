using System;
using System.Collections.Generic;

namespace Collections_Assignment.Coding.Queue
{
    internal class Reverse
    {
        public static void Main()
        {
            Queue<int> q = new Queue<int>();
            q.Enqueue(1);
            q.Enqueue(2);
            q.Enqueue(3);
            q.Enqueue(4);
            q.Enqueue(5);

            ReverseQueue(q);

            Console.WriteLine("Reversed Queue:");
            foreach (var e in q)
            {
                Console.Write(e + " ");
            }
        }

        public static void ReverseQueue(Queue<int> q)
        {
            Stack<int> st = new Stack<int>();

            // Queue → Stack (using queue operations)
            while (q.Count > 0)
            {
                st.Push(q.Dequeue());
            }

            // Stack → Queue
            while (st.Count > 0)
            {
                q.Enqueue(st.Pop());
            }
        }
    }
}
