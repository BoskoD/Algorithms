namespace Search2DMatrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[][] matrix = new int[][]
            {
                new int[]{1,3,5,7},
                new int[]{10,13,16,20},
                new int[]{23,26,30,40}
            };
            int target = 3;

            bool matrixContainTarget = MatrixSearch(matrix, target);
            Console.WriteLine($"{target} is present in the matrix: {matrixContainTarget}");
        }

        public static bool MatrixSearch(int[][] matrix, int target)
        {
            int ROWS = matrix.Length;
            int COLS = matrix[0].Length;

            int top = 0;
            int bottom = ROWS - 1;

            int row = 0;

            while (top <= bottom)
            {
                row = (top + bottom) / 2;
                if (target > matrix[row][COLS - 1]) top = row + 1;
                else if (target < matrix[row][0]) bottom = row - 1;
                else break;
            }

            if (top > bottom) return false;

            int left = 0;
            int right = COLS - 1;
            while (left <= right)
            {
                int mid = (left + right) / 2;
                if (target > matrix[row][mid]) left = mid + 1;
                else if (target < matrix[row][mid]) right = mid - 1;
                else return true;
            }
            return false;
        }
    }
}