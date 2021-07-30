using System;
using System.IO;

namespace Stream
{
    class Program
    {
        static void Main(string[] args)
        {
            string fileName = @"C:\Users\drago\source\repos\Object and Classes\Stream\bin\Debug\netcoreapp3.1\somefile.txt";

            try
            {
               // FileStream s = File.OpenRead(fileName);
               // s.ReadByte()
                StreamReader reader = new StreamReader(fileName);
                Console.WriteLine("File {0} successfully opened.", fileName);
                Console.WriteLine("File contens:");
                using (reader)
                {
                    Console.WriteLine(reader.ReadToEnd());
                }
            }
            catch (FileNotFoundException)
            {
                Console.Error.WriteLine("Can not find file {0}", fileName);
            }
            catch(DirectoryNotFoundException)
            {
                Console.Error.WriteLine("Invalid directory in the file path.");
            }
            catch(IOException)
            {
                Console.Error.WriteLine("Can not open the file {0}", fileName);
            }
        }
    }
}
