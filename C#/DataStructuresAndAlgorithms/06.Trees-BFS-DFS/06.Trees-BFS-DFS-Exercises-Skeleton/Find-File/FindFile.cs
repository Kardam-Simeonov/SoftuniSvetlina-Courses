﻿using System;
using System.IO;

public static class FindFile
{
    private static void TraverseDirDFS(DirectoryInfo dir, string spaces, string fileName)
    {
        try
        {
            FileInfo[] files = dir.GetFiles();

            foreach (var file in files)
                if (file.Name == fileName)
                    Console.WriteLine($"{fileName} is found in {dir.FullName}.");

            DirectoryInfo[] children = dir.GetDirectories();

            foreach (var child in children)
                TraverseDirDFS(child, spaces + " ", fileName);
        }
        catch
        {
            Console.WriteLine($"No access to {dir}");
        }
    }

    public static void TraverseDirDFS(string directoryPath, string fileName)
    {
        TraverseDirDFS(new DirectoryInfo(directoryPath), string.Empty, fileName);
    }

    static void Main()
    {
        //Change directoryPath and fileName if needed
        //TraverseDirDFS(@"E:\", "Trees-BFS-DFS-Exercises.docx"); 
    }
}