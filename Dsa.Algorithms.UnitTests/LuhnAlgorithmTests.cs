namespace Dsa.Algorithms.UnitTests
{
    using System.Collections.Generic;

    public sealed class LuhnAlgorithmTests
    {
        public static IEnumerable<object[]> ValidCardNumberData()
        {
            yield return new object[] { "374245455400126" };
            yield return new object[] { "5425233430109903" };
            yield return new object[] { "4701322211111234" };
        }

        public static IEnumerable<object[]> InvalidCardNumberData()
        {
            yield return new object[] { "574245455400126" };
            yield return new object[] { "6425233430109903" };
            yield return new object[] { "4701322281111234" };
        }

        [Theory]
        [MemberData(nameof(ValidCardNumberData))]
        public void Validate_ValidCardNumber_ReturnTrue(string cardNumber)
        {
            var actual = LuhnAlgorithm.Validate(cardNumber);

            Assert.True(actual);
        }

        [Theory]
        [MemberData(nameof(InvalidCardNumberData))]
        public void Validate_InvalidCardNumber_ReturnFalse(string cardNumber)
        {
            var actual = LuhnAlgorithm.Validate(cardNumber);

            Assert.False(actual);
        }

        [Theory]
        [MemberData(nameof(ValidCardNumberData))]
        public void ValidateV2_ValidCardNumber_ReturnTrue(string cardNumber)
        {
            var actual = LuhnAlgorithm.ValidateV2(cardNumber);

            Assert.True(actual);
        }

        [Theory]
        [MemberData(nameof(InvalidCardNumberData))]
        public void ValidateV2_InvalidCardNumber_ReturnFalse(string cardNumber)
        {
            var actual = LuhnAlgorithm.ValidateV2(cardNumber);

            Assert.False(actual);
        }

        [Theory]
        [MemberData(nameof(ValidCardNumberData))]
        public void ValidateV3_ValidCardNumber_ReturnTrue(string cardNumber)
        {
            var actual = LuhnAlgorithm.ValidateV3(cardNumber);

            Assert.True(actual);
        }

        [Theory]
        [MemberData(nameof(InvalidCardNumberData))]
        public void ValidateV3_InvalidCardNumber_ReturnFalse(string cardNumber)
        {
            var actual = LuhnAlgorithm.ValidateV3(cardNumber);

            Assert.False(actual);
        }
    }
}
