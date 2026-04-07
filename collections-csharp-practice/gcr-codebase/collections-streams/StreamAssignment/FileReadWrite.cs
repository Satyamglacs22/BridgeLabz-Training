using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace StreamAssignment
{
    internal class FileReadWrite
    {
        static void Main(string[] args)
        {
            string sourceFile = "source.txt";
            string destinationFile = "destination.txt";

            try
            {
                // Check if source file exists
                if (!File.Exists(sourceFile))
                {
                    Console.WriteLine("Source file does not exist.");
                    return;
                }

                // FileStream for reading and writing
                using (FileStream readStream = new FileStream(sourceFile, FileMode.Open, FileAccess.Read))
                using (FileStream writeStream = new FileStream(destinationFile, FileMode.Create, FileAccess.Write))
                {
                    int data;
                    while ((data = readStream.ReadByte()) != -1)
                    {
                        writeStream.WriteByte((byte)data);
                    }
                }

                Console.WriteLine("File read and written successfully.");
            }
            catch (IOException ex)
            {
                Console.WriteLine("IO Exception occurred: " + ex.Message);
            }
        }
    }
}
