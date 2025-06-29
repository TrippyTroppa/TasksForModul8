using System;
using System.IO;

namespace TasksForModul8
{
    class Program
    {
        public static void Main()
        {
            string FilePath = @"C:\Users\1\Desktop\BinaryFile.bin";

            if (File.Exists(FilePath))
            {
                string StringValue;

                using (BinaryReader reader = new BinaryReader(File.Open(FilePath, FileMode.Open)))
                {
                    StringValue = reader.ReadString();
                }

                Console.WriteLine($"Из файла прочитано:\n {StringValue}");
            }
        }
    }
}


