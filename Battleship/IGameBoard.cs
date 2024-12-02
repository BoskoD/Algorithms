namespace Battleship
{
    internal interface IGameBoard
    {
        string Attack(int x, int y);
        bool AllShipsSunk();
    }
}
