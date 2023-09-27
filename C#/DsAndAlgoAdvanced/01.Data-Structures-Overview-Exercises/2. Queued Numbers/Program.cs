int result = 0;
Queue<int> numQueue = new Queue<int>(Console.ReadLine().Split(", ").Select(int.Parse));
Queue<string> commandQueue = new Queue<string>(Console.ReadLine().Split(", "));

while (commandQueue.Count > 0)
{
    string command = commandQueue.Dequeue();
	int num = numQueue.Dequeue();

    switch (command)
	{
		case "Add":
			result += num;
			break;
        case "Subtract":
            result -= num;
            break;
		default:
			numQueue.Enqueue(num);
			break;
    }
}

Console.WriteLine(result);

if (numQueue.Count > 0)
{
    int count = numQueue.Count;

	for (int i = 0; i < count; i++)
	{
		Console.Write(numQueue.Dequeue() + " ");
	}
}

