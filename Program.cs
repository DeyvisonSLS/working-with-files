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

            FileStream fs = null;
            StreamReader sr = null;

            try
            {
                fs = new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
                sr = new StreamReader(fs);

                string line = sr.ReadLine();
                Console.WriteLine(line);

                // Tentando atualizar texto enquanto edito no bloco de notas
                // Mas ele não mostra a atualização e o While printa todas as linhas do txt
                // while(true)
                // {
                //     string line = sr.ReadLine();
                //     Thread.Sleep(1000);
                //     Console.WriteLine(line);
                //     fs.Flush();
                // }
            }
            catch(IOException e)
            {
                Console.WriteLine("Än error ocurred: ");
                Console.WriteLine(e.Message);
            }
            finally
            {
                if(sr != null) sr.Close();
                if(fs != null) fs.Close();
            }
        }
    }
}
