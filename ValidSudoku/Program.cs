namespace ValidSudoku
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[,] matrix = new char[,]
            {
                {'5', '3', '.', '.', '7', '.', '.', '.', '.'},
                {'6', '.', '.', '1', '9', '5', '.', '.', '.'},
                {'.', '9', '8', '.', '.', '.', '.', '6', '.'},
                {'8', '.', '.', '.', '6', '.', '.', '.', '3'},
                {'4', '.', '.', '8', '.', '3', '.', '.', '1'},
                {'7', '.', '.', '.', '2', '.', '.', '.', '6'},
                {'.', '6', '.', '.', '.', '.', '2', '8', '.'},
                {'.', '.', '.', '4', '1', '9', '.', '.', '5'},
                {'.', '.', '.', '.', '8', '.', '.', '7', '9'}
            };

            bool isValidSudoku = IsValidSudoku(matrix);
            Console.WriteLine($"Sudoku is valid: {isValidSudoku}");
        }

        public static bool IsValidSudoku(char[,] matrix)
        {
            var rows = new Dictionary<int,HashSet<char>>();
            var cols = new Dictionary<int,HashSet<char>>();
            var boxes = new Dictionary<(int,int),  HashSet<char>>();

            for (int r = 0; r < 9; r++)
            {
                rows[r] = [];
                for(int c = 0; c < 9; c++)
                {
                    if (!cols.TryGetValue(c, out HashSet<char>? value))
                    {
                        value = [];
                        cols[c] = value;
                    }
                    if (!boxes.ContainsKey((r/3, c/3)))
                    {
                        boxes[(r/3, c/3)] = [];
                    } 
                    if (matrix[r, c] == '.')
                    {
                        continue;
                    }
                    if (rows[r].Contains(matrix[r, c]) ||
                        value.Contains(matrix[r, c]) || 
                        boxes[(r / 3, c / 3)].Contains(matrix[r, c]))
                    {
                        return false;
                    }
                    _ = rows[r].Add(matrix[r, c]);
                    _ = value.Add(matrix[r, c]);
                    _ = boxes[(r / 3, c / 3)].Add(matrix[r, c]);
                }
            }
            return true;
        }
    }
}
