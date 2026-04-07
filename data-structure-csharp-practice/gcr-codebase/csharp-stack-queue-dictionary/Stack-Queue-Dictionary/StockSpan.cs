using System;
using System.Collections.Generic;

class StockSpan
{
    static void CalculateSpan(int[] price)
    {
        int n = price.Length;
        int[] span = new int[n];
        Stack<int> stack = new Stack<int>();

        span[0] = 1;
        stack.Push(0);

        for (int i = 1; i < n; i++)
        {
            while (stack.Count > 0 && price[stack.Peek()] <= price[i])
                stack.Pop();

            span[i] = (stack.Count == 0) ? i + 1 : i - stack.Peek();
            stack.Push(i);
        }

        for (int i = 0; i < n; i++)
            Console.Write(span[i] + " ");
    }

    static void Main()
    {
        int[] prices = { 100, 80, 60, 70, 60, 75, 85 };
        CalculateSpan(prices);
    }
}
