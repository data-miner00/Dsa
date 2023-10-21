namespace Dsa.DataStructures.UnitTests.BinaryTree
{
    using System;
    using Dsa.DataStructures.BinaryTree;

    public sealed class BinaryTreeFixture : IDisposable
    {
        private bool isDisposed = false;

        public BinaryTreeFixture()
        {
            this.Tree1 = GetTree();
            this.Tree2 = GetTree2();
        }

        public BinaryNode<int> Tree1 { get; private set; }

        public BinaryNode<int> Tree2 { get; private set; }

        public void Dispose()
        {
            if (this.isDisposed)
            {
                return;
            }

            this.isDisposed = true;
        }

        private static BinaryNode<int> GetTree()
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

        private static BinaryNode<int> GetTree2()
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
