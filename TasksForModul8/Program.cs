using System;
using System.IO;

namespace TasksForModul8
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                DirectoryInfo dirinfo = new DirectoryInfo(@"C:\Users\1\Desktop\TestFolder");
                string TrashPass = @"C:\$Recycle.Bin\TestFolder";

                dirinfo.MoveTo(TrashPass);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }




        }
    }
}