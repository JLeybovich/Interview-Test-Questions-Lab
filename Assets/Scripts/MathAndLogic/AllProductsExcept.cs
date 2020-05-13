using System;

namespace InterviewQuestions.MathAndLogic
{
    public static partial class MathExtensions
    {
        public static int[] GetProductsOfAllIntsExceptAtIndex(int[] intArray)
        {
            if (intArray.Length < 2)
            {
                throw new ArgumentException(
                    "Getting the product of numbers at other indices requires at least 2 numbers",
                    nameof(intArray));
            }

            // We make an array with the length of the input array to
            // hold our products
            int[] productsOfAllIntsExceptAtIndex = new int[intArray.Length];

            // For each integer, we find the product of all the integers
            // before it, storing the total product so far each time
            int productSoFar = 1;
            for (int i = 0; i < intArray.Length; i++)
            {
                productsOfAllIntsExceptAtIndex[i] = productSoFar;
                productSoFar *= intArray[i];
            }

            // For each integer, we find the product of all the integers
            // after it. since each index in products already has the
            // product of all the integers before it, now we're storing
            // the total product of all other integers
            productSoFar = 1;
            for (int i = intArray.Length - 1; i >= 0; i--)
            {
                productsOfAllIntsExceptAtIndex[i] *= productSoFar;
                productSoFar *= intArray[i];
            }

            return productsOfAllIntsExceptAtIndex;
        }
    }
}