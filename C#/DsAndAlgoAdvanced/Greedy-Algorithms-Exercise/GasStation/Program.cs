int[] gas = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
int[] cost = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();

for (int startingPoint = 0; startingPoint < gas.Length; startingPoint++)
{
	int currentGas = 0;
	int currentStation = startingPoint;

    currentGas += gas[currentStation];
    currentGas -= cost[currentStation];
	currentStation++;

    while (true)
	{
        if (currentGas < 0)
            break;

		if (currentStation == startingPoint)
		{
            Console.WriteLine(startingPoint);
            return;
        }
			
		if (currentStation == gas.Length)
			currentStation = 0;

        currentGas += gas[currentStation];
        currentGas -= cost[currentStation];

		currentStation++;
	}
}

Console.WriteLine(-1);