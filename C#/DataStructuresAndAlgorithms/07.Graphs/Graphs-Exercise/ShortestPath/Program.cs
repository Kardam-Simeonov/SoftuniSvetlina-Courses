using System;
using System.Collections.Generic;
using System.Linq;

namespace ShortestPath
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Graph graph = ReadGraph();

            int source = int.Parse(Console.ReadLine());
            int destination = int.Parse(Console.ReadLine());

            int shortestPath = graph.ShortestPath(source, destination);

            Console.WriteLine($"Shortest path length from {source} to {destination}:");

            if (shortestPath == int.MaxValue)
                Console.WriteLine("No path exists");
            else
                Console.WriteLine($"Path found. Length: {shortestPath}");
        }

        public static Graph ReadGraph()
        {
            int verticesCount = int.Parse(Console.ReadLine());
            int edgeCount = int.Parse(Console.ReadLine());

            Graph graph = new Graph(verticesCount);

            for (int i = 0; i < edgeCount; i++)
            {
                int[] input = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                graph.AddEdge(input[0], input[1]);
            }

            return graph;
        }
    }

    class Graph
    {
        private static int verticesCount;
        private static List<int>[] adjacents;
        private static int shortestPathLength;

        public Graph(int verticesCount)
        {
            adjacents = new List<int>[verticesCount];
            for (int i = 0; i < adjacents.Length; i++)
                adjacents[i] = new List<int>();

            Graph.verticesCount = verticesCount;
            shortestPathLength = int.MaxValue;
        }

        public void AddEdge(int firstVertex, int secondVertex)
        {
            adjacents[firstVertex].Add(secondVertex);
            adjacents[secondVertex].Add(firstVertex);
        }

        public int ShortestPath(int source, int destination)
        {
            bool[] visited = new bool[verticesCount];

            ShortestPathUtil(source, destination, visited, 0);

            return shortestPathLength;
        }

        private void ShortestPathUtil(int current, int destination, bool[] visited, int currentLength)
        {
            visited[current] = true;

            foreach (int adjacent in adjacents[current])
            {
                if (!visited[adjacent])
                {
                    if (adjacent == destination)
                    {
                        if (currentLength + 1 < shortestPathLength)
                            shortestPathLength = currentLength + 1;
                    }
                    else
                    {
                        ShortestPathUtil(adjacent, destination, visited, currentLength + 1);
                    }
                } 
            }
            visited[current] = false;
        }
    }
}
