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
        //VARIABLES
        //private int[] shipNumber = new int[] {0,0,0,1,0}; //TEST CASE WITH 1 SHIP
        private int[] shipNumber = new int[] {1,2,3,4,5}; //CARRIER, BATTLESHIP, DESTROYER, SUBMARINE, PATROLBOAT
        public bool multiplayer = false;
        private List<Control> menu;
        private List<Control> win;

        //PREAPARATION
        public Battleship()
        {
            InitializeComponent();
            DoubleBuffered = true;
            menu = new List<Control>() { menuBackButton, menuErrorLabel, menuStartButton };
            win = new List<Control>() { winContiniueButton, winCupPicturebox, winnerLb, winStatisticsLabel };
            ChangeView(win, menu);
        }

    //CUSTOM FUNCTIONS

        //SINGLEPLAYER MODE
        private void SinglePlayer()
        {
            BattleshipPlayer player1 = new BattleshipPlayer("YOU", shipNumber);
            PlacementWindowOpen(player1);

            void PlacementWindowOpen(BattleshipPlayer player)
            {
                bool saved = false;
                Visible = false; // hiding this window
                BattleshipPlacement battleshipWindow1 = new BattleshipPlacement(shipNumber);
                //Event handling
                battleshipWindow1.OnPlacedAllShips += SaveInventory;
                battleshipWindow1.Show();
                battleshipWindow1.FormClosed += new FormClosedEventHandler(GuessWindowOpen);

                void SaveInventory(object creator, BattleshipPlacement.PlacedAllShips f)
                {
                    //SAVING INVENTORY
                    player.myShips = new List<BattleshipShip>(f.inventory);
                    player.myBoard = f.myBoard;
                    saved = true;
                    battleshipWindow1.OnPlacedAllShips -= SaveInventory;
                }

                void GuessWindowOpen(object s, EventArgs g) //OPENING THE SECOND PHASE
                {
                    battleshipWindow1.FormClosed -= new FormClosedEventHandler(GuessWindowOpen);
                    if (saved)
                    {
                        BattleshipGuessForm guessWndow = new BattleshipGuessForm(player);
                        guessWndow.FormClosed += ShowThisWindow;
                        guessWndow.Show();
                        guessWndow.Won += Won;

                        void Won(object sender, BattleshipGuessForm.OnWin d)
                        {
                            guessWndow.Won -= Won;
                            guessWndow.Close();
                            Visible = true;
                            OnWinSingle(d.player);
                        }
                        void ShowThisWindow(object se, EventArgs e) 
                        {
                            guessWndow.Won -= Won;
                            guessWndow.FormClosed -= ShowThisWindow;
                            Show();
                        }
                    }
                    else 
                    {
                        Show();
                    }
                }
            }
        }
        //DISPLAY WIN
        private void OnWinSingle(BattleshipPlayer winner)
        {
            ChangeView(menu, win);
            winnerLb.Text = winner.name + " WON!";
            List<List<string>> sum = new List<List<string>>();
            //INSERTING DATA TO THE TABLE
            try
            {
                if (SqlConnectionHandler.InitialSetup() == 0)
                    if (winner.name != "BOT")
                    {
                        SqlConnectionHandler.RunNonQuery($"INSERT INTO battleship(score) VALUES(1)");
                    }
                    else
                    {
                        SqlConnectionHandler.RunNonQuery($"INSERT INTO battleship(score) VALUES(-1)");
                    }
                //GETTING STATS
                sum = SqlConnectionHandler.Query($"SELECT sum(score) FROM battleship WHERE score = 1");
                if (sum.Count > 0)
                {
                    string ammount = Convert.ToString(sum[0][0]);
                    winStatisticsLabel.Text= "Wins against bot: "+ammount ;
                }
                else
                {
                    winStatisticsLabel.Hide();
                }
            }
            catch
            {
                winStatisticsLabel.Hide();
            }
        }

        //HIDE AND SHOW - SWITCHING MENU VIEWS
        private void ChangeView(List<Control> hidden, List<Control> shown)
        {
            foreach (Control item in hidden)
            {
                item.Hide();
            }
            foreach (Control item in shown)
            {
                item.Show();
            }
        }

    //CONTROLS

        //START GAME
        private void menuStartButton_Click(object sender, EventArgs e)
        {
            SinglePlayer();
        }
        //CREATE ANOTHER GAME
        private void winContiniueButton_Click(object sender, EventArgs e)
        {
            multiplayer = false;
            ChangeView(win, menu);
        }
        
        //BACK TO MAIN MENU
        private void menuBackButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
