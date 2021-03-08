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
        public Battleship()
        {
            InitializeComponent();
            gameLP1.Visible = false;

        }

        public int[,] Player1 = new int[10, 10], Player2 = new int[10, 10];
        public void SetupGame(int p) 
        {
            int[,] Player1 = new int[10, 10];
            MakeBoard(Player1, 1);
        }

        private void MakeBoard(int[,] Player, int Pnum) 
        {
            phase1 Pl = new phase1(gamePanel, gameLP1, rightMenuPanel, Player);
            Pl.SetupGame();
            
            Pl.Finished += WaitingForPlayer;
            
            void WaitingForPlayer(object sender, EventArgs e)
            {
                Pl.DeleteItems();
            }
        }

        private void startBtn_Click(object sender, EventArgs e)
        {
            errorLb.Text = "";
            switch (gameModeCB.SelectedIndex)
            {
                case 0:
                    SetupGame(0);
                    break;
                case 1:
                    SetupGame(1);
                    break;
                default:
                    errorLb.Text = "No game mode selected";
                    break;
            }
        }
        private void backBtn_Click(object sender, EventArgs e)
        {
            Close(); //BACK TO MAIN MENU
        }
    }
}
