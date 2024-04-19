namespace FindAWinnerOnATicTacToeGame
{
    internal class Program // Array, HashTable, Matrix
    {
        static void Main(string[] args)
        {
            // x |   |
            // ---------
            //   | x |
            // ---------
            // o | o | x

            var moves1 = new int[][] {
            new int[] {0, 0},
            new int[] {2, 0},
            new int[] {1, 1},
            new int[] {2, 1},
            new int[] {2, 2}};

            var winner = FindWinnerOfTicTacToe(moves1);
            Console.WriteLine($"Winner of a tic tac toe is: {winner}");
        }

        private static string FindWinnerOfTicTacToe(int[][] moves)
        {
            // 0,1,2
            // 3,4,5
            // 6,7,8

            int [][] winCombinations = new int[][]
            {
                [0,1,2], [3,4,5], [6,7,8], // horizontal
                [0,4,8], [2,4,6],          // diagonal
                [0,3,6], [1,4,7], [2,5,8], // vertical
            };

            if(moves.Length < 5) { return "Pending"; }

            int[] x = new int[9];
            int[] o = new int[9];
            bool xMove = true;

            foreach (var move in moves)
            {
                for (int i = 0; i < 3; i++)
                {
                    int index = move[0] + (move[1] * 3);
                    if (xMove)
                    {
                        x[index] = 1;
                    }
                    else
                    {
                        o[index] = 1;
                    }
                    xMove = !xMove;
                }
            }

            foreach (var combination in winCombinations)
            {
                if (combination.All(i => x[i] == 1)) return "A";
                if (combination.All(i => o[i] == 1)) return "B";
            }

            return winCombinations.Length == 9 ? "Draw" : "Pending";
        }
    }
}
