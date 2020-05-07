using System;

namespace InterviewQuestions.MathAndLogic
{
    public static partial class MathExtensions
    {
        public static int HighestProductOf3(int[] arrayOfInts)
        {
            if (arrayOfInts.Length < 3)
            {
                throw new ArgumentException("Less than 3 items!", nameof(arrayOfInts));
            }

            // We're going to start at the 3rd item (at index 2)
            // so pre-populate highests and lowests based on the first 2 items.
            // We could also start these as null and check below if they're set
            // but this is arguably cleaner
            int highest = Math.Max(arrayOfInts[0], arrayOfInts[1]);
            int lowest = Math.Min(arrayOfInts[0], arrayOfInts[1]);

            int highestProductOf2 = arrayOfInts[0] * arrayOfInts[1];
            int lowestProductOf2 = arrayOfInts[0] * arrayOfInts[1];

            // Except this one--we pre-populate it for the first *3* items.
            // This means in our first pass it'll check against itself, which is fine.
            int highestProductOf3 = arrayOfInts[0] * arrayOfInts[1] * arrayOfInts[2];

            // Walk through items, starting at index 2
            for (int i = 2; i < arrayOfInts.Length; i++)
            {
                int current = arrayOfInts[i];

                // Do we have a new highest product of 3?
                // It's either the current highest,
                // or the current times the highest product of two
                // or the current times the lowest product of two
                highestProductOf3 = Math.Max(Math.Max(
                    highestProductOf3,
                    current * highestProductOf2),
                    current * lowestProductOf2);

                // Do we have a new highest product of two?
                highestProductOf2 = Math.Max(Math.Max(
                    highestProductOf2,
                    current * highest),
                    current * lowest);

                // Do we have a new lowest product of two?
                lowestProductOf2 = Math.Min(Math.Min(
                    lowestProductOf2,
                    current * highest),
                    current * lowest);

                // Do we have a new highest?
                highest = Math.Max(highest, current);

                // Do we have a new lowest?
                lowest = Math.Min(lowest, current);
            }

            return highestProductOf3;
        }
    }
}