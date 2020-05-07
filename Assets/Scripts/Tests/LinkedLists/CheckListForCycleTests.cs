using NUnit.Framework;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace InterviewQuestions.LinkedLists.Tests
{
    public class CheckListForCycleTests
    {
        [Test]
        public void LinkedListWithNoCycleTest()
        {
            var nodes = LinkedListExtensions.ValuesToLinkedListNodes(new int[] { 1, 2, 3, 4 });
            var result = LinkedListExtensions.ContainsCycle(nodes[0]);
            Assert.False(result);
        }

        [Test]
        public void CycleLoopsToBeginningTest()
        {
            var nodes = LinkedListExtensions.ValuesToLinkedListNodes(new int[] { 1, 2, 3, 4 });
            nodes[3].Next = nodes[0];
            var result = LinkedListExtensions.ContainsCycle(nodes[0]);
            Assert.True(result);
        }

        [Test]
        public void CycleLoopsToMiddleTest()
        {
            var nodes = LinkedListExtensions.ValuesToLinkedListNodes(new int[] { 1, 2, 3, 4, 5 });
            nodes[4].Next = nodes[2];
            var result = LinkedListExtensions.ContainsCycle(nodes[0]);
            Assert.True(result);
        }

        [Test]
        public void TwoNodeCycleAtEndTest()
        {
            var nodes = LinkedListExtensions.ValuesToLinkedListNodes(new int[] { 1, 2, 3, 4, 5 });
            nodes[4].Next = nodes[3];
            var result = LinkedListExtensions.ContainsCycle(nodes[0]);
            Assert.True(result);
        }

        [Test]
        public void EmptyListTest()
        {
            var result = LinkedListExtensions.ContainsCycle<int>(null);
            Assert.False(result);
        }

        [Test]
        public void OneElementLinkedListNoCycleTest()
        {
            var node = new LinkedListNode<int>(1);
            var result = LinkedListExtensions.ContainsCycle(node);
            Assert.False(result);
        }

        [Test]
        public void OneElementLinkedListCycleTest()
        {
            var node = new LinkedListNode<int>(1);
            node.Next = node;
            var result = LinkedListExtensions.ContainsCycle(node);
            Assert.True(result);
        }
    }
}