using System;
using System.IO;

namespace TasksForModul8
{
    class Program
    {
        static void Main(string[] args)
        {
            GetCatalogs();
        }

        static void GetCatalogs()
        {
            string dirName = @"C:\";
            if (Directory.Exists(dirName))
            {
                Console.WriteLine("Папки:");
                string[] dirs = Directory.GetDirectories(dirName);
                foreach (string d in dirs)
                    Console.WriteLine(d);

                Console.WriteLine("\nФайлы:");
                string[] files = Directory.GetFiles(dirName);
                foreach (string s in files)
                    Console.WriteLine(s);

                try
                {
                    DirectoryInfo dirInfo = new DirectoryInfo(dirName);
                    int totalObjects = dirInfo.GetDirectories().Length + dirInfo.GetFiles().Length;
                    Console.WriteLine($"\nОбщее количество объектов: {totalObjects}");

                    // Создаем временную директорию
                    string tempDirPath = @"C:\newDirectory";
                    DirectoryInfo newDirectory = new DirectoryInfo(tempDirPath);

                    if (!newDirectory.Exists)
                    {
                        newDirectory.Create();
                        Console.WriteLine($"\nСоздана директория: {tempDirPath}");
                    }

                    // Проверяем, что директория появилась
                    if (Directory.Exists(tempDirPath))
                    {
                        Console.WriteLine($"Количество объектов после создания: {dirInfo.GetDirectories().Length + dirInfo.GetFiles().Length}");
                    }

                    // Удаляем директорию
                    newDirectory.Delete(true);
                    Console.WriteLine($"\nДиректория {tempDirPath} удалена.");

                    // Проверяем, что директории больше нет
                    if (!Directory.Exists(tempDirPath))
                    {
                        Console.WriteLine($"Количество объектов после удаления: {dirInfo.GetDirectories().Length + dirInfo.GetFiles().Length}");
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine($"Ошибка: {e.Message}");
                }
            }
            else
            {
                Console.WriteLine("Директория не существует!");
            }
        }
    }
}