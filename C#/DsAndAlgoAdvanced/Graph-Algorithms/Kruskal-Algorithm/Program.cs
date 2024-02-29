using System;
using System.Collections.Generic;

class Edge : IComparable<Edge>
{
    public int Source { get; }
    public int Destination { get; }
    public int Weight { get; }

    public Edge(int source, int destination, int weight)
    {
        Source = source;
        Destination = destination;
        Weight = weight;
    }

    public int CompareTo(Edge other)
    {
        return Weight.CompareTo(other.Weight);
    }
}
   
class Program
{
    static void Main(string[] args)
    {
        int[,] graphWeights = {
            { 0, 2, 0, 4, 0, 5, 0},
            { 2, 0, 7, 1, 3, 8, 4},
            { 0, 7, 0, 0, 10, 0, 6},
            { 4, 1, 0, 0, 2, 0, 0},
            { 0, 3, 10, 2, 0, 0, 0},
            { 5, 8, 0, 0, 0, 0, 1},
            { 0, 4, 6, 0, 0, 1, 0}
        };

        int verticesCount = 7;
        List<Edge> edges = new List<Edge>();

        for (int i = 0; i < verticesCount; i++)
        {
            for (int j = i + 1; j < verticesCount; j++)
            {
                if (graphWeights[i, j] != 0)
                {
                    edges.Add(new Edge(i, j, graphWeights[i, j]));
                }
            }
        }

        KruskalMST(edges, verticesCount);
    }

    static void KruskalMST(List<Edge> edges, int verticesCount)
    {
        edges.Sort();

        int[] parents = new int[verticesCount];

        int weightSum = 0;

        for (int node = 0; node < verticesCount; node++)
        {
            parents[node] = node;
        }

        foreach (Edge edge in edges)
        {
            //Console.WriteLine(String.Join(" ", parents));
            int firstNodeRoot = GetRoot(parents, edge.Source);
            int secondNodeRoot = GetRoot(parents, edge.Destination);

            if (firstNodeRoot != secondNodeRoot)
            {
                Console.WriteLine($"{edge.Source + 1} - {edge.Destination + 1}: {edge.Weight}");
                weightSum += edge.Weight;
                parents[firstNodeRoot] = secondNodeRoot;
            }
        }

        Console.WriteLine($"Weight Sum = {weightSum}");
    }

    static int GetRoot(int[] parents, int node)
    {
        while (node != parents[node])
        {
            node = parents[node];
        }
        return node;
    }
}
