using System;
using System.Collections.Generic;
using System.Linq;

namespace ConnectedGraph
{
    internal class Program
    {
        private static bool[] visited;
        private static List<int>[] graph;

        static void Main(string[] args)
        {
            graph = ReadGraph();
            CheckIfConnected();
        }

        private static List<int>[] ReadGraph()
        {
            int n = int.Parse(Console.ReadLine());
            var graph = new List<int>[n + 1];

            for (int i = 0; i <= n; i++)
            {
                graph[i] = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToList();
            }

            return graph;
        }

        private static void CheckIfConnected()
        {
            visited = new bool[graph.Length];
            DFS(0);

            for (int i = 0; i < visited.Length; i++)
            {
                if (!visited[i])
                {
                    Console.WriteLine("The graph is not connected.");
                    return;
                }
            }
            Console.WriteLine("The graph is connected.");
        }

        private static void DFS(int vertex)
        {
            if (!visited[vertex])
            {
                visited[vertex] = true;
                foreach (var child in graph[vertex])
                {
                    DFS(child);
                }
            }
        }

    }
}
