using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic_games.Games.Battleship
{
    public class BattleshipBot: BattleshipPlayer
    {
        //Most mindent örököl a playertől
        private List<int> even = new List<int>(), odd = new List<int>();
        private bool oddMethod = false;
        private Random rand = new Random();

        public int[] lastHit = new int[2], guess = new int[2];
        public BattleshipBoard botBoard;

        public BattleshipBot(string n, int[] shipNum): base("BOT", new int[] { })
        {
            name = n;
            Random rand = new Random();
            for (int i = 0; i < 50; i++)
            {
                odd.Add(i * 2);
                even.Add(i * 2 + 1);
            }
            int id = 1;
            BattleshipPlacement x = new BattleshipPlacement(shipNum);
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < shipNum[i]; j++)
                {
                    BattleshipShip ship;
                    int xCoord, yCoord;
                    do {
                        ship = new BattleshipShip(i, id);
                        ship.dir(rand.Next(-4, 4) * 90);
                        xCoord = rand.Next(1, 12);
                        yCoord = rand.Next(1, 12);
                    }
                    while (!x.Placeable(ship, myShips, new int[] {xCoord, yCoord }));
                    x.placeBoard.UpdateShips(ship);
                    id++;
                    myShips.Add(ship);
                }
            }
            botBoard = x.placeBoard;
            x.Close();
        }

        List<int[]> nextGuess = new List<int[]>();

        public void Hit() 
        {
            lastHit = guess;
            nextPoints(0,1);
            nextPoints(0,-1);
            nextPoints(-1,0);
            nextPoints(1,0);

            void nextPoints(int xDiff, int yDiff) 
            {
                int x=lastHit[0] + xDiff;
                int y=lastHit[1] + yDiff;
                if( (x>=0 && x<10) && (y >= 0 && y < 10) && guesses[x,y]==0) 
                {
                    nextGuess.Add(new int[] { x, y });
                    int value = x * 10 + y;
                    if (odd.Contains(value)) 
                    {
                        odd.Remove(value);
                    }
                    else if (even.Contains(value)) 
                    {
                        even.Remove(value);
                    }
                }
            }
        }

        public int[] Guesser()
        {
            if (nextGuess.Count > 0) 
            {
                int index=rand.Next(0, nextGuess.Count);
                guess = nextGuess[index];
                nextGuess.RemoveAt(index);
                return guess;
            }
            else if (oddMethod)
            {
                oddMethod = false;
                return getNum(odd);
            }
            else
            {
                oddMethod = true;
                return getNum(even);
            }
            
            int[] getNum(List<int> nums)
            {
                int index = rand.Next(0, nums.Count),
                n = nums[index];
                nums.RemoveAt(index);
                int y = n % 10, x = (n - y) / 10;
                guess = new int[] { x, y };
                return guess;
            }
        }
    }
}
