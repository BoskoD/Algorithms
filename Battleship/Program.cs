namespace Battleship
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var ships = new List<Ship> 
            { 
                new Ship("A", new List<(int, int)> { (1, 1), (1, 2) }), 
                new Ship("B", new List<(int, int)> { (2, 2) }), 
            }; 
            
            IGameBoard gameBoard = new GameBoard(ships); 
            Console.WriteLine("Welcome to Battleship!"); 
            Console.WriteLine("Enter coordinates to attack in the format 'x y' (e.g., '1 1'). Enter 'q' to quit.");

            while (!gameBoard.AllShipsSunk())
            {
                Console.Write("Enter coordinates (or 'q' to quit): ");
                var input = Console.ReadLine()?.Trim();

                if (string.Equals(input, "q", StringComparison.OrdinalIgnoreCase))
                {
                    break;
                }

                if (TryParseCoordinates(input, out int x, out int y))
                {
                    string result = gameBoard.Attack(x, y);
                    Console.WriteLine(result);

                    if (gameBoard.AllShipsSunk())
                    {
                        Console.WriteLine("Congratulations! All ships have been sunk.");
                        break;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter coordinates in the format 'x y'.");
                }
            }

            Console.WriteLine("Game over. Thanks for playing!");

            static bool TryParseCoordinates(string? input, out int x, out int y)
            {
                x = y = 0; 
                if (string.IsNullOrWhiteSpace(input))
                {
                    return false;
                }

                string[] parts = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                return parts.Length == 2
                       && int.TryParse(parts[0], out x)
                       && int.TryParse(parts[1], out y);
            }
        }
    }
}
