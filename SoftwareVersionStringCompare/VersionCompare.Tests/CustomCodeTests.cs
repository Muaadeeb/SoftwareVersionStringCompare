namespace VersionCompare.Tests;
public class CustomCodeTests
{
    [Theory]
    [InlineData("1.0", "1.0", 0)]
    [InlineData("1.1", "1.0", 1)]
    [InlineData("1.0", "1.1", -1)]
    [InlineData("1.0.1", "1.0", 1)]
    [InlineData("1.0", "1.0.1", -1)]
    [InlineData("1.0.0", "1.0", 0)]
    [InlineData("2", "1.5", 1)]
    [InlineData("1.5", "2.12.4.0.6", -1)]
    [InlineData("0.0.0.0", "99.99.99.99", -1)]
    [InlineData("99.99.99.99", "0.0.0.0", 1)]
    [InlineData("99.99.99.99", "99.99.99.99", 0)]
    public void VersionCompare_ShouldReturnCorrectValue(string version1, string version2, int expected)
    {
        int result = CustomCode.VersionCompare(version1, version2);
        Assert.Equal(expected, result);
    }
}