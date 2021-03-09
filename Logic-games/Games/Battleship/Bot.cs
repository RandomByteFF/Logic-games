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
        private bool oddMethod = false, previousHit = false, first;
        private Random r = new Random();
        private int currentID, Xdir=0, Ydir=0;
        private int[,] roboMAP = new int[10, 10], twoPoints;
        private int[] result, firstPoint = new int[2];
        
        public Bot() 
        {
            name = "BOT";
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
                odd.Add(i*2);
                even.Add(i*2 + 1);
            }
        }

        List<int[]> directions = new List<int[]>();
        List<int[]> shipFound = new List<int[]>();
        public void createDir(int[] c) 
        {
            if (c[0] > 0 && roboMAP[c[0] - 1, c[1]]==0) { directions.Add(new int[] { c[0] - 1, c[1] }); }
            if (c[0] < 9 && roboMAP[c[0] + 1, c[1]]==0) { directions.Add(new int[] { c[0] + 1, c[1] }); }
            if (c[1] > 0 && roboMAP[c[0], c[1]-1]==0) { directions.Add(new int[] { c[0], c[1] - 1 }); }
            if (c[1] < 9 && roboMAP[c[0], c[1]+1]==0) { directions.Add(new int[] { c[0], c[1] + 1 }); }
        }

        public void Response(string r, int id) 
        {
            if (r == "Hit")
            {
                roboMAP[result[0], result[1]] = id;
                if (previousHit && currentID != id)
                {
                    shipFound.Add(new int[] { id, result[0], result[1] });
                }
                else if (currentID == id)
                {
                    Xdir = firstPoint[0] - result[0];
                    Ydir = firstPoint[1] - result[1];
                    if (Xdir != 0)
                    {
                        if (result[0] > firstPoint[0])
                        {
                            twoPoints = new int[,] { { result[0] - Xdir, result[1] }, { firstPoint[0] + Xdir, result[1] } };
                        }
                        else
                        {
                            twoPoints = new int[,] { { result[0] + Xdir, result[1] }, { firstPoint[0] - Xdir, result[1] } };
                        }
                    }
                    else
                    {
                        if (result[1] > firstPoint[1])
                        {
                            twoPoints = new int[,] { { result[0], result[1] + Ydir }, { firstPoint[0], firstPoint[1] - Ydir } };
                        }
                        else
                        {
                            twoPoints = new int[,] { { result[0], result[1] - Ydir }, { firstPoint[0], firstPoint[1] + Ydir } };
                        }
                    }
                }
                else
                {
                    firstPoint = result;
                    previousHit = true;
                }
            }
            else if (r != "Miss")
            {
                roboMAP[result[0], result[1]] = id;
                Sunk();
            }
            else { roboMAP[result[0], result[1]] = -1; }
        }

        public void Sunk() 
        {
            previousHit = false;
            directions.Clear();
            Xdir = 0;
            Ydir = 0;
        }

        public int[] Guess() 
        {
            do
            {
                result = Guesser();
            } while (map[result[0],result[1]]!=0);
            return result;
        }
        private int[] Guesser()
        {
            /*
            if (previousHit) 
            {
                if (Xdir + Ydir == 0 && directions.Count == 0)
                {
                    createDir(firstPoint);
                    int i = r.Next(0, directions.Count);
                    result = directions[i];
                    directions.RemoveAt(i);
                    return result;
                }
                else if (directions.Count > 0)
                {
                    int i = r.Next(0, directions.Count);
                    result = directions[i];
                    directions.RemoveAt(i);
                    return result;
                }
                else 
                {
                    if (first) { result = new int[] { twoPoints[0, 0], twoPoints[0, 1] }; first = false; return result; }
                    else { result = new int[] { twoPoints[1, 0], twoPoints[1, 1] }; return result; }
                }
            }
            else if (shipFound.Count > 0)
            {
                previousHit = true;
                currentID = shipFound[0][0];
                firstPoint = new int[] { shipFound[0][1], shipFound[0][2] };
                shipFound.RemoveAt(0);
                return Guesser();
            }
            else
            {
                */
                if (oddMethod)
                {
                    oddMethod = false;
                    return getNum(odd);
                }
                else
                {
                    oddMethod = true;
                    return getNum(even);
                }
            //}

            int[] getNum(List<int> nums)
            {
                int index = r.Next(0, nums.Count),
                n = nums[index];
                nums.RemoveAt(index);
                int y = n % 10, x = (n - y) / 10;
                return new int[] { x, y };
            }
        }
    }
}
