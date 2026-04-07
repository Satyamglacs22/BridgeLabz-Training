using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace ExceptionAssignment
{
    internal class UsingFileExample
    {
        static void Main(string[] args)
        {
            try
            {
                using (StreamReader reader = new StreamReader("info.txt"))
                {
                    Console.WriteLine(reader.ReadLine());
                }
            }
            catch (IOException)
            {
                Console.WriteLine("Error reading file");
            }
        }
    }
}
