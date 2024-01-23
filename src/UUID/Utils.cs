namespace UUID;

public static class Utils
{
    /// <summary>
    /// Find the longest increasing subsequence in a list of integers
    /// </summary>
    /// <param name="input"></param>
    /// <returns></returns>
    public static string FindLongestIncreasingSubsequence(string input)
    {
        var sequence = SplitToIntegers(input);
        
        if (!sequence.Any())
            return string.Empty;

        // Aggregate function is used to perform computation on a sequence and returns a single result.
        // It starts with list of integers properties: CurrentSubsequence and LongestSubsequence
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
            .LongestSubsequence; // All numbers have been processed, the longest increasing subsequence is returned.

        return string.Join(" ", longestSubsequence);
    }

    /// <summary>
    /// Split the input string by whitespace into an array of strings, then select only the strings that can be parsed into an integer
    /// </summary>
    /// <param name="input">Input string with list of integers seperated by whitespace</param>
    /// <returns>Integer list</returns>
    private static List<int> SplitToIntegers(string input) => string.IsNullOrWhiteSpace(input) // Check if the input string is null or empty, if so return an empty string. IsNullOrWhiteSpace use this to avoid white space between "  " 
        ? Enumerable.Empty<int>().ToList()
        : input.Split(' ') //Split the input string by whitespace into an array of strings, then select only the strings that can be parsed into an integer
            .Where(s => int.TryParse(s, out _)) //We do _ here to avoid memory allocation for the out parameter since we don't need it
            .Select(int.Parse)
            .ToList();
}