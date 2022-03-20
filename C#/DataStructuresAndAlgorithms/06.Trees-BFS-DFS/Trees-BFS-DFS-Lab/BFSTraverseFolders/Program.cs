using System;
using System.Collections.Generic;
using System.IO;

namespace BFSTraverseFolders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //TraverseDirBFS(@"C:\Windows\assembly");
        }

        public static void TraverseDirBFS(string directoryPath)
        {
            var pendingDirs = new Queue<DirectoryInfo>();
            pendingDirs.Enqueue(new DirectoryInfo(directoryPath));

            while (pendingDirs.Count > 0)
            {
                DirectoryInfo currentDir = pendingDirs.Dequeue();
                Console.WriteLine(currentDir.FullName);

                DirectoryInfo[] children = currentDir.GetDirectories();

                foreach (var child in children)
                    pendingDirs.Enqueue(child);
            }
        }
    }
}
