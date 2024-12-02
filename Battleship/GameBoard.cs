namespace Battleship
{
    /*
     * Here is the Battleship ground MxN and the set of ships. The ship is a collection of coordinates. 
     * It might contain any number of coordinates (any number of parts of any shapes). 
     * The task is for a set (x, y) return “missed” if there is no ship on ground, 
     *                                     “hit” if there is a ship, 
     *                                     “hit again” if there is a square of ship already hit, 
     *                                     “sink SHIP” if there is a last last square of ship named SHIP (unique for each ship).
     */

    public class GameBoard : IGameBoard
    {
        private readonly Dictionary<string, HashSet<(int, int)>> _shipParts = [];
        private readonly Dictionary<(int, int), string> _ships = [];
        private readonly HashSet<(int, int)> _hits = [];

        public GameBoard(List<Ship> ships) 
        {
            foreach (Ship ship in ships)
            { 
                this._shipParts[ship.Name] = new HashSet<(int, int)>(ship.Coordinates); 
                foreach (var coordinate in ship.Coordinates) 
                { 
                    this._ships[coordinate] = ship.Name; 
                } 
            } 
        }

        public string Attack(int x, int y) 
        { 
            if (!this._ships.ContainsKey((x, y))) 
            { 
                return "missed"; 
            } 
            string shipName = this._ships[(x, y)]; 
            
            if (this._hits.Contains((x, y))) 
            { 
                return "hit again"; 
            }
            _ = this._hits.Add((x, y));
            _ = this._shipParts[shipName].Remove((x, y));

            // Here we check if the ship has been sunk
            if (this._shipParts[shipName].Count == 0) 
            { 
                foreach (var part in this._hits) 
                { 
                    if (this._ships.ContainsKey(part) && this._ships[part] == shipName) 
                    { 
                        this._ships.Remove(part); 
                    } 
                } 
                return $"sink {shipName}"; 
            }
            return "hit"; 
        }

        public bool AllShipsSunk() 
        {
            return !this._ships.Any();
        }
    }
}
