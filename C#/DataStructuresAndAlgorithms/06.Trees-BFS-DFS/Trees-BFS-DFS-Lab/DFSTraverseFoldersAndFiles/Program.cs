using System;
using System.IO;

namespace DFSTraverseFoldersAndFiles
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

            FileInfo[] files = dir.GetFiles();

            foreach (var file in files)
                Console.WriteLine(spaces + " " + file.FullName);

            DirectoryInfo[] children = dir.GetDirectories();

            foreach (var child in children)
                TraverseDirDFS(child, spaces + " ");
        }

        public static void TraverseDirDFS(string directoryPath)
        {
            TraverseDirDFS(new DirectoryInfo(directoryPath), string.Empty);
        }
    }
}
