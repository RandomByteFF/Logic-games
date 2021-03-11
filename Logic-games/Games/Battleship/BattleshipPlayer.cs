using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Logic_games.Properties;
using Logic_games.Games.Battleship;

namespace Logic_games.Games.Battleship
{
    public class BattleshipPlayer
    {
        public string name;
        public int[,] guesses = new int[10, 10];
        public int[] shipNumbers;
        public BattleshipBoard myBoard;
        /*
         Guess states:
          0 - none
          1 - miss
          2 - hit
         */
        public List<BattleshipShip> myShips = new List<BattleshipShip>(),
                                    sunk = new List<BattleshipShip>();

        public void SunkShip(BattleshipShip s) 
        {
            sunk.Add(s);
        }

        public BattleshipPlayer(string n, int[] shipN) 
        {
            name = n;
            shipNumbers = shipN;
        }
    }
}
