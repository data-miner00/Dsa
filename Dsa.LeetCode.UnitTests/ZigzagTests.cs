namespace Dsa.LeetCode.Practice.UnitTests
{
    using Dsa.LeetCode.Practice;
    using ZigzagSln = Dsa.LeetCode.Solution.Zigzag;

    public class ZigzagTests
    {
        public static IEnumerable<object[]> ZigzagData(int numTests)
        {
            var data = new List<object[]>
            {
                new object[] { "PAYPALISHIRING", 3, "PAHNAPLSIIGYIR" },
                new object[] { "PAYPALISHIRING", 4, "PINALSIGYAHRPI" },
                new object[] { "PAYPALISHIRING", 5, "PHASIYIRPLIGAN" },
                new object[] { "A", 1, "A" },
                new object[] { "ABCD", 3, "ABDC" },
                new object[] { "ABCDE", 4, "ABCED" },
            };

            return data.Take(numTests);
        }

        [Theory]
        [MemberData(nameof(ZigzagData), parameters: 6)]
        public void ZigzagConversion_ShouldConvertStringsCorrectly(string from, int rows, string expected)
        {
            var actual = Zigzag.Convert(from, rows);

            actual.Should().BeEquivalentTo(expected);
        }

        [Theory]
        [MemberData(nameof(ZigzagData), parameters: 6)]
        public void ZigzagConversion_Solution1_ShouldConvertStringsCorrectly(string from, int rows, string expected)
        {
            var actual = ZigzagSln.Convert1(from, rows);

            actual.Should().BeEquivalentTo(expected);
        }
    }
}
