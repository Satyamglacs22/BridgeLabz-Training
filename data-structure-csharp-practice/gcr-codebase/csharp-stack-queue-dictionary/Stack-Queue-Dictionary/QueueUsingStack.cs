using System;
using System.Collections.Generic;

class QueueUsingStacks
{
    Stack<int> s1 = new Stack<int>();
    Stack<int> s2 = new Stack<int>();

    public void Enqueue(int data)
    {
        s1.Push(data);
    }

    public int Dequeue()
    {
        if (s1.Count == 0 && s2.Count == 0)
        {
            Console.WriteLine("Queue is empty");
            return -1;
        }

        if (s2.Count == 0)
        {
            while (s1.Count > 0)
            {
                s2.Push(s1.Pop());
            }
        }

        return s2.Pop();
    }

    static void Main()
    {
        QueueUsingStacks q = new QueueUsingStacks();
        q.Enqueue(10);
        q.Enqueue(20);
        q.Enqueue(30);

        Console.WriteLine(q.Dequeue());
        Console.WriteLine(q.Dequeue());
    }
}
