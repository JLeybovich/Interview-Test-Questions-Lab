using NUnit.Framework;

namespace InterviewQuestions.ArraysAndStrings.Tests
{
    public class SquareCountTests
    {
        private readonly int[][] InvalidMatrix =
        {
            new int[] { 0, 1 }
        };

        private readonly int[][] TwoByTwoZero =
        {
            new int[] { 0, 1 },
            new int[] { 1, 0 }
        };

        private readonly int[][] TwoByTwo =
        {
            new int[] { 1, 1 },
            new int[] { 1, 1 }
        };
        private const int TwoByTwoAnswer = 1;

        private readonly int[][] ThreeByThree =
        {
            new int[] { 1, 1, 0 },
            new int[] { 1, 1, 1 },
            new int[] { 0, 1, 1 }
        };
        private const int ThreeByThreeAnswer = 2;

        private readonly int[][] ThreeByThreeZero =
        {
            new int[] { 1, 1, 1 },
            new int[] { 1, 0, 1 },
            new int[] { 1, 1, 0 }
        };

        private readonly int[][] FourByThree =
        {
            new int[] { 1, 1, 1 },
            new int[] { 1, 1, 1 },
            new int[] { 1, 1, 1 },
            new int[] { 1, 1, 1 }
        };
        private const int FourByThreeAnswer = 8;

        private readonly int[][] FourByFour =
        {
            new int[] { 1, 1, 1, 1 },
            new int[] { 1, 0, 0, 1 },
            new int[] { 1, 0, 0, 1 },
            new int[] { 1, 1, 1, 1 }
        };
        private const int FourByFourAnswer = 1;

        [Test]
        public void SquareCount_Null_Zero()
        {
            var actual = ArrayExtensions.SquareCount(null);
            Assert.AreEqual(0, actual);
        }

        [Test]
        public void SquareCount_InvalidMatrix_Zero()
        {
            var actual = ArrayExtensions.SquareCount(InvalidMatrix);
            Assert.AreEqual(0, actual);
        }

        [Test]
        public void SquareCount_TwoByTwoZero_Zero()
        {
            var actual = ArrayExtensions.SquareCount(TwoByTwoZero);
            Assert.AreEqual(0, actual);
        }

        [Test]
        public void SquareCount_TwoByTwo_One()
        {
            var actual = ArrayExtensions.SquareCount(TwoByTwo);
            Assert.AreEqual(TwoByTwoAnswer, actual);
        }

        [Test]
        public void SquareCount_ThreeByThree_Two()
        {
            var actual = ArrayExtensions.SquareCount(ThreeByThree);
            Assert.AreEqual(ThreeByThreeAnswer, actual);
        }

        [Test]
        public void SquareCount_ThreeByThreeZero_Zero()
        {
            var actual = ArrayExtensions.SquareCount(ThreeByThreeZero);
            Assert.AreEqual(0, actual);
        }

        [Test]
        public void SquareCount_FourByThree_Eight()
        {
            var actual = ArrayExtensions.SquareCount(FourByThree);
            Assert.AreEqual(FourByThreeAnswer, actual);
        }

        [Test]
        public void SquareCount_FourByFour_One()
        {
            var actual = ArrayExtensions.SquareCount(FourByFour);
            Assert.AreEqual(FourByFourAnswer, actual);
        }
    }
}
