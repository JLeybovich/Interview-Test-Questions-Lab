using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using NUnit.Framework;

namespace InterviewQuestions.ArraysAndStrings.Tests
{
    public class MergeArraysTests
    {
        [Test]
        public void BothArraysAreEmptyTest()
        {
            var myArray = new int[] { };
            var alicesArray = new int[] { };
            var expected = new int[] { };
            var actual = ArrayExtensions.MergeArrays(myArray, alicesArray);
            Assert.AreEqual(expected, actual);
            actual = ArrayExtensions.MergeArraysMine(myArray, alicesArray);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void FirstArrayIsEmptyTest()
        {
            var myArray = new int[] { };
            var alicesArray = new int[] { 1, 2, 3 };
            var expected = new int[] { 1, 2, 3 };
            var actual = ArrayExtensions.MergeArrays(myArray, alicesArray);
            Assert.AreEqual(expected, actual);
            actual = ArrayExtensions.MergeArraysMine(myArray, alicesArray);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void SecondArrayIsEmptyTest()
        {
            var myArray = new int[] { 5, 6, 7 };
            var alicesArray = new int[] { };
            var expected = new int[] { 5, 6, 7 };
            var actual = ArrayExtensions.MergeArrays(myArray, alicesArray);
            Assert.AreEqual(expected, actual);
            actual = ArrayExtensions.MergeArraysMine(myArray, alicesArray);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void BothArraysHaveSomeNumbersTest()
        {
            var myArray = new int[] { 2, 4, 6 };
            var alicesArray = new int[] { 1, 3, 7 };
            var expected = new int[] { 1, 2, 3, 4, 6, 7 };
            var actual = ArrayExtensions.MergeArrays(myArray, alicesArray);
            Assert.AreEqual(expected, actual);
            actual = ArrayExtensions.MergeArraysMine(myArray, alicesArray);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void ArraysAreDifferentLengthsTest()
        {
            var myArray = new int[] { 2, 4, 6, 8 };
            var alicesArray = new int[] { 1, 7 };
            var expected = new int[] { 1, 2, 4, 6, 7, 8 };
            var actual = ArrayExtensions.MergeArrays(myArray, alicesArray);
            Assert.AreEqual(expected, actual);
            actual = ArrayExtensions.MergeArraysMine(myArray, alicesArray);
            Assert.AreEqual(expected, actual);
        }
    }
}