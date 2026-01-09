using System;
using System.Collections.Generic;

class SortStack
{
    static void Sort(Stack<int> stack)
    {
        if (stack.Count > 0)
        {
            int temp = stack.Pop();
            Sort(stack);
            InsertSorted(stack, temp);
        }
    }

    static void InsertSorted(Stack<int> stack, int value)
    {
        if (stack.Count == 0 || stack.Peek() <= value)
        {
            stack.Push(value);
            return;
        }

        int temp = stack.Pop();
        InsertSorted(stack, value);
        stack.Push(temp);
    }

    static void Main()
    {
        Stack<int> stack = new Stack<int>();
        stack.Push(30);
        stack.Push(10);
        stack.Push(20);

        Sort(stack);

        foreach (int item in stack)
            Console.WriteLine(item);
    }
}
