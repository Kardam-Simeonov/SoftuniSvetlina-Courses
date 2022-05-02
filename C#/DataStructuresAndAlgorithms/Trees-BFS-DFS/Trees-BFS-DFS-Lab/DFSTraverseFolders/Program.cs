using System;
using System.IO;

namespace DFSTraverseFolders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //TraverseDirDFS(@"C:\Windows\assembly");
        }

        private static void TraverseDirDFS(DirectoryInfo dir, string spaces)
        {
            Console.WriteLine(spaces + dir.FullName);

            DirectoryInfo[] children = dir.GetDirectories();

            foreach (var child in children)
                TraverseDirDFS(child, spaces + " ");
        }

        public static void TraverseDirDFS(string directoryPath)
        {
            TraverseDirDFS(new DirectoryInfo(directoryPath),string.Empty);
        }
    }
}
