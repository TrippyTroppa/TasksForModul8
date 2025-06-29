using System;
using System.IO;

namespace TasksForModul8
{
    class Program
    {
        public static void Main()
        {
            WriteValues();
            ReadValues();
        }

        static void WriteValues()
        {
            using (BinaryWriter writer = new BinaryWriter(File.Open(@"C:\Users\1\Desktop\BinaryFile.bin", FileMode.Open)))
                writer.Write($"Файл изменен {DateTime.Now} на компьютере c ОС {Environment.OSVersion}");
        }

        static void ReadValues()
        {
            string StrValue;

            using (BinaryReader reader = new BinaryReader(File.Open(@"C:\Users\1\Desktop\BinaryFile.bin", FileMode.Open)))
            {
                StrValue = reader.ReadString();
            }

            Console.WriteLine(StrValue);
        }
    }
}


