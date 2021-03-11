using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Logic_games.Properties;
using Logic_games.Games.Battleship;

namespace Logic_games.Games.Battleship
{
    public class BattleshipShip
    {
        public List<int[]> positions;
        public int size, hp, direction, id, type;
        public Image[] components;

        public BattleshipShip(int shipType, int shipId) 
        {
            id = shipId;
            direction = 90;
            positions = new List<int[]>();
            type = shipType;
            turn();
        }

        public void dir(int difference) 
        {
            direction += difference;
            if (direction >= 360) { direction = 0; }
            else if (direction < 0) { direction = 270; }
            turn();
        }

        public void turn() 
        {
            string picName = "";
            if (direction == 90) { picName += "L"; }
            else if (direction == 180) { picName += "U"; }
            else if (direction == 270) { picName += "R"; }
            else if (direction == 0) { picName += "D"; }
            switch (type)
            {
                case 0:
                    size = 5;
                    hp = 5;
                    picName += "carrier";
                    break;
                case 1:
                    size = 4;
                    hp = 4;
                    picName += "battleship";
                    break;
                case 2:
                    size = 3;
                    hp = 3;
                    picName += "destroyer";
                    break;
                case 3:
                    size = 3;
                    hp = 3;
                    picName += "submarine";
                    break;
                case 4:
                    size = 2;
                    hp = 2;
                    picName += "patrolBoat";
                    break;
            }
            components = new Image[size];
            for (int i = 0; i < size; i++)
            {
                string getPicture= picName + Convert.ToString(i + 1);
                components[i] = (Bitmap)Resources.ResourceManager.GetObject(getPicture);
            }
        }
    }
}
