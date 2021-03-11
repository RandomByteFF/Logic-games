using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Logic_games.Properties;
using Logic_games.Games.Battleship;

namespace Logic_games.Games.Battleship
{
    public partial class BattleshipGuessForm : Form
    {
        public bool finished = false;
        public BattleshipBoard leftBoard, rightBoard;
        public BattleshipBot bot;
        public BattleshipPlayer player1;
        public BattleshipGuessForm(BattleshipPlayer player)
        {
            InitializeComponent();
            DoubleBuffered = true;
            bot = new BattleshipBot("BOT", player.shipNumbers);
            leftNameLabel.Text = bot.name;
            rightNameLabel.Text = player.name;
            leftBoard = player.myBoard;
            leftBoard.DrawGuessBoard(bot.guesses);

            rightBoard = new BattleshipBoard(player.sunk);
            rightBoard.DrawGuessBoard(player.guesses);

            gamePanel.Controls.Add(leftBoard, 0, 0);
            gamePanel.Controls.Add(rightBoard, 0, 0);

            player1 = player;

            rightBoard.ImgClick += Guess1;
        }
        private void Guess1(object sender, BattleshipBoard.ImgClickEventArgs e)
        {
            int x =e.coordinates[0]-1, y =e.coordinates[1]-1;
            if (!finished)
            {
                Guess();
            } 
            
            void Guess()
            {
                if (player1.guesses[x, y] == 0)
                {
                    bool hit = false;
                    foreach (BattleshipShip ship in bot.myShips)
                    {
                        if (!hit)
                        {
                            int i = 0;
                            while (i < ship.size && !(ship.positions[i][0] == x + 1 && ship.positions[i][1] == y + 1))
                            {
                                i++;
                            }
                            if (i < ship.size)
                            {
                                hit = true;
                                player1.guesses[x, y] = 2;
                                Hit(new int[] { x, y }, rightBoard);
                                ship.hp -= 1;
                                if (ship.hp == 0)
                                {
                                    Sunk(ship);
                                }
                            }
                        }
                    }
                    if (!hit)
                    {
                        player1.guesses[x, y] = 1;
                        Miss(new int[] { x, y }, rightBoard);
                    }
                    //BOT GUESS
                    if (!finished)
                    {
                        hit = false;
                        int[] botGuess = bot.Guesser();
                        foreach (BattleshipShip ship in player1.myShips)
                        {
                            if (!hit)
                            {
                                int i = 0, xBot = botGuess[0] + 1, yBot = botGuess[1] + 1;
                                while (i < ship.size && !(ship.positions[i][0] == xBot && ship.positions[i][1] == yBot))
                                {
                                    i++;
                                }
                                if (i < ship.size)
                                {
                                    hit = true;
                                    bot.guesses[x, y] = 2;
                                    bot.Hit();
                                    Hit(botGuess, leftBoard);
                                    ship.hp -= 1;
                                    if (ship.hp == 0)
                                    {
                                        bot.sunk.Add(ship);
                                        if (bot.sunk.Count == bot.myShips.Count)
                                        {
                                            finished = true;
                                            Won?.Invoke(this, new OnWin { player = bot });
                                        }
                                    }
                                }
                            }
                        }
                        if (!hit)
                        {
                            bot.guesses[x, y] = 1;
                            Miss(botGuess, leftBoard);
                        }
                    }
                }
            }
        }

        public void Miss(int[] c, BattleshipBoard board) 
        {
            board.cells[c[0], c[1]].Image = Resources.Miss;   
        }
        public void Hit(int[] c, BattleshipBoard board)
        {
            board.cells[c[0], c[1]].Image = Resources.Hit;
        }
        public void Sunk(BattleshipShip ship) 
        {
            player1.sunk.Add(ship);
            for (int i = 0; i < ship.size; i++)
            {
                rightBoard.cells[ship.positions[i][0]-1, ship.positions[i][1]-1].BackgroundImage = ship.components[i];
            }
            if (player1.sunk.Count == player1.myShips.Count) 
            {
                finished = true;
                //rightBoard.ImgClick -= Guess1;
                Won?.Invoke(this, new OnWin { player = player1});
            }
        }

        public event EventHandler<OnWin> Won;
        public class OnWin : EventArgs
        {
            public BattleshipPlayer player;
        }
    }
}
