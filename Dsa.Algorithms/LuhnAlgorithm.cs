namespace Dsa.Algorithms
{
    public static class LuhnAlgorithm
    {
        /// <summary>
        /// The Luhn's algorithm modified from <see href="https://en.wikipedia.org/wiki/Luhn_algorithm">Wikipedia</see>.
        /// </summary>
        /// <param name="cardNumber">The card number.</param>
        /// <returns>Whether the number is valid or not.</returns>
        public static bool Validate(string cardNumber)
        {
            int sum = 0;
            int parity = cardNumber.Length % 2;

            for (int i = 0; i < cardNumber.Length; i++)
            {
                int digit = cardNumber[i] - '0';

                if (i % 2 != parity)
                {
                    sum += digit;
                }
                else if (digit > 4)
                {
                    sum += (2 * digit) - 9;
                }
                else
                {
                    sum += 2 * digit;
                }
            }

            return sum % 10 == 0;
        }

        /// <summary>
        /// The Luhn's algorithm implementation from <see href="https://www.geeksforgeeks.org/luhn-algorithm/">GeeksForGeeks</see>.
        /// </summary>
        /// <param name="cardNumber">The card number.</param>
        /// <returns>Whether the number is valid or not.</returns>
        public static bool ValidateV2(string cardNumber)
        {
            int sum = 0;
            bool isSecond = false;

            for (int i = cardNumber.Length - 1; i >= 0; --i)
            {
                int digit = cardNumber[i] - '0';

                if (isSecond)
                {
                    digit *= 2;
                }

                sum += digit / 10;
                sum += digit % 10;

                isSecond = !isSecond;
            }

            return sum % 10 == 0;
        }

        /// <summary>
        /// The Luhn's algorithm implemented from <see href="https://en.wikipedia.org/wiki/Luhn_algorithm">Wikipedia</see>.
        /// </summary>
        /// <param name="cardNumber">The card number.</param>
        /// <returns>Whether the number is valid or not.</returns>
        public static bool ValidateV3(string cardNumber)
        {
            int sum = 0;
            int parity = cardNumber.Length % 2;
            int checkDigit = cardNumber[^1] - '0';

            for (int i = 0; i < cardNumber.Length - 1; i++)
            {
                int digit = cardNumber[i] - '0';

                if (i % 2 != parity)
                {
                    sum += digit;
                }
                else if (digit > 4)
                {
                    sum += (2 * digit) - 9;
                }
                else
                {
                    sum += 2 * digit;
                }
            }

            return checkDigit == (10 - (sum % 10)) % 10;
        }
    }
}
