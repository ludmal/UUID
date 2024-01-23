namespace UUID.Tests;

public class UtilTests
{
    [Theory]
    [InlineData("1 2 3 4 5", "1 2 3 4 5")]
    public void Test1(string input, string expected)
    {
        Assert.Equal(expected, Utils.FindLongestIncreasingSubsequence(input));
    }
}