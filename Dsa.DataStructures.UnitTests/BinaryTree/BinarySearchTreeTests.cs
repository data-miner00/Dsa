namespace Dsa.DataStructures.UnitTests.BinaryTree
{
    using Dsa.DataStructures.BinaryTree;

    public sealed class BinarySearchTreeTests : IClassFixture<BinaryTreeFixture>
    {
        private readonly BinaryTreeFixture fixture;

        public BinarySearchTreeTests(BinaryTreeFixture fixture)
        {
            this.fixture = fixture;
        }

        [Theory]
        [InlineData(45)]
        [InlineData(7)]
        public void Find_DataExist_ReturnTrue(int value)
        {
            var actual = BinarySearchTree.Find(this.fixture.Tree1, value);
            actual.Should().BeTrue();
        }

        [Theory]
        [InlineData(49)]
        [InlineData(123)]
        [InlineData(4)]
        public void Find_DataNotExist_ReturnFalse(int value)
        {
            var actual = BinarySearchTree.Find(this.fixture.Tree1, value);
            actual.Should().BeFalse();
        }

        [Fact]
        public void Insert_LessThanNode_InsertedLeft()
        {
            /*
             *   (20)                  (20)
             *   /  \     insert 35    /  \
             * (5)  (56)  -------->  (5)  (56)
             *                            /
             *                          (35)
             */
            var tree = new BinaryNode<int>
            {
                Value = 20,
                Left = new()
                {
                    Value = 5,
                },
                Right = new()
                {
                    Value = 56,
                },
            };

            var expectedTree = new BinaryNode<int>
            {
                Value = 20,
                Left = new()
                {
                    Value = 5,
                },
                Right = new()
                {
                    Value = 56,
                    Left = new()
                    {
                        Value = 35,
                    },
                },
            };

            BinarySearchTree.Insert(tree, 35);

            BinaryTree.IsEqual(tree, expectedTree)
                .Should()
                .BeTrue();
        }

        [Fact]
        public void Insert_MoreThanNode_InsertedRight()
        {
            /*
             *   (20)                   (20)
             *   /  \     insert 100    /  \
             * (5)  (56)  --------->  (5)  (56)
             *                               \
             *                              (100)
             */
            var tree = new BinaryNode<int>
            {
                Value = 20,
                Left = new()
                {
                    Value = 5,
                },
                Right = new()
                {
                    Value = 56,
                },
            };

            var expectedTree = new BinaryNode<int>
            {
                Value = 20,
                Left = new()
                {
                    Value = 5,
                },
                Right = new()
                {
                    Value = 56,
                    Right = new()
                    {
                        Value = 100,
                    },
                },
            };

            BinarySearchTree.Insert(tree, 100);

            BinaryTree.IsEqual(tree, expectedTree)
                .Should()
                .BeTrue();
        }

        [Fact]
        public void DeleteHeapifyDown_WhenNodeIsNull_ReturnNull()
        {
            var actual = BinarySearchTree.Delete(null, 12);
            actual.Should().BeNull();
        }

        [Fact]
        public void DeleteHeapifyDown_DeleteLeftLeaf_ReturnRoot()
        {
            /*
             *   (20)                   (20)
             *   /  \     delete 100    /  \
             * (5)  (56)  --------->  (5)  (56)
             *      / \                    /
             *   (43) (100)              (43)
             */
            var tree = new BinaryNode<int>
            {
                Value = 20,
                Left = new()
                {
                    Value = 5,
                },
                Right = new()
                {
                    Value = 56,
                    Left = new()
                    {
                        Value = 43,
                    },
                    Right = new()
                    {
                        Value = 100,
                    },
                },
            };

            var expectedTree = new BinaryNode<int>
            {
                Value = 20,
                Left = new()
                {
                    Value = 5,
                },
                Right = new()
                {
                    Value = 56,
                    Left = new()
                    {
                        Value = 43,
                    },
                },
            };

            var newRoot = BinarySearchTree.Delete(tree, 100);

            tree.Should().Be(newRoot);
            BinaryTree.IsEqual(tree, newRoot)
                .Should()
                .BeTrue();

            BinaryTree.IsEqual(tree, expectedTree)
                .Should()
                .BeTrue();
        }

        [Fact]
        public void DeleteHeapifyDown_DeleteRightLeaf_ReturnRoot()
        {
            /*
             *   (20)                   (20)
             *   /  \     delete 43     /  \
             * (5)  (56)  --------->  (5)  (56)
             *      / \                      \
             *   (43) (100)                  (100)
             */
            var tree = new BinaryNode<int>
            {
                Value = 20,
                Left = new()
                {
                    Value = 5,
                },
                Right = new()
                {
                    Value = 56,
                    Left = new()
                    {
                        Value = 43,
                    },
                    Right = new()
                    {
                        Value = 100,
                    },
                },
            };

            var expectedTree = new BinaryNode<int>
            {
                Value = 20,
                Left = new()
                {
                    Value = 5,
                },
                Right = new()
                {
                    Value = 56,
                    Right = new()
                    {
                        Value = 100,
                    },
                },
            };

            var newRoot = BinarySearchTree.Delete(tree, 43);

            tree.Should().Be(newRoot);
            BinaryTree.IsEqual(tree, newRoot)
                .Should()
                .BeTrue();

            BinaryTree.IsEqual(tree, expectedTree)
                .Should()
                .BeTrue();
        }

        [Fact(Skip = "Unclear Deletion Algorithm")]
        public void Delete_DeleteBranch_ReturnRoot()
        {
            /*
             *   (20)                   (20)
             *   /  \     delete 56     /  \
             * (5)  (56)  --------->  (5)  (43)
             *      / \                      \
             *   (43) (100)                  (100)
             */
            var tree = new BinaryNode<int>
            {
                Value = 20,
                Left = new()
                {
                    Value = 5,
                },
                Right = new()
                {
                    Value = 56,
                    Left = new()
                    {
                        Value = 43,
                    },
                    Right = new()
                    {
                        Value = 100,
                    },
                },
            };

            var expectedTree = new BinaryNode<int>
            {
                Value = 20,
                Left = new()
                {
                    Value = 5,
                },
                Right = new()
                {
                    Value = 43,
                    Right = new()
                    {
                        Value = 100,
                    },
                },
            };

            var newRoot = BinarySearchTree.Delete(tree, 56);

            tree.Should().Be(newRoot);
            BinaryTree.IsEqual(tree, newRoot)
                .Should()
                .BeTrue();

            BinaryTree.IsEqual(tree, expectedTree)
                .Should()
                .BeTrue();
        }

        [Fact]
        public void DeleteInplace_DeleteBranch_ReturnRoot()
        {
            /*
             *   (20)                   (20)
             *   /  \     delete 56     /  \
             * (5)  (56)  --------->  (5)  (43)
             *      / \                      \
             *   (43) (100)                  (100)
             */
            var tree = new BinaryNode<int>
            {
                Value = 20,
                Left = new()
                {
                    Value = 5,
                },
                Right = new()
                {
                    Value = 56,
                    Left = new()
                    {
                        Value = 43,
                    },
                    Right = new()
                    {
                        Value = 100,
                    },
                },
            };

            var expectedTree = new BinaryNode<int>
            {
                Value = 20,
                Left = new()
                {
                    Value = 5,
                },
                Right = new()
                {
                    Value = 43,
                    Right = new()
                    {
                        Value = 100,
                    },
                },
            };

            var deletedNode = BinarySearchTree.DeleteInplace(tree, 56);

            deletedNode.Should().NotBeNull();
            deletedNode.Value.Should().Be(56);

            BinaryTree.IsEqual(tree, expectedTree)
                .Should()
                .BeTrue();
        }
    }
}
