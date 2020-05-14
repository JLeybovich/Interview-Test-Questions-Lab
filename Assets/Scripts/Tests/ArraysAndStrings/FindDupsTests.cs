using NUnit.Framework;

namespace InterviewQuestions.ArraysAndStrings.Tests
{
    public class FindDupsTests
    {
        [Test]
        public void JustTheRepeatedNumberTest()
        {
            var numbers = new int[] { 1, 1 };
            var expected = 1;
            var actual = ArrayExtensions.FindRepeat(numbers);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void ShortArrayTest()
        {
            var numbers = new int[] { 1, 2, 3, 2 };
            var expected = 2;
            var actual = ArrayExtensions.FindRepeat(numbers);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void MediumArrayTest()
        {
            var numbers = new int[] { 1, 2, 5, 5, 5, 5 };
            var expected = 5;
            var actual = ArrayExtensions.FindRepeat(numbers);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void LongArrayTest()
        {
            var numbers = new int[] { 4, 1, 4, 8, 3, 2, 7, 6, 5 };
            var expected = 4;
            var actual = ArrayExtensions.FindRepeat(numbers);
            Assert.AreEqual(expected, actual);
        }
    }
}