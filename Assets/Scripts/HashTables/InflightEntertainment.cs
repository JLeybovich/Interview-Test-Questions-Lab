using System.Collections.Generic;

namespace InterviewQuestions.HashTables
{
    public static partial class HashTableExtensions
    {
        public static bool CanTwoMoviesFillFlight(int[] movieLengths, int flightLength)
        {
            // Movie lengths we've seen so far
            var movieLengthsSeen = new HashSet<int>();

            foreach (var firstMovieLength in movieLengths)
            {
                int matchingSecondMovieLength = flightLength - firstMovieLength;
                if (movieLengthsSeen.Contains(matchingSecondMovieLength))
                {
                    return true;
                }

                movieLengthsSeen.Add(firstMovieLength);
            }

            // We never found a match, so return false
            return false;
        }
    }
}