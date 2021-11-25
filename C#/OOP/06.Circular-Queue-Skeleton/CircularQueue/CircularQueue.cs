using System;

public class CircularQueue
{
    private int[] elements;
    private int startIndex;
    private int endIndex;

    public int Count { get; private set; }

    private const int InitialCapacity = 16;
    public CircularQueue(int capacity = InitialCapacity)
    {
        elements = new int[capacity];
    }

    public void Enqueue(int element)
    {
        if (Count >= elements.Length)
            Grow();

        elements[endIndex] = element;
        endIndex = (endIndex + 1) % elements.Length;

        Count++;
    }

    private void Grow()
    {
        int[] newElements = new int[2 * elements.Length];
        CopyAllElementsTo(newElements);

        elements = newElements;
        startIndex = 0;
        endIndex = Count;
    }

    private void CopyAllElementsTo(int[] resultArr)
    {
        int sourceIndex = startIndex;
        int destinationIndex = 0;

        for (int i = 0; i < Count; i++)
        {
            resultArr[destinationIndex] = elements[sourceIndex];
            sourceIndex = (sourceIndex + 1) % elements.Length;
            destinationIndex++;
        }
    }

    public int Dequeue()
    {
        if (Count == 0)
            throw new InvalidOperationException("The queue is empty!");

        int result = elements[startIndex];
        startIndex = (startIndex + 1) % elements.Length;
        Count--;

        return result;
    }

    public int[] ToArray()
    {
        int[] result = new int[Count];
        CopyAllElementsTo(result);
        return result;
    } 
}


class Example
{
    static void Main()
    {
        var queue = new CircularQueue();

        queue.Enqueue(1);
        queue.Enqueue(2);
        queue.Enqueue(3);
        queue.Enqueue(4);
        queue.Enqueue(5);
        queue.Enqueue(6);

        Console.WriteLine("Count = {0}", queue.Count);
        Console.WriteLine(string.Join(", ", queue.ToArray()));
        Console.WriteLine("---------------------------");

        var first = queue.Dequeue();
        Console.WriteLine("First = {0}", first);
        Console.WriteLine("Count = {0}", queue.Count);
        Console.WriteLine(string.Join(", ", queue.ToArray()));
        Console.WriteLine("---------------------------");

        queue.Enqueue(-7);
        queue.Enqueue(-8);
        queue.Enqueue(-9);
        Console.WriteLine("Count = {0}", queue.Count);
        Console.WriteLine(string.Join(", ", queue.ToArray()));
        Console.WriteLine("---------------------------");

        first = queue.Dequeue();
        Console.WriteLine("First = {0}", first);
        Console.WriteLine("Count = {0}", queue.Count);
        Console.WriteLine(string.Join(", ", queue.ToArray()));
        Console.WriteLine("---------------------------");

        queue.Enqueue(-10);
        Console.WriteLine("Count = {0}", queue.Count);
        Console.WriteLine(string.Join(", ", queue.ToArray()));
        Console.WriteLine("---------------------------");

        first = queue.Dequeue();
        Console.WriteLine("First = {0}", first);
        Console.WriteLine("Count = {0}", queue.Count);
        Console.WriteLine(string.Join(", ", queue.ToArray()));
        Console.WriteLine("---------------------------");
    }
}
