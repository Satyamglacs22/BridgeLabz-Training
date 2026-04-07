using System;

namespace StringBuilder_LinerSearch_BinarySearch
{
    internal class SearchWord
    {
        static void Main(string[] args)
        {
            string[] sentences =
            {
                "I love CSharp",
                "Programming is fun",
                "Learning never stops"
            };

            Console.WriteLine("Enter word to search:");
            string word = Console.ReadLine();

            for (int i = 0; i < sentences.Length; i++)
            {
                if (sentences[i].Contains(word))
                {
                    Console.WriteLine("Found in sentence: " + sentences[i]);
                    break;
                }
            }
        }
    }
}
