using NUnit.Framework;

namespace InterviewQuestions.LinkedLists.Tests
{
    public class FindFromLastTests
    {
        private LinkedListNode<int> CreateList(int n)
        {
            var curr = new LinkedListNode<int>(0);
            var head = curr;
            for (var i = 0; i < n - 1; ++i)
            {
                var next = new LinkedListNode<int>(i + 1);
                curr.Next = next;
                curr = next;
            }
            return head;
        }

        [Test]
        public void FindFromLast_Null_Zero()
        {
            var actual = LinkedListExtensions.FindFromLast<int>(null, 2);
            Assert.AreEqual(0, actual);
        }

        [TestCase(0, 0)]
        [TestCase(1, 0)]
        [TestCase(3, 2)]
        public void FindFromLast_InvalidInput_Zero(int k, int n)
        {
            var list = CreateList(n);

            var actual = LinkedListExtensions.FindFromLast(list, k);
            Assert.AreEqual(0, actual);
        }

        [TestCase(0, 0)]
        [TestCase(1, 2)]
        [TestCase(3, 6)]
        public void FindFromLast_ValidInput_ExpectedResult(int k, int n)
        {
            var list = CreateList(n);

            var actual = LinkedListExtensions.FindFromLast(list, k);
            Assert.AreEqual(n - k, actual);
        }
    }
}
