public class Program
{
    public static void Main(string[] args)
    {
        int[] input = { 1, 2, 3 };
        Permute(input);
    }
    public static List<List<int>> Permute(int[] nums)
    {
        var permutations = new List<List<int>>();
        GeneratePermutations(nums, 0, permutations);
        return permutations;
    }

    private static void GeneratePermutations(int[] nums, int start, List<List<int>> permutations)
    {
        if (start == nums.Length)
        {
            permutations.Add(new List<int>(nums));
            Console.WriteLine(String.Join(' ', nums));
            return;
        }

        for (int i = start; i < nums.Length; i++)
        {
            Swap(nums, start, i);
            GeneratePermutations(nums, start + 1, permutations);
            Swap(nums, start, i);
        }
    }

    private static void Swap(int[] nums, int i, int j)
    {
        int temp = nums[i];
        nums[i] = nums[j];
        nums[j] = temp;
    }
}