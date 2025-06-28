using System;
using System.IO;

namespace TasksForModul8
{
    class Program
    {
        public static void Main()
        {
            string filePath = @"C:\Users\1\Desktop\Курсы\Modul8\TasksForModul8\TasksForModul8\Program.cs"; // Укажем путь

            // Откроем файл и прочитаем его содержимое
            using (StreamReader sr = File.OpenText(filePath))
            {
                string str = "";
                while ((str = sr.ReadLine()) != null)
                    Console.WriteLine(str);
            }
        }
    }
}