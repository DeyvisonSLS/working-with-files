using System;
using System.IO;
using System.Threading;

namespace working_with_files
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"../../../../private/tmp/file1.txt";

            // FileStream fs = null;
            StreamReader sr = null;

            try
            {
                // fs = new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
                sr = File.OpenText(path);

                while(!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    Console.WriteLine(line);
                }
            }
            catch(IOException e)
            {
                Console.WriteLine("An error ocurred: ");
                Console.WriteLine(e.Message);
            }
            finally
            {
                if(sr != null) sr.Close();
                // if(fs != null) fs.Close();
            }
        }
    }
}
