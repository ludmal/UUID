namespace UUID;

public static class Utils
{
    public static string FindLongestIncreasingSubsequence(string input)
    {
        var sequence = SplitToIntegers(input);

        if (!sequence.Any())
            return string.Empty;

        var longestSubsequence = sequence.Aggregate(
                new { CurrentSubsequence = new List<int>(), LongestSubsequence = new List<int>() },
                (acc, num) =>
                {
                    var currentSubsequence = acc.CurrentSubsequence;
                    var longestSubsequence = acc.LongestSubsequence;

                    if (!currentSubsequence.Any() || num > currentSubsequence.Last())
                    {
                        currentSubsequence.Add(num);
                        longestSubsequence = currentSubsequence.Count > longestSubsequence.Count
                            ? currentSubsequence
                            : longestSubsequence;
                    }
                    else
                    {
                        currentSubsequence = new List<int> { num };
                    }

                    return new { CurrentSubsequence = currentSubsequence, LongestSubsequence = longestSubsequence };
                })
            .LongestSubsequence;

        return string.Join(" ", longestSubsequence);
    }

    private static List<int> SplitToIntegers(string input) => string.IsNullOrWhiteSpace(input)
        ? Enumerable.Empty<int>().ToList()
        : input.Split(' ')
            .Where(s => int.TryParse(s, out _))
            .Select(int.Parse)
            .ToList();
}