using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Logic_games.Properties;
using Logic_games.Games.Battleship;

namespace Logic_games.Games.Battleship
{
    class phase2
    {
        public event EventHandler<OnWin> Won;
        public class OnWin : EventArgs
        {
            public Player player;
        }
        public int goal;
        private static AnchorStyles str = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        public Player player1, player2;
        int currentPlayer = 1;
        public Bot bot;
        bool multiplayer = false;
        TableLayoutPanel gameLP2;
        playerBoard Left1 = new playerBoard(new TableLayoutPanel()), Right1 = new playerBoard(new TableLayoutPanel());
        Label Left2 = new Label() { ForeColor = Color.Yellow, Text = "BOT", Anchor = str, TextAlign = ContentAlignment.MiddleCenter, Margin = new Padding(0) }, Right2 = new Label() { ForeColor = Color.Yellow, Text = "YOU", Anchor = str, TextAlign = ContentAlignment.MiddleCenter, Margin = new Padding(0) };
        Panel waitPanel;
        public void SetUp(TableLayoutPanel gl, Panel wp, int g) 
        {
            goal = g;
            waitPanel = wp;
            gameLP2 = gl;
            gameLP2.Controls.Add(Left1.gamePanel, 0, 0);
            gameLP2.Controls.Add(Right1.gamePanel, 1, 0);
            gameLP2.Controls.Add(Left2, 0, 1);
            gameLP2.Controls.Add(Right2, 1, 1);
            Right1.ImgClick += Clicked;
        }
        private void Clicked(object sender, playerBoard.ImgClickEventArgs e) 
        {
            Right2.Text = e.coordinates[0] + " " + e.coordinates[1];
            if (multiplayer && currentPlayer == 2) { GameLogic(player1, player2, e.coordinates[0]-1, e.coordinates[1]-1); }
            else if (multiplayer) { GameLogic(player2, player1, e.coordinates[0]-1, e.coordinates[1]-1); }
            else { GameLogic(player1, bot, e.coordinates[0] - 1, e.coordinates[1] - 1); }
        }

        private void GameLogic(Player current, Player opponent, int x, int y) 
        {
            if (opponent.player[x, y] == 0) 
            { 
                current.map[x, y] = 1;
                WaitFor("Miss", 4); 
            }
            else 
            {
                current.map[x, y] = 2;
                Ship hit=opponent.FindByID(opponent.player[x, y]);
                hit.HP--;
                if (hit.HP == 0) 
                {
                    current.sunk.Add(new List<Ship>() { hit });
                    if (current.sunk.Count == goal)
                    {
                        gameLP2.Controls.Clear();
                        player1.Clear();
                        player2.Clear();
                        Won?.Invoke(this, new OnWin { player= current});
                    }
                    else 
                    {
                        WaitFor("Sunk :)", 3);
                    }    
                }
                else 
                {
                    WaitFor("Hit :)", 4);
                }
            }
        }
        public static void RotatedImage(Image img, int direction)
        {
            if (direction == 360)
            {
                direction = 0;
            }
            else if (direction < 0)
            {
                direction = 270;
            }
            if (direction == 0) { img.RotateFlip(RotateFlipType.Rotate270FlipNone); }
            else if (direction == 180) { img.RotateFlip(RotateFlipType.Rotate90FlipNone); }
            else if (direction == 270) { img.RotateFlip(RotateFlipType.Rotate180FlipNone); }
        }

