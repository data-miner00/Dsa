namespace Dsa.LeetCode.Practice.UnitTests
{
    using Dsa.LeetCode.Practice;

    public class ZigzagTests
    {
        [Theory]
        [InlineData("PAYPALISHIRING", 3, "PAHNAPLSIIGYIR")]
        [InlineData("PAYPALISHIRING", 4, "PINALSIGYAHRPI")]
        [InlineData("PAYPALISHIRING", 5, "PHASIYIRPLIGAN")]
        [InlineData("A", 1, "A")]
        [InlineData("ABCD", 3, "ABDC")]
        [InlineData("ABCDE", 4, "ABCED")]
        public void ZigzagConversion_ShouldConvertStringsCorrectly(string from, int rows, string expected)
        {
            var actual = Zigzag.Convert(from, rows);

            actual.Should().BeEquivalentTo(expected);
        }
    }
}
