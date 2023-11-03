namespace Dsa.DataStructures.Trie
{
    /// <summary>
    /// The trie data structure.
    /// </summary>
    public sealed class Trie
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Trie"/> class.
        /// </summary>
        public Trie()
        {
            this.Root = new Node();
        }

        /// <summary>
        /// Gets the genesis node of the trie.
        /// </summary>
        public Node Root { get; private set; }

        /// <summary>
        /// Gets the current count of words in the trie.
        /// </summary>
        public int Count { get; private set; }

        /// <summary>
        /// Inserts a word into the trie.
        /// </summary>
        /// <param name="word">The word to be inserted.</param>
        public void Insert(string word)
        {
            var current = this.Root;

            foreach (var character in word)
            {
                if (!current.Children.TryGetValue(character, out var node))
                {
                    current.Children.Add(character, new Node());
                }

                current = current.Children[character];
            }

            current.Complete = true;
            this.Count++;
        }

        /// <summary>
        /// Searches whether the word exists in the trie.
        /// </summary>
        /// <param name="word">The word to be searched.</param>
        /// <returns>The flag indicating the word exists or not.</returns>
        public bool Search(string word)
        {
            var current = this.Root;

            foreach (var character in word)
            {
                if (!current.Children.TryGetValue(character, out var node))
                {
                    return false;
                }

                current = current.Children[character];
            }

            return current.Complete;
        }

        /// <summary>
        /// Check whether the prefix exists in the trie.
        /// </summary>
        /// <param name="prefix">The prefix to be searched.</param>
        /// <returns>The flag indicating the prefix exists or not.</returns>
        public bool StartsWith(string prefix)
        {
            var current = this.Root;

            foreach (var character in prefix)
            {
                if (!current.Children.TryGetValue(character, out var node))
                {
                    return false;
                }

                current = current.Children[character];
            }

            return true;
        }

        /// <summary>
        /// Deletes the word from the trie.
        /// </summary>
        /// <param name="word">The word to be deleted.</param>
        /// <exception cref="NotImplementedException">To be implemented.</exception>
        public void Delete(string word)
        {
            throw new NotImplementedException();
        }
    }
}
