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
        public List<List<Ship>> inventory = new List<List<Ship>>(), sunk=new List<List<Ship>>();
        public int[,] player = new int[10, 10], map = new int[10, 10];
        public string name;

        public Player(string n) { name = n; }
        public Player() { name = "You"; }

        public Ship FindByID(int id) 
        {
            int i = 0;
            while (i < inventory.Count) 
            {
                int j = 0;
                while (j < inventory[i].Count && inventory[i][j].ID!=id) 
                {
                    j++;
                }
                if (j < inventory[i].Count&& inventory[i][j].ID == id)
                {
                    return inventory[i][j];
                }
                i++;
            }
            return null; 
        }

        public void Clear() 
        {
            inventory.Clear();
            sunk.Clear();
            map = new int[10, 10];
            player = new int[10, 10];
        }
    }
}
