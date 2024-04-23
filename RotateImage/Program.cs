namespace RotateImage
{
    internal class Program // Array, Math, Matrix
    {
        static void Main(string[] args)
        {
            int[][] matrix =
            [
                [1,2,3],
                [4,5,6],
                [7,8,9]
            ];

            RotateMatrix(matrix);

            for (int i = 0; i < matrix.Length; i++)
            {
                for (int j = 0; j < matrix[i].Length; j++)
                {
                    Console.Write(matrix[i][j] + " ");
                }
            }
        }

        private static void RotateMatrix(int[][] matrix)
        {
            TransposeMatrix(matrix);
            RotateRows(matrix);
        }

        private static void TransposeMatrix(int[][] matrix)
        {
            int n = matrix.Length;

            for (int i = 0; i < n; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    (matrix[j][i], matrix[i][j]) = (matrix[i][j], matrix[j][i]);
                }
            }
        }

        private static void RotateRows(int[][] matrix)
        {
            int n = matrix.Length;
            for (int i = 0; i < n; i++)
            {
                Array.Reverse(matrix[i]);
            }
        }
    }
}
