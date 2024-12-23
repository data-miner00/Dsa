﻿namespace Dsa.DataStructures.Trie
{
    using System.Collections.Generic;

    /// <summary>
    /// The node for a trie.
    /// </summary>
    public sealed class Node
    {
        /// <summary>
        /// Gets or sets the children of the current node.
        /// </summary>
        public Dictionary<char, Node> Children { get; set; } = [];

        /// <summary>
        /// Gets or sets a value indicating whether the current
        /// node represents a complete English word.
        /// </summary>
        public bool Complete { get; set; } = false;
    }
}
