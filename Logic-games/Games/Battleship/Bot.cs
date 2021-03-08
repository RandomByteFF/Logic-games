using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Logic_games.Properties;
using Logic_games.Games.Battleship;

namespace Logic_games.Games.Battleship
{
    class Bot
    {
        public List<List<Ship>> inventory = new List<List<Ship>>();
        public int[,] bot = new int[10, 10], map = new int[10, 10];
        public Bot() 
        {
            phase1 Pb = new phase1(bot);
            inventory = Pb.ShipsToInventory(true);
            Random r = new Random();
            foreach (List<Ship> ships in inventory)
            {
                foreach (Ship s in ships)
                {
                    int x=r.Next(0, 11), y= r.Next(0, 11);
                    while (!Pb.Placeable(new int[] { x, y }, s.direction, s)) 
                    {
                        x = r.Next(0, 10);
                        y = r.Next(0, 10);
                    }
                    s.X = x;
                    s.Y = y;
                    s.placeShip(bot);
                }
            }
        }

        public void Guess() //Ez lesz amivel folytatni fogom
        { 
        
        }
    }
}
