namespace Dsa.Recursion
{
    /// <summary>
    /// Different implementations of factorial!.
    /// </summary>
    public static class Factorial
    {
        /// <summary>
        /// For loop implementation of factorial.
        /// </summary>
        /// <param name="number">The number to calculate.</param>
        /// <returns>The factorial.</returns>
        public static int Normal(int number)
        {
            int result = 1;
            for (int i = 1; i <= number; i++)
            {
                result *= i;
            }

            return result;
        }

        /// <summary>
        /// Tail recursive implementation of factorial.
        /// </summary>
        /// <param name="number">The number to calculate.</param>
        /// <returns>The factorial.</returns>
        public static int TailRecursive(int number)
        {
            return Helper(number, 1);

            static int Helper(int number, int accumulator)
            {
                if (number == 1)
                {
                    return accumulator;
                }

                return Helper(number - 1, accumulator * number);
            }
        }

        /// <summary>
        /// Recursive implementation of factorial.
        /// </summary>
        /// <param name="number">The number to calculate.</param>
        /// <returns>The factorial.</returns>
        public static int Recursive(int number)
        {
            return Helper(number);

            static int Helper(int current)
            {
                if (current == 1)
                {
                    return current;
                }

                return Helper(current - 1) * current;
            }
        }
    }
}
