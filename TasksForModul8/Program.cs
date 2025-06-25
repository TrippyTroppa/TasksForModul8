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
            GetCatalogs(); 
        }

        static void GetCatalogs()
        {
            string dirName = @"C:\\"; 
            if (Directory.Exists(dirName)) 
            {
                Console.WriteLine("Папки:");
                string[] dirs = Directory.GetDirectories(dirName);  


                foreach (string d in dirs) 
                    Console.WriteLine(d);

                Console.WriteLine();


                Console.WriteLine("Файлы:");
                string[] files = Directory.GetFiles(dirName);


                foreach (string s in files)   
                    Console.WriteLine(s);

                try
                {
                    DirectoryInfo dirInfo = new DirectoryInfo(@"C:\\");
                    if (dirInfo.Exists)
                    {
                        Console.WriteLine(dirInfo.GetDirectories().Length + dirInfo.GetFiles().Length);
                    }

                    DirectoryInfo newDirectory = new DirectoryInfo(@"/newDirectory");
                    if (!newDirectory.Exists)
                        newDirectory.Create();

                    Console.WriteLine(dirInfo.GetDirectories().Length + dirInfo.GetFiles().Length);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }
    }
}

    
