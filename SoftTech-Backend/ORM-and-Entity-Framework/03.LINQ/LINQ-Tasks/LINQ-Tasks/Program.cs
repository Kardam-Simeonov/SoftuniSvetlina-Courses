namespace LINQ_Tasks
{
    class Program
    {
        public static void Main(string[] args)
        {
            var arr = new List<int>() { 1, 2 , 3, 4, 5, 6, 7, 8, 12, 24, 40, 57, 13, 21, 85, 101 };

            RemoveEvenNumbers(arr);
            Console.WriteLine(String.Join(", ", ExtractSquareOfEachNumber(arr)));

            var temp = ExtractInformation(arr);
            Console.Write('|');
            for (int i = 0; i < temp[0].Length; i++)
                Console.Write($" {temp[0][i]} {temp[1][i]} {temp[2][i]} |");
            Console.WriteLine();

            Console.WriteLine(String.Join(", ", ExtractNumbersGreaterThan80(arr)));

            arr.RemoveRange(2, 5);
            Console.WriteLine(String.Join(", ", arr));
        }

        //1
        public static void RemoveEvenNumbers(List<int> input)
        {
            var filteredArr = input.Where(x => x % 2 == 0).ToList();
            input.RemoveAll(x => filteredArr.Contains(x));
        }

        public static List<int> ExtractSquareOfEachNumber(List<int> input)
        {
            var squaredNumbers = input.Select(x => x *= x).ToList();

            return squaredNumbers;
        }

        public static List<int[]> ExtractInformation(List<int> input)
        {
            var output = new List<int[]>();

            output.Add(input.Distinct().ToArray());
            output.Add(input.GroupBy(x => x).Select(x => x.Key * x.Count()).ToArray());
            output.Add(input.GroupBy(x => x).Select(x => x.Count()).ToArray());

            return output;
        }

        public static List<int> ExtractNumbersGreaterThan80(List<int> input)
        {
            var output = input.Where(x => x > 80).ToList();

            return output;
        }

        public static void RemoveRangeFrom(ref List<int> input, int startingIndex, int length)
        {
            input.RemoveRange(startingIndex, length);
        }
    }
}