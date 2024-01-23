namespace UUID;

public static class Utils
{
    public static string FindLongestIncreasingSubsequence(string input)
    {
        var sequence = SplitToIntegers(input);

        if (!sequence.Any())
            return "";

        var longestSubsequence = new List<int>();
        var currentSubsequence = new List<int>();

        foreach (var num in sequence)
        {
            if (currentSubsequence.Count == 0 || num > currentSubsequence.Last())
            {
                currentSubsequence.Add(num);

                if (currentSubsequence.Count > longestSubsequence.Count)
                {
                    longestSubsequence = new List<int>(currentSubsequence);
                }
            }
            else
            {
                currentSubsequence = new List<int> { num };
            }
        }

        return string.Join(" ", longestSubsequence);
    }

    private static List<int> SplitToIntegers(string input) => string.IsNullOrWhiteSpace(input)
        ? Enumerable.Empty<int>().ToList()
        : input.Split(' ')
            .Where(s => int.TryParse(s, out _))
            .Select(int.Parse)
            .ToList();
}