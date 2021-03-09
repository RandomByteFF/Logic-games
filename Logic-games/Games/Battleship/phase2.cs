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
        bool multiplayer = false;
        public static AnchorStyles str = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        TableLayoutPanel gameLP2;
        public Player player1, player2;
        public Bot bot;
        playerBoard Left1 = new playerBoard(new TableLayoutPanel()), Right1 = new playerBoard(new TableLayoutPanel());
        Label Left2 = new Label() { ForeColor = Color.Yellow, Text = "BOT", Anchor = str, TextAlign = ContentAlignment.MiddleCenter, Margin = new Padding(0) }, Right2 = new Label() { ForeColor = Color.Yellow, Text = "YOU", Anchor = str, TextAlign = ContentAlignment.MiddleCenter, Margin = new Padding(0) };
        Panel waitPanel;
        public void SetUp(TableLayoutPanel gl, Panel wp) 
        {
            waitPanel = wp;
            gameLP2 = gl;
            gameLP2.Controls.Add(Left1.gamePanel, 0, 0);
            gameLP2.Controls.Add(Right1.gamePanel, 1, 0);
            Left2.Text = "YOU";
            Right2.Text = "BOT";
            gameLP2.Controls.Add(Left2, 0, 1);
            gameLP2.Controls.Add(Right2, 1, 1);
            Right1.ImgClick += Clicked;
            waitPanel.Visible = true;
            waitPanel.Hide();
            gameLP2.Show();
        }
        public void Clicked(object sender, playerBoard.ImgClickEventArgs e) 
        {
            Right2.Text = e.coordinates[0] + " " + e.coordinates[1];
            WaitFor("Miss :(", 1);
        }

        public void WaitFor(string reason, int duration) 
        {
            Wait(duration);
            gameLP2.Hide();
            waitPanel.Controls[0].Text = reason;
            waitPanel.Controls[1].Click += Ok;
            waitPanel.Show();

            void Ok(object sender, EventArgs e) 
            {
                NextTurn(player1);
                gameLP2.Show();
                waitPanel.Hide();
            }
        }

        public void NextTurn(Player next)
        {
            Left1.InventoryToBoard(next.inventory);
        }

        private async void Wait(int sec) 
        {
            gameLP2.Enabled = false;
            await System.Threading.Tasks.Task.Delay(1000 * sec);
            gameLP2.Enabled = true;
        }
        public phase2(TableLayoutPanel gl, Panel wp, Player Player1, Player Player2) 
        {
            SetUp(gl, wp);
            player1 = Player1;
            player2 = Player2;
            multiplayer = true;
            
            playerBoard Left2 = new playerBoard(new TableLayoutPanel { Anchor = phase1.str }), Right2 = new playerBoard(new TableLayoutPanel { Anchor = phase1.str });
        }
        public phase2(TableLayoutPanel gl, Panel wp, Player Player1, Bot b)
        {
            SetUp(gl, wp);
            player1 = Player1;
            bot = b;
            NextTurn(player1);
        }

        public void Guess(int coordinate) 
        { 
            //Miss, Hit, Sunk
        }
    }
}
