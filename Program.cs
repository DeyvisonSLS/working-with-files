﻿using System;
using System.IO;
using System.Threading;

namespace working_with_files
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"../../../../private/tmp/file1.txt";

            try
            {
                using(StreamReader sr = File.OpenText(path))
                {
                    while(!sr.EndOfStream)
                    {
                        string line = sr.ReadLine();
                        Console.WriteLine(line);
                    }
                    }
            }
            catch(IOException e)
            {
                Console.WriteLine("And error has ocurred: " + e.Message);
            }
        }
    }
}
