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
        //public static int carrierC = 1, battleshipC = 0, destroyerC = 0, submarineC = 0, patrolboatC = 1, shipID = -1;
        public static int carrierC = 1, battleshipC = 2, destroyerC = 3, submarineC = 4, patrolboatC = 5, shipID = -1;
        public Battleship()
        {
            InitializeComponent();
            addPixel();
            gameLP1.Visible = false;
        }
        
        string player = "Second players'";
        bool started = false;
        public void SetupGame(int p) 
        {
            menuPanel.Visible = false;
            if (p == 0)
            {
                int[,] Player1 = new int[10, 10];
                MakeBoard(Player1);
            }
            else 
            {
                int[,] Player1 = new int[10, 10], Player2 = new int[10, 10];
                MakeBoard(Player1, Player2, 1);
            }
        }

        private void MakeBoard(int[,] Player1, int[,] Player2, int p)
        {
            phase1 Pl = new phase1(gamePanel, gameLP1, rightMenuPanel, Player1);
            Pl.SetupGame();
            Pl.Finished += WaitingForPlayer;

            void WaitingForPlayer(object sender, EventArgs e)
            {
                gameLP1.Hide();
                Pl.DeleteItems(p);

                if (p != 2)
                {
                    Change();
                    MakeBoard(Player2, Player1, 2);
                }
                else
                {
                    gameLP1.Show();
                    phase2 Ps = new phase2(gameLP1);
                }
            }
        }

        private void MakeBoard(int[,] Player) 
        {
            phase1 Pl = new phase1(gamePanel, gameLP1, rightMenuPanel, Player);
            Pl.SetupGame();
            Bot bot = new Bot();
            Pl.Finished += WaitingForPlayer;
            
            void WaitingForPlayer(object sender, EventArgs e)
            {
                gameLP1.Hide();
                List<List<Ship>> Inventory= new List<List<Ship>>(Pl.inventory);
                Pl.DeleteItems(2);
                phase2 Ps = new phase2(gameLP1, Inventory, Player);
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

        public List<List<Ship>> ShipsToInventory(bool random)
        {
            List<Ship> carriers = new List<Ship>(), battleships = new List<Ship>(), destroyers = new List<Ship>(), submarines = new List<Ship>(), patrolboats = new List<Ship>();
            for (int i = 0; i < carrierC; i++) { carriers.Add(new Ship(5, new Image[] { Resources.carrier1, Resources.carrier2, Resources.carrier3, Resources.carrier4, Resources.carrier5 }, random)); }
            for (int i = 0; i < battleshipC; i++) { battleships.Add(new Ship(4, new Image[] { Resources.battleship1, Resources.battleship2, Resources.battleship3, Resources.battleship4 }, random)); }
            for (int i = 0; i < destroyerC; i++) { destroyers.Add(new Ship(3, new Image[] { Resources.destroyer1, Resources.destroyer2, Resources.destroyer3 }, random)); }
            for (int i = 0; i < submarineC; i++) { submarines.Add(new Ship(3, new Image[] { Resources.submarine1, Resources.submarine2, Resources.submarine3 }, random)); }
            for (int i = 0; i < patrolboatC; i++) { patrolboats.Add(new Ship(2, new Image[] { Resources.patrolBoat1, Resources.patrolBoat2 }, random)); }
            return new List<List<Ship>>() { carriers, battleships, destroyers, submarines, patrolboats };
        }
    }
}
