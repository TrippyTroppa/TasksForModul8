using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace TasksForModul8
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }

    public class Drive
    {
        public Drive(string name, long space, long freeSpace)
        {
            Name = name;
            Space = space;
            FreeSpace = freeSpace;
        }

        public string Name { get; }
        public long Space { get; }
        public long FreeSpace { get; }
    }

    public class Folder
    {
        public List<string> Files { get; set; } = new List<string>();
    

     Dictionary<string, Folder> Folders = new Dictionary<string, Folder>();

        public void CreateFolder(string name)
        {
            Folders.Add(name, new Folder());
        }
    } 
}
