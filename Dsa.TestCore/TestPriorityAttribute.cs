namespace Dsa.TestCore
{
    using System;

    /// <summary>
    /// The attribute to mark priority for a test method.
    /// </summary>
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = false)]
    public class TestPriorityAttribute : Attribute
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TestPriorityAttribute"/> class.
        /// </summary>
        /// <param name="priority">The priority of the test case.</param>
        public TestPriorityAttribute(int priority)
        {
            this.Priority = priority;
        }

        /// <summary>
        /// Gets the priority of the test case.
        /// </summary>
        public int Priority { get; private set; }
    }
}
