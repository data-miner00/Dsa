namespace Dsa.LeetCode.UnitTests;

using Dsa.LeetCode.Practice;

public sealed class PowerOfTwoTests
{
    [Theory]
    [InlineData(1)]
    [InlineData(2)]
    [InlineData(4)]
    [InlineData(16)]
    [InlineData(128)]
    public void Is_PowerOfTwo_ReturnTrue(int num)
    {
        var result = PowerOfTwo.Is(num);

        result.Should().BeTrue();
    }

    [Theory]
    [InlineData(3)]
    [InlineData(6)]
    [InlineData(123)]
    [InlineData(321)]
    [InlineData(1099)]
    public void Is_NotPowerOfTwo_ReturnFalse(int num)
    {
        var result = PowerOfTwo.Is(num);

        result.Should().BeFalse();
    }
}
