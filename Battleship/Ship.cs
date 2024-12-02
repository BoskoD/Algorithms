namespace Battleship
{
    public class Ship(string name, List<(int, int)> coordinates)
    {
        public string Name { get; } = name; 
        public List<(int, int)> Coordinates { get; } = coordinates;
    }
}
