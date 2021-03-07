using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Logic_games.Games.Battleship
{
    public class Ship
    {
        public int size, direction, X, Y, HP;
        public Image[] components;
        public Ship(int siz, Image[] images) 
        {
            size = siz;
            direction = 90;
            HP = siz;
            components = images;
        }
    }
}
