using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace TasksForModul8
{
    class Program
    {
        static void Main(string[] args)
        {
            GetCatalogs(); //   Вызов метода получения директорий
        }

        static void GetCatalogs()
        {
            string dirName = @"\"; // Прописываем путь к корневой директории MacOS (для Windows скорее всего тут будет "C:\\")
            if (Directory.Exists(dirName)) // Проверим, что директория существует
            {
                Console.WriteLine("Папки:");
                string[] dirs = Directory.GetDirectories(dirName);  // Получим все директории корневого каталога
                int folderCount = dirs.Length;

                foreach (string d in dirs) // Выведем их все
                    Console.WriteLine(d);

                Console.WriteLine();
                Console.WriteLine("Файлы:");
                string[] files = Directory.GetFiles(dirName);// Получим все файлы корневого каталога
                int fileCount = files.Length;

                foreach (string s in files)   // Выведем их все
                    Console.WriteLine(s);

                Console.WriteLine();
                Console.WriteLine($"Итого объектов: {folderCount + fileCount}");
                Console.WriteLine($"Из них:");
                Console.WriteLine($"- Папок: {folderCount}");
                Console.WriteLine($"- Файлов: {fileCount}");
            }
        }
    }
}

    
