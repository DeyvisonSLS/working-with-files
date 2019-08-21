using System;
using System.IO;

namespace working_with_files
{
    class Program
    {
        static void Main(string[] args)
        {
            string sourcePath = @"../../../../private/tmp/file1.txt";
            string targetPath = @"../../../../private/tmp/file2.txt";

            try
            {
                FileInfo fileInfo = new FileInfo(sourcePath);
                fileInfo.CopyTo(targetPath);

                string[] lines = File.ReadAllLines(sourcePath);
                foreach(string line in lines)
                {
                    Console.WriteLine(line);
                }

            }
            catch(IOException e)
            {
                Console.WriteLine("An error ocurred: " + e.Message);
            }
        }
    }
}
