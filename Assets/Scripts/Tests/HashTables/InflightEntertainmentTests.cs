using NUnit.Framework;

namespace InterviewQuestions.HashTables
{
    public class InflightEntertainmentTests
    {
        [Test]
        public void ShortFlightTest()
        {
            var result = HashTableExtensions.CanTwoMoviesFillFlight(new int[] { 2, 4 }, 1);
            Assert.False(result);
        }

        [Test]
        public void LongFlightTest()
        {
            var result = HashTableExtensions.CanTwoMoviesFillFlight(new int[] { 2, 4 }, 6);
            Assert.True(result);
        }

        [Test]
        public void OnlyOneMovieHalfFlightLenghtTest()
        {
            var result = HashTableExtensions.CanTwoMoviesFillFlight(new int[] { 3, 8 }, 6);
            Assert.False(result);
        }

        [Test]
        public void TwoMoviesHalfFlightLengthTest()
        {
            var result = HashTableExtensions.CanTwoMoviesFillFlight(new int[] { 3, 8, 3 }, 6);
            Assert.True(result);
        }

        [Test]
        public void LotsOfPossiblePairsTest()
        {
            var result = HashTableExtensions.CanTwoMoviesFillFlight(new int[] { 1, 2, 3, 4, 5, 6 }, 7);
            Assert.True(result);
        }

        [Test]
        public void NotUsingFirstMovieTest()
        {
            var result = HashTableExtensions.CanTwoMoviesFillFlight(new int[] { 4, 3, 2 }, 5);
            Assert.True(result);
        }

        [Test]
        public void OneMovieTest()
        {
            var result = HashTableExtensions.CanTwoMoviesFillFlight(new int[] { 6 }, 6);
            Assert.False(result);
        }

        [Test]
        public void NoMoviesTest()
        {
            var result = HashTableExtensions.CanTwoMoviesFillFlight(new int[] { }, 6);
            Assert.False(result);
        }
    }
}