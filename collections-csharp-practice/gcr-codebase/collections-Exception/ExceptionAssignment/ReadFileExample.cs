using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace ExceptionAssignment
{
    internal class ReadFileExample
    {
        static void Main(string[] args)
        {
            try
            {
                string content = File.ReadAllText("data.txt");
                Console.WriteLine("File Contents:");
                Console.WriteLine(content);
            }
            catch (IOException)
            {
                Console.WriteLine("File not found");
            }
        }
    }
}
