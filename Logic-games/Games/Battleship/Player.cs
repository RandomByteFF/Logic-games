using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Logic_games.Properties;
using Logic_games.Games.Battleship;

namespace Logic_games.Games.Battleship
{
    class Player
    {
        public List<List<Ship>> inventory = new List<List<Ship>>();
        public int[,] player = new int[10, 10], map = new int[10, 10];
        private TableLayoutPanel playerPanel, opponentPanel;
        public string name;

        public Player(string n) { name = n; }
        public Player() { name = "You"; }
    }
}
