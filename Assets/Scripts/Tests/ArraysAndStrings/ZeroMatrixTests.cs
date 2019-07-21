using NUnit.Framework;

namespace InterviewQuestions.ArraysAndStrings.Tests
{
    public class ZeroMatrixTests
    {
        private readonly int[][] OneByTwo =
        {
            new int[] { 0, 1 }
        };

        private readonly int[][] OneByTwoZeroed =
        {
            new int[] { 0, 0 }
        };

        private readonly int[][] TwoByTwo =
        {
            new int[] { 0, 1 },
            new int[] { 1, 0 }
        };

        private readonly int[][] TwoByTwoZeroed =
        {
            new int[] { 0, 0 },
            new int[] { 0, 0 }
        };

        private readonly int[][] ThreeByTwo =
        {
            new int[] { 0, 1 },
            new int[] { 3, 0 },
            new int[] { 6, 7 }
        };

        private readonly int[][] ThreeByTwoZeroed =
        {
            new int[] { 0, 0 },
            new int[] { 0, 0 },
            new int[] { 0, 0 }
        };

        private readonly int[][] ThreeByThree =
        {
            new int[] { 6, 3, 4 },
            new int[] { 7, 0, 1 },
            new int[] { 8, 5, 2 }
        };

        private readonly int[][] ThreeByThreeZeroed =
        {
            new int[] { 6, 0, 4 },
            new int[] { 0, 0, 0 },
            new int[] { 8, 0, 2 }
        };

        private readonly int[][] FourByFour =
        {
            new int[] { 0,  8,  4, 12 },
            new int[] { 13, 9,  5, 1  },
            new int[] { 14, 10, 0, 2  },
            new int[] { 15, 11, 7, 3  }
        };

        private readonly int[][] FourByFourZeroed =
        {
            new int[] { 0, 0,  0, 0 },
            new int[] { 0, 9,  0, 1 },
            new int[] { 0, 0,  0, 0 },
            new int[] { 0, 11, 0, 3 }
        };

        private readonly int[][] ThreeByFour =
        {
            new int[] { 0,  1,  2,  3  },
            new int[] { 4,  5,  6,  7  },
            new int[] { 8,  9,  0,  11 }
        };

        private readonly int[][] ThreeByFourZeroed =
        {
            new int[] { 0,  0,  0,  0 },
            new int[] { 0,  5,  0,  7 },
            new int[] { 0,  0,  0,  0 }
        };

        private readonly int[][] FiveByFive =
        {
            new int[] { 11, 1,  2,  3,  4  },
            new int[] { 5,  6,  7,  8,  9  },
            new int[] { 10, 11, 12, 13, 14 },
            new int[] { 15, 16, 17, 18, 19 },
            new int[] { 20, 21, 22, 23, 24 }
        };

        private readonly int[][] FiveByFiveZeroed =
        {
            new int[] { 11, 1,  2,  3,  4  },
            new int[] { 5,  6,  7,  8,  9  },
            new int[] { 10, 11, 12, 13, 14 },
            new int[] { 15, 16, 17, 18, 19 },
            new int[] { 20, 21, 22, 23, 24 }
        };


        [Test]
        public void Zero_OneByTwo_ZeroedMatrix()
        {
            var actual = ArrayExtensions.Zero(OneByTwo);
            Assert.AreEqual(OneByTwoZeroed, actual);
        }

        [Test]
        public void Zero_TwoByTwo_ZeroedMatrix()
        {
            var actual = ArrayExtensions.Zero(TwoByTwo);
            Assert.AreEqual(TwoByTwoZeroed, actual);
        }

        [Test]
        public void Zero_ThreeByTwo_ZeroedMatrix()
        {
            var actual = ArrayExtensions.Zero(ThreeByTwo);
            Assert.AreEqual(ThreeByTwoZeroed, actual);
        }

        [Test]
        public void Zero_ThreeByThree_ZeroedMatrix()
        {
            var actual = ArrayExtensions.Zero(ThreeByThree);
            Assert.AreEqual(ThreeByThreeZeroed, actual);
        }

        [Test]
        public void Zero_FourByFour_ZeroedMatrix()
        {
            var actual = ArrayExtensions.Zero(FourByFour);
            Assert.AreEqual(FourByFourZeroed, actual);
        }

        [Test]
        public void Zero_ThreeByFour_ZeroedMatrix()
        {
            var actual = ArrayExtensions.Zero(ThreeByFour);
            Assert.AreEqual(ThreeByFourZeroed, actual);
        }

        [Test]
        public void Zero_FiveByFive_ZeroedMatrix()
        {
            var actual = ArrayExtensions.Zero(FiveByFive);
            Assert.AreEqual(FiveByFiveZeroed, actual);
        }
    }
}
