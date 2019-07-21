using System;

namespace InterviewQuestions.ArraysAndStrings
{
    public static partial class ArrayExtensions
    {
        public static int SquareCount(int[][] matrix)
        {
            if(matrix == null || matrix.Length <= 1)
            {
                return 0;
            }

            int numRows = matrix.Length;
            int numCols = matrix[0].Length;
            int maxSquareSize = Math.Min(numRows, numCols);
            int squareCount = 0;

            for(int squareSize = 1; squareSize <= maxSquareSize; ++squareSize)
            {
                for(int row = 0; row < numRows - squareSize; ++row)
                {
                    int nextRow = row + squareSize;
      
                    for(int col = 0; col < numCols - squareSize; ++col)
                    {
                        int nextCol = col + squareSize;

                        int topLeft = matrix[row][col];
                        if (topLeft != 1) continue;

                        int topRight = matrix[row][nextCol];
                        if (topRight != 1) continue;

                        int bottomLeft = matrix[nextRow][col];
                        if (bottomLeft != 1) continue;

                        int bottomRight = matrix[nextRow][nextCol];
                        if (bottomRight != 1) continue;

                        ++squareCount;
                    }
                }
            }

            return squareCount;
        }
    }
}