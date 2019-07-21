namespace InterviewQuestions.ArraysAndStrings
{
    public static partial class ArrayExtensions
    {
        public static int[][] Rotate(int[][] matrix)
        {
            if (matrix.Length == 0 || matrix.Length != matrix[0].Length)
            {
                return matrix;
            }

            int n = matrix.Length;
            int halfLength = n / 2;

            for(int layer = 0; layer < halfLength; ++layer)
            {
                int first = layer;
                int last = n - 1 - layer;

                for(int i = first; i < last; ++i)
                {
                    int offset = i - first;
                    int top = matrix[first][i];

                    // left -> top 
                    // [0, 0] = [n - 1, 0]
                    matrix[first][i] = matrix[last - offset][first];

                    // bottom -> left
                    // [n - 1, 0] = [n - 1, n - 1]
                    matrix[last - offset][first] = matrix[last][last - offset];

                    // right -> bottom
                    // [n - 1, n - 1] = [0, n - 1]
                    matrix[last][last - offset] = matrix[i][last];

                    // top -> right
                    // [0, n - 1] = top
                    matrix[i][last] = top;
                }
            }

            return matrix;
        }
    }
}
