namespace InterviewQuestions.ArraysAndStrings
{
    public static partial class ArrayExtensions
    {
        public static int[][] Zero(int[][] matrix)
        {
            bool rowHasZero = RowContains(matrix, 0, 0);
            bool colHasZero = ColumnContains(matrix, 0, 0);

            for(int r = 0; r < matrix.Length; ++r)
            {
                for(int c = 0; c < matrix[0].Length; ++c)
                {
                    if(matrix[r][c] == 0)
                    {
                        matrix[r][0] = 0;
                        matrix[0][c] = 0;
                    }
                }
            }

            for(int r = 1; r < matrix.Length; ++r)
            {
                if(matrix[r][0] == 0)
                {
                    matrix = SetRow(matrix, r, 0);
                }
            }

            for (int c = 1; c < matrix[0].Length; ++c)
            {
                if (matrix[0][c] == 0)
                {
                    matrix = SetColumn(matrix, c, 0);
                }
            }

            if(rowHasZero)
            {
                matrix = SetRow(matrix, 0, 0);
            }

            if(colHasZero)
            {
                matrix = SetColumn(matrix, 0, 0);
            }

            return matrix;
        }

        public static bool RowContains(int[][] matrix, int row, int val)
        {
            for (int c = 0; c < matrix[row].Length; ++c)
            {
                if (matrix[0][c] == val)
                {
                    return true;
                }
            }
            return false;
        }

        public static bool ColumnContains(int[][] matrix, int column, int val)
        {
            for (int r = 0; r < matrix.Length; ++r)
            {
                if (matrix[r][column] == val)
                {
                    return true;
                }
            }
            return false;
        }

        public static int[][] SetRow(int[][] matrix, int row, int val)
        {
            for(int c = 0; c < matrix[row].Length; ++c)
            {
                matrix[row][c] = val;
            }
            return matrix;
        }

        public static int[][] SetColumn(int[][] matrix, int column, int val)
        {
            for (int r = 0; r < matrix.Length; ++r)
            {
                matrix[r][column] = val;
            }
            return matrix;
        }
    }
}
