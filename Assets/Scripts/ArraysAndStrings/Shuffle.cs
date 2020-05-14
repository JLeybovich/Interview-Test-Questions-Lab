using UnityEngine;

namespace InterviewQuestions.ArraysAndStrings
{
    public static partial class ArrayExtensions
    {
        public static void Shuffle(int[] array)
        {
            // If it's 1 or 0 items, just return
            if (array.Length <= 1)
            {
                return;
            }

            // Walk through from beginning to end
            for (int indexWeAreChoosingFor = 0;
                    indexWeAreChoosingFor < array.Length - 1; indexWeAreChoosingFor++)
            {
                // Choose a random not-yet-placed item to place there
                // (could also be the item currently in that spot).
                // Must be an item AFTER the current item, because the stuff
                // before has all already been placed
                int randomChoiceIndex = Random.Range(indexWeAreChoosingFor, array.Length);

                // Place our random choice in the spot by swapping
                if (randomChoiceIndex != indexWeAreChoosingFor)
                {
                    int valueAtIndexWeChoseFor = array[indexWeAreChoosingFor];
                    array[indexWeAreChoosingFor] = array[randomChoiceIndex];
                    array[randomChoiceIndex] = valueAtIndexWeChoseFor;
                }
            }
        }
    }
}