namespace UUID;

public static class Utils
{
    public static string FindLongestIncreasingSubsequence(string input)
    {
        var sequence = SplitStringIntoListOfInt(input);
        
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

    private static List<int> SplitStringIntoListOfInt(string input)
    {
        if (string.IsNullOrWhiteSpace(input))
            return Enumerable.Empty<int>().ToList();

        var sequence = input.Split(' ');
        var numbers = new List<int>();

        foreach (var s in sequence)
        {
            if (int.TryParse(s, out var number))
                numbers.Add(number);
        }

        return numbers;
    }
    
}