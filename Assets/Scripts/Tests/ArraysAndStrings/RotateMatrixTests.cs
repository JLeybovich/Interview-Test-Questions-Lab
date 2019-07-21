using NUnit.Framework;

namespace InterviewQuestions.ArraysAndStrings.Tests
{
    public class RotateMatrixTests
    {
        private readonly int[][] InvalidMatrix = 
        {
            new int[] { 0, 1 }
        };

        private readonly int[][] TwoByTwo =
        {
            new int[] { 0, 1 },
            new int[] { 1, 0 }
        };

        private readonly int[][] TwoByTwoRotated =
        {
            new int[] { 1, 0 },
            new int[] { 0, 1 }
        };

        private readonly int[][] ThreeByThree =
        {
            new int[] { 0, 1, 2 },
            new int[] { 3, 4, 5 },
            new int[] { 6, 7, 8 }
        };

        private readonly int[][] ThreeByThreeRotated =
        {
            new int[] { 6, 3, 0 },
            new int[] { 7, 4, 1 },
            new int[] { 8, 5, 2 }
        };

        private readonly int[][] FourByFour =
        {
            new int[] { 0,  1,  2,  3  },
            new int[] { 4,  5,  6,  7  },
            new int[] { 8,  9,  10, 11 },
            new int[] { 12, 13, 14, 15 }
        };

        private readonly int[][] FourByFourRotated =
        {
            new int[] { 12, 8,  4,  0 },
            new int[] { 13, 9,  5,  1 },
            new int[] { 14, 10, 6,  2 },
            new int[] { 15, 11, 7,  3 }
        };

        private readonly int[][] FiveByFive =
        {
            new int[] { 0,  1,  2,  3,  4  },
            new int[] { 5,  6,  7,  8,  9  },
            new int[] { 10, 11, 12, 13, 14 },
            new int[] { 15, 16, 17, 18, 19 },
            new int[] { 20, 21, 22, 23, 24 }
        };

        private readonly int[][] FiveByFiveRotated =
        {
            new int[] { 20, 15, 10, 5, 0 },
            new int[] { 21, 16, 11, 6, 1 },
            new int[] { 22, 17, 12, 7, 2 },
            new int[] { 23, 18, 13, 8, 3 },
            new int[] { 24, 19, 14, 9, 4 }
        };

        [Test]
        public void Rotate_InvalidMatrix_ReturnsSame()
        {
            var actual = ArrayExtensions.Rotate(InvalidMatrix);
            Assert.AreEqual(InvalidMatrix, actual);
        }

        [Test]
        public void Rotate_TwoByTwo_RotatedMatrix()
        {
            var actual = ArrayExtensions.Rotate(TwoByTwo);
            Assert.AreEqual(TwoByTwoRotated, actual);
        }

        [Test]
        public void Rotate_ThreeByThree_RotatedMatrix()
        {
            var actual = ArrayExtensions.Rotate(ThreeByThree);
            Assert.AreEqual(ThreeByThreeRotated, actual);
        }

        [Test]
        public void Rotate_FourByFour_RotatedMatrix()
        {
            var actual = ArrayExtensions.Rotate(FourByFour);
            Assert.AreEqual(FourByFourRotated, actual);
        }

        [Test]
        public void Rotate_FiveByFive_RotatedMatrix()
        {
            var actual = ArrayExtensions.Rotate(FiveByFive);
            Assert.AreEqual(FiveByFiveRotated, actual);
        }
    }
}