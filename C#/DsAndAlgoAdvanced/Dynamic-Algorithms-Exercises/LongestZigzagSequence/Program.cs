class Program
{
    public static void Main(string[] args)
    {
        int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

        (int lastIndex, int[] prevIncIndex, int[] prevDecIndex, int type) = GetLongestSubsequence(numbers);

        Console.WriteLine(PrintLongestSubsequence(lastIndex, numbers, prevIncIndex, prevDecIndex, type));
    }

    static (int lastIndex, int[] prevIncIndex, int[] prevDecIndex, int type)
        GetLongestSubsequence(int[] numbers)
    {
        int n = numbers.Length;

        int[] increasing = new int[n];
        int[] decreasing = new int[n];

        for (int i = 0; i < n; i++)
        {
            increasing[i] = 1;
            decreasing[i] = 1;
        }

        int[] prevIncIndex = new int[n];
        int[] prevDecIndex = new int[n];

        for (int i = 0; i < n; i++)
        {
            prevIncIndex[i] = -1;
            prevDecIndex[i] = -1;
        }

        int lastIndex = 0;
        int type = 0;

        for (int i = 1; i < n; i++)
        {
            for (int j = 0; j < i; j++)
            {
                if (numbers[i] > numbers[j] && increasing[i] < decreasing[j] + 1)
                {
                    increasing[i] = decreasing[j] + 1;
                    prevIncIndex[i] = j;
                }
                else if (numbers[i] < numbers[j] && decreasing[i] < increasing[j] + 1)
                {
                    decreasing[i] = increasing[j] + 1;
                    prevDecIndex[i] = j;
                }
            }

            if (increasing[i] > decreasing[i] && increasing[i] > increasing[lastIndex])
            {
                lastIndex = i;
                type = 0;
            }
            else if (decreasing[i] > increasing[i] && decreasing[i] > decreasing[lastIndex])
            {
                lastIndex = i;
                type = 1;
            }
        }

        return (lastIndex, prevIncIndex, prevDecIndex, type);
    }

    private static string PrintLongestSubsequence(int lastIndex, int[] numbers, int[] prevIncIndex, int[] prevDecIndex, int type)
    {
        List<int> zigzagSubsequence = new List<int>();
        int currentIndex = lastIndex;
        while (currentIndex != -1)
        {
            zigzagSubsequence.Insert(0, numbers[currentIndex]);
            if (type == 0)
                currentIndex = prevIncIndex[currentIndex];
            else
                currentIndex = prevDecIndex[currentIndex];
            type = 1 - type;
        }

        return String.Join(" ", zigzagSubsequence);
    }
}