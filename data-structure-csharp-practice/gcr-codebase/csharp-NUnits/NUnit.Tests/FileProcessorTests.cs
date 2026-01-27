using NUnit.Framework;
using ClassLibrary;
using System.IO;

namespace NUnit.Tests
{
    [TestFixture]
    public class FileProcessorTests
    {
        [Test]
        public void Write_And_Read_File_Test()
        {
            FileProcessor fp = new FileProcessor();
            string file = "test.txt";

            fp.WriteToFile(file, "hello");
            Assert.AreEqual("hello", fp.ReadFromFile(file));
            Assert.IsTrue(File.Exists(file));
        }
    }
}
