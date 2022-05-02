using System;
using System.Collections.Generic;
using System.Linq;

namespace TraverseGraphWithDFS
{
    class Program
    {
        static void Main(string[] args)
        {
            Graph graph = ReadGraph();

            int startVertex = int.Parse(Console.ReadLine());
            Console.WriteLine($"Following is Depth First Traversal(starting from vertex {startVertex})");

            graph.DFS(startVertex);
        }

        public static Graph ReadGraph()
        {
            int verticesCount = int.Parse(Console.ReadLine());
            int edgeCount = int.Parse(Console.ReadLine());

            Graph graph = new Graph(verticesCount);

            for (int i = 0; i < edgeCount; i++)
            {
                int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();

                graph.AddEdge(input[0], input[1]);
            }

            return graph;
        }
    }
    
    class Graph
    {
        private static int _verticesCount;
        private static List<int>[] _adjacents;
        
        public Graph(int verticesCount)
        {
            _adjacents = new List<int>[verticesCount];
            for (int i = 0; i < _adjacents.Length; i++)
                _adjacents[i] = new List<int>();

            _verticesCount = verticesCount;
        }

        public void AddEdge(int firstVertex, int secondVertex)
        {
            _adjacents[firstVertex].Add(secondVertex);
        }

        public void DFS(int vertex)
        {
            bool[] visited = new bool[_verticesCount];

            DFSUtil(vertex, visited);
        }

        void DFSUtil(int vertex, bool[] visited)
        {
            visited[vertex] = true;
            Console.Write(vertex + " ");

            List<int> verticesList = _adjacents[vertex];
            foreach (var v in verticesList)
            {
                if (!visited[v])
                    DFSUtil(v, visited);
            }
        }
    }
}