using System;
using System.Text;

namespace StringBuilder_LinerSearch_BinarySearch
{
    internal class ConcatenateStrings
    {
        static void Main(string[] args)
        {
            string[] arr = { "Hello", " ", "World", "!" };
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < arr.Length; i++)
            {
                sb.Append(arr[i]);
            }

            Console.WriteLine("Result: " + sb);
        }
    }
}
