using System;
using System.Collections.Generic;
using System.Linq;

namespace TraverseGraphWithBFS
{
    class Program
    {
        static void Main(string[] args)
        {
            Graph graph = ReadGraph();
            
            int startVertex = int.Parse(Console.ReadLine());
            Console.WriteLine($"Following is Breadth First Traversal(starting from vertex {startVertex})");

            graph.BFS(startVertex);
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
        private static LinkedList<int>[] _adjacents;
        
        public Graph(int verticesCount)
        {
            _adjacents = new LinkedList<int>[verticesCount];
            for (int i = 0; i < _adjacents.Length; i++)
                _adjacents[i] = new LinkedList<int>();

            _verticesCount = verticesCount;
        }

        public void AddEdge(int firstVertex, int secondVertex)
        {
            _adjacents[firstVertex].AddLast(secondVertex);
        }

        public void BFS(int vertex)
        {
            bool[] visitedVertices = new bool[_verticesCount];
            var queue = new Queue<int>();

            visitedVertices[vertex] = true;
            queue.Enqueue(vertex);

            while (queue.Any())
            {
                vertex = queue.Dequeue();
                Console.Write(vertex + " ");
                LinkedList<int> list = _adjacents[vertex];

                foreach (var adjacent in list)
                {
                    if (!visitedVertices[adjacent])
                    {
                        visitedVertices[adjacent] = true;
                        queue.Enqueue(adjacent);
                    }
                }
            }
        }
    }
}