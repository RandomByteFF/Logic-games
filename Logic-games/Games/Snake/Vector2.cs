using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic_games.SnakeClasses
{
    //Class for the storing of 2D coordinates
    public class Vector2
    {
        public int x { get; set; }
        public int y { get; set; }
        public int xGrid { get; set; }
        public int yGrid { get; set; }

        public Vector2(int X, int Y, int tileSize)
        {
            this.xGrid = X;
            this.yGrid = Y;
            ConvertToCoordinate(tileSize);
        }

        public Vector2()
        {
            x = 0;
            y = 0;
            xGrid = 0;
            yGrid = 0;
        }

        void ConvertToCoordinate(int tileSize) {
            x = xGrid * tileSize;
            y = yGrid * tileSize;
        }
    }
}
