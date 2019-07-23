using NUnit.Framework;
using System;

namespace InterviewQuestions.LinkedLists.Tests
{
    public class LinkedListTests
    {
        private LinkedList<int> CreateList()
        {
            return new LinkedList<int>(0, 1, 2);
        }

        [Test]
        public void Constructor_NullArray_DoesNotThrow()
        {
            Assert.DoesNotThrow(() => new LinkedList<int>());
        }

        [Test]
        public void Constructor_ValidArray_AddsInOrder()
        {
            var actual = new LinkedList<int>(0, 1, 2);

            for(var expected = 0; expected < 3; ++expected)
            {
                Assert.AreEqual(expected, actual[expected]);
            }
        }

        [TestCase(-1)]
        [TestCase(3)]
        public void Subscript_InvalidIndex_ThrowsIndexOutOfRange(int index)
        {
            var list = CreateList();

            int act()
            {
                return list[index];
            }

            Assert.Throws<IndexOutOfRangeException>(() => act());
        }

        [TestCase(0)]
        [TestCase(1)]
        [TestCase(2)]
        public void Subscript_ValidIndex_ReturnsExpected(int index)
        {
            var list = CreateList();

            var actual = list[index];

            Assert.AreEqual(index, actual);
        }

        [TestCase(-1)]
        [TestCase(3)]
        public void SubscriptSet_InvalidIndex_ThrowsIndexOutOfRange(int index)
        {
            var list = CreateList();
            Assert.Throws<IndexOutOfRangeException>(() => list[index] = 0);
        }

        [TestCase(new int[] { 0 })]
        [TestCase(new int[] { 0, 1 })]
        [TestCase(new int[] { 0, 1, 2 })]
        public void Add_ValidInput_SetsHead(int[] input)
        {
            var list = new LinkedList<int>();
            var expected = input[0];

            foreach(var value in input)
            {
                list.Add(value);
            }

            Assert.AreEqual(expected, list.Head.Value);
        }

        [TestCase(new int[] { 0 })]
        [TestCase(new int[] { 0, 1 })]
        [TestCase(new int[] { 0, 1, 2 })]
        public void Add_ValidInput_SetsTail(int[] input)
        {
            var list = new LinkedList<int>();

            foreach (var value in input)
            {
                list.Add(value);
                Assert.AreEqual(value, list.Tail.Value);
            }
        }

        [TestCase(new int[] { 0 })]
        [TestCase(new int[] { 0, 1 })]
        [TestCase(new int[] { 0, 1, 2 })]
        public void Add_ValidInput_IncrementCount(int[] input)
        {
            var list = new LinkedList<int>();

            foreach (var value in input)
            {
                list.Add(value);
                Assert.AreEqual(value + 1, list.Count);
            }
        }

        [Test]
        public void Remove_NullHead_ThrowsInvalidOperation()
        {
            var list = new LinkedList<int>();
            Assert.Throws<InvalidOperationException>(() => list.Remove(0));
        }

        [Test]
        public void Remove_Head_SetsHead()
        {
            var list = CreateList();

            list.Remove(0);

            Assert.AreEqual(1, list.Head.Value);
        }

        [Test]
        public void Remove_Tail_SetsTail()
        {
            var list = CreateList();

            list.Remove(2);

            Assert.AreEqual(1, list.Tail.Value);
        }

        [TestCase(new int[] { 0 })]
        [TestCase(new int[] { 0, 1 })]
        [TestCase(new int[] { 0, 1, 2 })]
        public void Remove_ValidInput_DecrementCount(int[] input)
        {
            var list = new LinkedList<int>(input);

            foreach(var value in input)
            {
                list.Remove(value);
                Assert.AreEqual(input.Length - 1 - value, list.Count);
            }
        }

        [TestCase(-1)]
        [TestCase(3)]
        public void RemoveAt_InvalidIndex_ThrowsIndexOutOfRange(int index)
        {
            var list = CreateList();
            Assert.Throws<IndexOutOfRangeException>(() => list.RemoveAt(index));
        }

        [Test]
        public void RemoveAt_Head_SetsHead()
        {
            var list = CreateList();

            list.RemoveAt(0);

            Assert.AreEqual(1, list.Head.Value);
        }

        [Test]
        public void RemoveAt_Tail_SetsTail()
        {
            var list = CreateList();

            list.RemoveAt(2);

            Assert.AreEqual(1, list.Tail.Value);
        }

        [Test]
        public void Foreach_ValidList_ReturnsInOrder()
        {
            var list = CreateList();
            var expected = 0;

            foreach (var value in list)
            {
                Assert.AreEqual(expected, value);
                expected++;
            }
        }
    }
}
