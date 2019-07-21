using NUnit.Framework;

namespace InterviewQuestions.LinkedLists.Tests
{
    public class RemoveDupsTests
    {
        private LinkedListNode<int> CreateOneEntry()
        {
            return new LinkedListNode<int>(0);
        }

        private LinkedListNode<int> CreateTwoEntries()
        {
            var head = new LinkedListNode<int>(0);
            var next = new LinkedListNode<int>(0);
            head.Next = next;
            return head;
        }

        private LinkedListNode<int> CreateThreeEntries()
        {
            var head = new LinkedListNode<int>(0);
            var next = new LinkedListNode<int>(1);
            var next2 = new LinkedListNode<int>(2);
            head.Next = next;
            next.Next = next2;
            return head;
        }

        private LinkedListNode<int> CreateFourEntries()
        {
            var head = new LinkedListNode<int>(0);
            var next = new LinkedListNode<int>(2);
            var next2 = new LinkedListNode<int>(2);
            var next3 = new LinkedListNode<int>(3);
            head.Next = next;
            next.Next = next2;
            next2.Next = next3;
            return head;
        }

        private LinkedListNode<int> CreateFourEntriesAnswer()
        {
            var head = new LinkedListNode<int>(0);
            var next = new LinkedListNode<int>(2);
            var next3 = new LinkedListNode<int>(3);
            head.Next = next;
            next.Next = next3;
            return head;
        }

        private LinkedListNode<int> CreateFiveEntries()
        {
            var head = new LinkedListNode<int>(0);
            var next = new LinkedListNode<int>(2);
            var next2 = new LinkedListNode<int>(2);
            var next3 = new LinkedListNode<int>(2);
            var next4 = new LinkedListNode<int>(4);
            head.Next = next;
            next.Next = next2;
            next2.Next = next3;
            next3.Next = next4;
            return head;
        }

        private LinkedListNode<int> CreateFiveEntriesAnswer()
        {
            var head = new LinkedListNode<int>(0);
            var next = new LinkedListNode<int>(2);
            var next3 = new LinkedListNode<int>(4);
            head.Next = next;
            next.Next = next3;
            return head;
        }

        private LinkedListNode<int> CreateSixEntries()
        {
            var head = new LinkedListNode<int>(2);
            var next = new LinkedListNode<int>(2);
            var next2 = new LinkedListNode<int>(3);
            var next3 = new LinkedListNode<int>(3);
            var next4 = new LinkedListNode<int>(4);
            var next5 = new LinkedListNode<int>(4);
            head.Next = next;
            next.Next = next2;
            next2.Next = next3;
            next3.Next = next4;
            next4.Next = next5;
            return head;
        }

        private LinkedListNode<int> CreateSixEntriesAnswer()
        {
            var head = new LinkedListNode<int>(2);
            var next = new LinkedListNode<int>(3);
            var next3 = new LinkedListNode<int>(4);
            head.Next = next;
            next.Next = next3;
            return head;
        }

        private LinkedListNode<int> CreateSevenEntries()
        {
            var head = new LinkedListNode<int>(1);
            var next = new LinkedListNode<int>(5);
            var next2 = new LinkedListNode<int>(5);
            var next3 = new LinkedListNode<int>(4);
            var next4 = new LinkedListNode<int>(5);
            var next5 = new LinkedListNode<int>(5);
            var next6 = new LinkedListNode<int>(7);
            head.Next = next;
            next.Next = next2;
            next2.Next = next3;
            next3.Next = next4;
            next4.Next = next5;
            next5.Next = next6;
            return head;
        }

        private LinkedListNode<int> CreateSevenEntriesAnswer()
        {
            var head = new LinkedListNode<int>(1);
            var next = new LinkedListNode<int>(5);
            var next2 = new LinkedListNode<int>(4);
            var next3 = new LinkedListNode<int>(7);
            head.Next = next;
            next.Next = next2;
            next2.Next = next3;
            return head;
        }

        [Test]
        public void RemoveDups_OneEntry_Same()
        {
            var actual = CreateOneEntry();
            var expected = CreateOneEntry();
            LinkedListExtensions.DeleteDups(ref actual);
            Assert.AreEqual(expected.Value, actual.Value);
            Assert.AreEqual(expected.Next, actual.Next);
        }

        [Test]
        public void RemoveDups_TwoEntries_OneRemoved()
        {
            var actual = CreateTwoEntries();
            var expected = CreateTwoEntries();
            LinkedListExtensions.DeleteDups(ref actual);
            Assert.AreEqual(expected.Value, actual.Value);
            Assert.AreEqual(null, actual.Next);
        }

        [Test]
        public void RemoveDups_ThreeEntries_Same()
        {
            var actual = CreateThreeEntries();
            var expected = CreateThreeEntries();
            LinkedListExtensions.DeleteDups(ref actual);

            while(expected != null)
            {
                Assert.AreEqual(expected.Value, actual.Value);
                expected = expected.Next;
                actual = actual.Next;
            }

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void RemoveDups_FourEntries_OneRemoved()
        {
            var actual = CreateFourEntries();
            var expected = CreateFourEntriesAnswer();
            LinkedListExtensions.DeleteDups(ref actual);

            while (expected != null)
            {
                Assert.AreEqual(expected.Value, actual.Value);
                expected = expected.Next;
                actual = actual.Next;
            }

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void RemoveDups_FiveEntries_TwoRemoved()
        {
            var actual = CreateFiveEntries();
            var expected = CreateFiveEntriesAnswer();
            LinkedListExtensions.DeleteDups(ref actual);

            while (expected != null)
            {
                Assert.AreEqual(expected.Value, actual.Value);
                expected = expected.Next;
                actual = actual.Next;
            }

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void RemoveDups_SixEntries_ThreeRemoved()
        {
            var actual = CreateSixEntries();
            var expected = CreateSixEntriesAnswer();
            LinkedListExtensions.DeleteDups(ref actual);

            while (expected != null)
            {
                Assert.AreEqual(expected.Value, actual.Value);
                expected = expected.Next;
                actual = actual.Next;
            }

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void RemoveDups_SevenEntries_TwoRemoved()
        {
            var actual = CreateSevenEntries();
            var expected = CreateSevenEntriesAnswer();
            LinkedListExtensions.DeleteDups(ref actual);

            while (expected != null)
            {
                Assert.AreEqual(expected.Value, actual.Value);
                expected = expected.Next;
                actual = actual.Next;
            }

            Assert.AreEqual(expected, actual);
        }
    }
}
