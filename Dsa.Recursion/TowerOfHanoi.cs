namespace Dsa.Recursion
{
    using System;

    /// <summary>
    /// Sample implementation of Tower of Hanoi with stack recursion.
    /// </summary>
    public static class TowerOfHanoi
    {
        /// <summary>
        /// The tracing method for Tower of Hanoi. Time complexity: O(2^n).
        /// </summary>
        /// <param name="ndisk">The number of disks involved.</param>
        /// <param name="from">The starting rod.</param>
        /// <param name="to">The destination rod.</param>
        /// <param name="aux">The auxillary rod.</param>
        public static void Trace(int ndisk, char from, char to, char aux)
        {
            if (ndisk == 0)
            {
                return;
            }

#pragma warning disable S2234 // Arguments should be passed in the same order as the method parameters

            // Move from from to aux
            Trace(ndisk - 1, from, aux, to);
            Console.WriteLine("Moving disk " + ndisk + " from " + from + " to " + to);

            // Move from aux to to
            Trace(ndisk - 1, aux, to, from);
#pragma warning restore S2234 // Arguments should be passed in the same order as the method parameters
        }

        /// <summary>
        /// The example execution of the <see cref="Trace(int, char, char, char)"/> method.
        /// </summary>
        public static void SampleRun()
        {
            Trace(3, 'A', 'C', 'B');
        }
    }
}
