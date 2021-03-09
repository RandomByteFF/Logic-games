using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Logic_games.Properties;
using Logic_games.Games.Battleship;

namespace Logic_games.Games.Battleship
{
    class Bot: Player
    {
        //Most mindent örököl a playertől
        private List<int> even=new List<int>(), odd = new List<int>();
        private bool oddMethod = false, previousHit = false;
        private int[] lastHit=new int[2];
        private int dir = -1;
        private Random r = new Random();
        
        public Bot() 
        {
            phase1 Pb = new phase1(player);
            inventory = Pb.ShipsToInventory(true);
            Random r = new Random();
            foreach (List<Ship> ships in inventory)
            {
                foreach (Ship s in ships)
                {
                    int x=r.Next(1, 11), y= r.Next(1, 11);
                    while (!Pb.Placeable(new int[] { x, y }, s)) 
                    {
                        x = r.Next(1, 11);
                        y = r.Next(1, 11);
                    }
                    s.X = x;
                    s.Y = y;
                    s.placeShip(player);
                }   
            }

            for (int i = 0; i < 50; i++)
            {
                odd.Add(i);
                even.Add(i + 1);
            }
        }

        public void Guess() //Ez lesz amivel folytatni fogom
        {
            if (previousHit)
            {

            }
            else 
            {
                if (oddMethod) 
                {
                    getNum(odd);
                    oddMethod = false;
                }
                else 
                {
                    getNum(even);
                    oddMethod = true;
                }
            }

            int[] getNum(List<int> nums)
            {
                int index = r.Next(0, nums.Count),
                n = nums[index];
                nums.RemoveAt(index);
                int y = n % 10, x = (n - y) % 10;
                return new int[] {x, y};
            }
        }
    }
}
