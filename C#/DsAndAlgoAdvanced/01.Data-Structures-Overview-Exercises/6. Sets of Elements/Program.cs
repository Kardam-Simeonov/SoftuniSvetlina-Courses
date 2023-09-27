int[] input = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToArray();

int n = input[0];
int m = input[1];

HashSet<int> firstSet = new HashSet<int>();
HashSet<int> secondSet = new HashSet<int>();

for (int i = 0; i < n; i++)
{
    int num = int.Parse(Console.ReadLine());

    firstSet.Add(num);
}

for (int i = 0; i < m; i++)
{
    int num = int.Parse(Console.ReadLine());

    secondSet.Add(num);
}

firstSet.IntersectWith(secondSet);

foreach (var num in firstSet)
{
    Console.Write(num + " ");
}