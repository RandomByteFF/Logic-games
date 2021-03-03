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
        int tileSize;
        public int x { get; set; }
        public int y { get; set; }
        private int xG;
        private int yG;
        public int facing; // 0 - down, 1 - left, 2 - up, 3 - right

        public int xGrid {
            get 
            {
                return xG;
            }

            set 
            {
                xG = value;
                x = value * tileSize;
            }
        }

        public int yGrid
        {
            get
            {
                return yG;
            }

            set
            {
                yG = value;
                y = value * tileSize;
            }
        }

        //The constructor takes the location on the grid, then convert it to coordinates based on the tile size
        public Vector2(int X, int Y, int tileSize) 
        {
            this.xGrid = X;
            this.yGrid = Y;
            this.tileSize = tileSize;
            ConvertToCoordinate(tileSize);
        }

        public Vector2()
        {
            x = 0;
            y = 0;
            xGrid = 0;
            yGrid = 0;
            facing = 0;
        }

        void ConvertToCoordinate(int tileSize) {
            x = xGrid * tileSize;
            y = yGrid * tileSize;
        }

        public static Vector2 operator +(Vector2 a, Vector2 b) {
            Vector2 final = new Vector2(a.xGrid + b.xGrid, a.yGrid + b.yGrid, a.tileSize);
            final.facing = b.facing;
            return final;
        }

        public static Vector2 operator -(Vector2 a, Vector2 b)
        {
            Vector2 final = new Vector2(a.xGrid - b.xGrid, a.yGrid - b.yGrid, a.tileSize);
            final.facing = b.facing;
            return final;
        }

        public static bool operator ==(Vector2 a, Vector2 b)
        {
            return a.x == b.x && a.y == b.y;
        }

        public static bool operator !=(Vector2 a, Vector2 b)
        {
            return !(a.x == b.x && a.y == b.y);
        }

        public static bool Contains(List<Vector2> list, Vector2 a) 
        {
            for (int i = 1; i < list.Count; i++)
            {
                if (a == list[i]) return true;
            }
            return false;
        }

        public static int ContainsAt(List<Vector2> list, Vector2 a)
        {
            for (int i = 1; i < list.Count; i++)
            {
                if (a == list[i]) return i;
            }
            return -1;
        }
    }
}
