using System;
using System.Collections.Generic;
using System.Linq;

namespace CyclesInAGraph
{
    class Program
    {
        static void Main(string[] args)
        {
            Graph graph = ReadGraph();

            if (graph.isCyclic())
                Console.WriteLine("Graph contains cycle");

            else
                Console.WriteLine("Graph doesn't contain cycle");
        }

        public static Graph ReadGraph()
        {
            int verticesCount = int.Parse(Console.ReadLine());
            int edgeCount = int.Parse(Console.ReadLine());

            Graph graph = new Graph(verticesCount);

            for (int i = 0; i < edgeCount; i++)
            {
                int[] input = Console.ReadLine()
                    .Split("-", StringSplitOptions.RemoveEmptyEntries)
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

        public Graph(int verticesCount)
        {
            adjacents = new List<int>[verticesCount];
            for (int i = 0; i < adjacents.Length; i++)
                adjacents[i] = new List<int>();

            Graph.verticesCount = verticesCount;
        }

        public void AddEdge(int firstVertex, int secondVertex)
        {
            adjacents[firstVertex].Add(secondVertex);
            adjacents[secondVertex].Add(firstVertex);
        }

        public bool isCyclic()
        {
            bool[] visited = new bool[verticesCount];

            for (int i = 0; i < verticesCount; i++)
            {
                if (!visited[i])
                {
                    if (isCyclicUtil(i, visited, -1))
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        private bool isCyclicUtil(int vertexIndex, bool[] visited, int parentIndex)
        {
            visited[vertexIndex] = true;

            foreach (int adjacentIndex in adjacents[vertexIndex])
            {
                if (!visited[adjacentIndex])
                {
                    if (isCyclicUtil(adjacentIndex, visited, vertexIndex))
                        return true;
                }
                else if (adjacentIndex != parentIndex)
                {
                    return true;
                }
            }

            return false;
        }
    }
}
