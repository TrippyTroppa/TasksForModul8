using System;
using System.IO;

namespace TasksForModul8
{
    class Program
    {
        public static void Main()
        {
            var fi = new FileInfo ( @"C:\Users\1\Desktop\Курсы\Modul8\TasksForModul8\TasksForModul8\Program.cs"); // Укажем путь

            using (StreamWriter sw = fi.AppendText())
            {
                sw.WriteLine($"\nВремя запуска: {DateTime.Now}");
            }

            // Откроем файл и прочитаем его содержимое
            using (StreamReader sr = fi.OpenText())
            {
                string str = "";
                while ((str = sr.ReadLine()) != null)
                    Console.WriteLine(str);
            }
        }
    }
}

Время запуска: 28.06.2025 22:50:48