        private void GameLogic(Player player, Bot bot, int x, int y) 
        {
            if (bot.sunk.Count != goal)
            {
                if (bot.player[x, y] == 0)
                {
                    player.map[x, y] = 1;
                }
                else
                {
                    player.map[x, y] = 2;
                    Ship hit = bot.FindByID(bot.player[x, y]);
                    hit.HP--;
                    if (hit.HP == 0)
                    {
                        player.sunk.Add(new List<Ship>() { hit });
                    }
                }

                if (player.sunk.Count == goal)
                {
                    gameLP2.Controls.Clear();
                    player1.Clear();
                    bot.Clear();
                    bot.Sunk();
                    Won?.Invoke(this, new OnWin { player = player });
                }
                else
                {
                    int[] botGuess = bot.Guess();
                    int id = player.player[botGuess[0], botGuess[1]];
                    if (id == 0) 
                    {
                        bot.map[botGuess[0], botGuess[1]] = 1;
                        bot.Response("Miss", id); 
                    }
                    else
                    {
                        bot.map[botGuess[0], botGuess[1]] = 2;
                        Ship hit = player.FindByID(id);
                        hit.HP--;
                        if (hit.HP == 0) { bot.Response("Sunk", id); }
                        else { bot.Response("Hit", id); }
                    }
                    NextTurn(player, bot);
                }
            }
        }

        public void WaitFor(string reason, int s) 
        {
            Wait(s);
            gameLP2.Hide();
            waitPanel.Controls[0].Text = reason;
            waitPanel.Show();
            gameLP2.Show();
        }

        private void OkButton(object sender, EventArgs e)
        {
            if (multiplayer)
            {
                if (currentPlayer == 1)
                {
                    NextTurn(player1, player2);
                    currentPlayer = 2;
                }
                else
                {
                    NextTurn(player2, player1);
                    currentPlayer = 1;
                }
            }
            gameLP2.Show();
            waitPanel.Hide();
        }

        public void NextTurn(Player my, Player opponent)
        {
            /*
            PictureBox cell = (PictureBox)Left1.gamePanel.GetControlFromPosition(e.coordinates[0], e.coordinates[1]);
            Image img = cell.BackgroundImage;
            RotatedImage(img, 270);
            Wait(300000);
            */
            gameLP2.Hide();
            Left1.Reset();
            Right1.Reset();
            Left2.Text = my.name;
            Right2.Text = opponent.name;
            //Left1.GuessBoard(opponent.sunk, opponent.map);
            //Right1.GuessBoard(my.sunk, my.map);
            gameLP2.Show();
            Left1.InventoryToBoard(my.inventory, Left1.gamePanel);
            Right1.InventoryToBoard(my.sunk, Right1.gamePanel);

            /*
            for (int i = 1; i < 11; i++)
            {
                for (int j = 1; j < 11; j++)
                {
                    PictureBox cell = (PictureBox)Left1.gamePanel.GetControlFromPosition(i, j);
                    if (cell.BackgroundImage != null) 
                    {
                        int dir=my.FindByID(my.player[i - 1, j - 1]).direction;
                        Image img = cell.BackgroundImage;
                        RotatedImage(img, dir);
                    }
                }
            }*/
        }

        public void NextTurn(Player my, Bot opponent)
        {
            gameLP2.Hide();
            Left1.GuessBoard(opponent.sunk, opponent.map);
            Right1.GuessBoard(my.sunk, my.map);
            gameLP2.Show();
        }

        private async void Wait(int s) 
        {
            gameLP2.Enabled = false;
            await System.Threading.Tasks.Task.Delay(100*s);
            gameLP2.Enabled = true;
        }
        public phase2(TableLayoutPanel gl, Panel wp, Player Player1, Player Player2, int g) 
        {
            SetUp(gl, wp, g);
            player1 = Player1;
            player2 = Player2;
            multiplayer = true;
            waitPanel.Controls[0].Text = player1.name+"'s turn";
            waitPanel.Controls[1].Click += OK;
            waitPanel.Show();
            void OK(object sender, EventArgs e) 
            {
                waitPanel.Hide();
                NextTurn(player1, player2);
                waitPanel.Controls[1].Click -= OK;
                waitPanel.Controls[1].Click += OkButton;
                currentPlayer = 2;
                gameLP2.Show();
            }
            
        }
        public phase2(TableLayoutPanel gl, Panel wp, Player Player1, Bot b, int g)
        {
            SetUp(gl, wp, g);
            player1 = Player1;
            bot = b;
            Left2.Text = "YOU";
            Right2.Text = "BOT";
            Left1.InventoryToBoard(player1.inventory, Left1.gamePanel);
            NextTurn(player1, bot);
        }

    }
}
