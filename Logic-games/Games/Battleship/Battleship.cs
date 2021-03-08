using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Logic_games.Properties;
using Logic_games.Games.Battleship;

namespace Logic_games
{
    public partial class Battleship : Form
    {
        public Font pixel;
        public Battleship()
        {
            InitializeComponent();
            pixel = new Font(pfc.Families[0], 9F, FontStyle.Regular);
            gameLP1.Visible = false;
        }

        public int[,] Player1 = new int[10, 10], Player2 = new int[10, 10];
        string player = "Second players'";
        bool started = false;
        public void SetupGame(int p) 
        {
            menuPanel.Visible = false;
            int[,] Player1 = new int[10, 10];
            MakeBoard(Player1, p);
        }

        private void MakeBoard(int[,] Player, int p) 
        {
            phase1 Pl = new phase1(gamePanel, gameLP1, rightMenuPanel, Player);
            Pl.SetupGame();
            
            Pl.Finished += WaitingForPlayer;
            
            void WaitingForPlayer(object sender, EventArgs e)
            {
                gameLP1.Hide();
                Pl.DeleteItems(p);

                if (p != 2)
                {
                    MakeBoard(Player2, 2);
                    Change();
                }
                else 
                {
                    gameLP1.Show();
                }
            }
        }

        private void Change() 
        {
            Visible = false;
            DialogResult res = MessageBox.Show(player+" turn", "GAME", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (res == DialogResult.OK || res == DialogResult.None)
            {
                Visible = true;
            }
            if (player == "Second players'") { player = "First players'"; }
            else { player = "Second players'"; }
        }

        private void startBtn_Click(object sender, EventArgs e)
        {
            errorLb.Text = "";
            started = true;
            switch (gameModeCB.SelectedIndex)
            {
                case 0:
                    SetupGame(2);
                    break;
                case 1:
                    SetupGame(1);
                    break;
                default:
                    errorLb.Text = "No game mode selected";
                    break;
            }
        }

        private void Battleship_ResizeBegin(object sender, EventArgs e)
        {
            if (started) 
            {
                gameLP1.Hide();
            }   
        }
        private void Battleship_ResizeEnd(object sender, EventArgs e)
        {
            if (started)
            {
                gameLP1.Show();
            }
        }
        private void backBtn_Click(object sender, EventArgs e)
        {
            Close(); //BACK TO MAIN MENU
        }
    }
}
