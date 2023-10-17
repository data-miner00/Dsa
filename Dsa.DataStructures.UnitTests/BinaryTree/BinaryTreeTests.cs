namespace Dsa.DataStructures.UnitTests.BinaryTree
{
    using Dsa.DataStructures.BinaryTree;

    public sealed class BinaryTreeTests
    {
        [Fact]
        public void PreOrderTraversal_ShouldTraverseInCorrectOrder()
        {
            var expected = new[] { 20, 10, 5, 7, 15, 50, 30, 29, 45, 100 };
        
            var actual = BinaryTree.PreOrderTraversal(GetTree());

            actual.ToArray().Should().BeEquivalentTo(expected);
        }

        [Fact]
        public void InOrderTraversal_ShouldTraverseInCorrectOrder()
        {
            var expected = new[] { 5, 7, 10, 15, 20, 29, 30, 45, 50, 100 };

            var actual = BinaryTree.InOrderTraversal(GetTree());

            actual.ToArray().Should().BeEquivalentTo(expected);
        }

        [Fact]
        public void PostOrderTraversal_ShouldTraverseInCorrectOrder()
        {
            var expected = new[] { 7, 5, 15, 10, 29, 45, 30, 100, 50, 20 };
        
            var actual = BinaryTree.PostOrderTraversal(GetTree());

            actual.ToArray().Should().BeEquivalentTo(expected);
        }

        public static BinaryNode<int> GetTree()
        {
            return new BinaryNode<int>
            {
                Value = 20,
                Left = new()
                {
                    Value = 10,
                    Left = new()
                    {
                        Value = 5,
                        Right = new()
                        {
                            Value = 7,
                        },
                    },
                    Right = new()
                    {
                        Value = 15,
                    },
                },
                Right = new()
                {
                    Value = 50,
                    Left = new()
                    {
                        Value = 30,
                        Left = new()
                        {
                            Value = 29,
                        },
                        Right = new()
                        {
                            Value = 45,
                        },
                    },
                    Right = new()
                    {
                        Value = 100,
                    },
                },
            };
        }

        public static BinaryNode<int> GetTree2()
        {
            return new BinaryNode<int>
            {
                Value = 20,
                Left = new()
                {
                    Value = 10,
                    Left = new()
                    {
                        Value = 5,
                        Right = new()
                        {
                            Value = 7,
                        },
                    },
                    Right = new()
                    {
                        Value = 15,
                    },
                },
                Right = new()
                {
                    Value = 50,
                    Left = new()
                    {
                        Value = 30,
                        Left = new()
                        {
                            Value = 29,
                            Left = new()
                            {
                                Value = 21,
                            },
                        },
                        Right = new()
                        {
                            Value = 45,
                            Right = new()
                            {
                                Value = 49,
                            },
                        },
                    },
                },
            };
        }
    }
}
