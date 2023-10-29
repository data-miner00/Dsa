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
                Left = new BinaryNode<int>
                {
                    Value = 5,
                },
                Right = new BinaryNode<int>
                {
                    Value = 56,
                },
            };

            var expectedTree = new BinaryNode<int>
            {
                Value = 20,
                Left = new BinaryNode<int>
                {
                    Value = 5,
                },
                Right = new BinaryNode<int>
                {
                    Value = 56,
                    Left = new BinaryNode<int>
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
                Left = new BinaryNode<int>
                {
                    Value = 5,
                },
                Right = new BinaryNode<int>
                {
                    Value = 56,
                },
            };

            var expectedTree = new BinaryNode<int>
            {
                Value = 20,
                Left = new BinaryNode<int>
                {
                    Value = 5,
                },
                Right = new BinaryNode<int>
                {
                    Value = 56,
                    Right = new BinaryNode<int>
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
    }
}
