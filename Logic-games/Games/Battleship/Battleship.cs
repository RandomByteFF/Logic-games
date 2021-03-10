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
        public static System.Drawing.Text.PrivateFontCollection pfc = new System.Drawing.Text.PrivateFontCollection();
        public static Font pixel;

        [System.Runtime.InteropServices.DllImport("gdi32.dll")]
        private static extern IntPtr AddFontMemResourceEx(IntPtr pbFont, uint cbFont,
            IntPtr pdv, [System.Runtime.InteropServices.In] ref uint pcFonts);

        private void addPixel()
        {
            byte[] fontData = Properties.Resources.pixelfont;
            IntPtr fontPtr = System.Runtime.InteropServices.Marshal.AllocCoTaskMem(fontData.Length);
            System.Runtime.InteropServices.Marshal.Copy(fontData, 0, fontPtr, fontData.Length);
            uint dummy = 0;
            pfc.AddMemoryFont(fontPtr, Properties.Resources.pixelfont.Length);
            AddFontMemResourceEx(fontPtr, (uint)Properties.Resources.pixelfont.Length, IntPtr.Zero, ref dummy);
            System.Runtime.InteropServices.Marshal.FreeCoTaskMem(fontPtr);

            pixel = new Font(pfc.Families[0], 9.0F);

            fontData = Properties.Resources.adventure;
            fontPtr = System.Runtime.InteropServices.Marshal.AllocCoTaskMem(fontData.Length);
            System.Runtime.InteropServices.Marshal.Copy(fontData, 0, fontPtr, fontData.Length);
            dummy = 0;
            pfc.AddMemoryFont(fontPtr, Properties.Resources.adventure.Length);
            AddFontMemResourceEx(fontPtr, (uint)Properties.Resources.adventure.Length, IntPtr.Zero, ref dummy);
            System.Runtime.InteropServices.Marshal.FreeCoTaskMem(fontPtr);

            pixel = new Font(pfc.Families[0], 9.0F);

            //pfc.AddFontFile(System.IO.Path.Combine(System.IO.Path.GetFullPath(@"..\..\"), "Resources/pixelfont.ttf"));
            //pfc.AddFontFile(System.IO.Path.Combine(System.IO.Path.GetFullPath(@"..\..\"), "Resources/adventure.ttf"));
            //pixel = new System.Drawing.Font(pfc.Families[0], 9F, System.Drawing.FontStyle.Regular);
            this.menuPanel.Font = pixel;
            this.gameLP1.Font = pixel;
            this.gameLP2.Font = pixel;
            this.waitPanel.Font = new System.Drawing.Font(pfc.Families[1], 14F, System.Drawing.FontStyle.Regular);
            this.winnerLb.Font = new System.Drawing.Font(pfc.Families[0], 18F, System.Drawing.FontStyle.Regular);
            this.winPanel.Font = pixel;
            this.statLb.Font = pixel;
            this.waitLB.Font = new System.Drawing.Font(pfc.Families[1], 30F, System.Drawing.FontStyle.Regular);
        }
        public Battleship()
        {
            InitializeComponent();
            addPixel();
            gameLP1.Visible = false;
        }
        bool started1 = false, started2= false, started3 = false;
        public void SetupGame(int p)
        {
            winPanel.Hide();
            if (p == 0)
            {
                Bot bot = new Bot();
                Player p1 = new Player();
                MakeBoard(p1, bot);   
            }
            else
            {
                string name="";
                if (nameTB1.Text.Length == 0) { name = "Player 1"; }
                else { name = nameTB1.Text; }
                Player p1 = new Player(name);
                if (nameTB2.Text.Length == 0) { name = "Player 2"; }
                else { name = nameTB2.Text; }
                Player p2 = new Player(name);
                MakeBoard(p1, p2, 1);
            }
        }

        private void MakeBoard(Player Player1, Player Player2, int p)
        {
            phase1 Pl = new phase1(gamePanel, gameLP1, rightMenuPanel, Player1);
            Pl.SetupGame();
            int g = Pl.goal;
            Pl.Finished += WaitingForPlayer;

            void WaitingForPlayer(object sender, EventArgs e)
            {
                gameLP1.Hide();
                Pl.DeleteItems();

                if (p != 2)
                {
                    Change(Player2.name);
                    MakeBoard(Player2, Player1, 2);
                }
                else
                {
                    gameLP1.Hide();
                    started1 = false;
                    started2 = true;
                    phase2 Ps = new phase2(gameLP2, waitPanel, Player2, Player1, g);
                    Ps.Won +=GameEnd;

                    void GameEnd(object o, phase2.OnWin data)
                    {
                        Reset(data.player, data.i);
                    }
                }
            }
        }

        private void MakeBoard(Player Player1, Bot bot)
        {
            phase1 Pl = new phase1(gamePanel, gameLP1, rightMenuPanel, Player1);
            Pl.SetupGame();
            int g = Pl.goal;
            Pl.Finished += WaitingForPlayer;

            void WaitingForPlayer(object sender, EventArgs e)
            {
                gameLP1.Hide();
                started1 = false;
                started2 = true;
                Pl.DeleteItems();
                phase2 Ps = new phase2(gameLP2, waitPanel, Player1, bot, g);
                Ps.Won += GameEnd;

                void GameEnd(object o, phase2.OnWin data)
                {
                    Reset(data.player, data.i);
                }
            }
        }

        private void Change(string player) 
        {
            Visible = false;
            DialogResult res = MessageBox.Show(player+"'s turn", "GAME", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (res == DialogResult.OK || res == DialogResult.None)
            {
                Visible = true;
            }
        }

        private void startBtn_Click(object sender, EventArgs e)
        {
            errorLb.Text = "";
            started1 = true;
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
            if (started1)
            {
                gameLP1.Hide();
            }

            if (!gameLP2.Visible && started2==true)
            {
                started3 = true;
                waitPanel.Hide();
            }
            else 
            {
                started3 = false;
            }
            
            if (started2 && !started3)
            {
                gameLP2.Hide();
            }
        }
        private void Battleship_ResizeEnd(object sender, EventArgs e)
        {
            waitPanel.Size = Size;
            waitLB.Width = waitPanel.Width;
            waitBTN.Width = waitPanel.Width;
            waitBTN.Location = new Point(0, waitPanel.Height - waitBTN.Height-20);
            if (started1)
            {
                gameLP1.Show();
            }
            else if (started2 && !started3)
            {
                gameLP2.Show();
            }
            else if(started3)
            {
                waitPanel.Show();
            }
        }
        private void backBtn_Click(object sender, EventArgs e)
        {
            Close(); //BACK TO MAIN MENU
        }

        private void ContiniueBTN_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void gameModeCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (gameModeCB.SelectedIndex==0) 
            {
                nameTB1.Visible = false; 
                nameTB2.Visible = false; 
            }
            else 
            {
                nameTB1.Visible = true;
                nameTB2.Visible = true;
            }
        }

        private void Reset(Player winner, int mode) 
        {
            gameModeCB.SelectedIndex = 0;
            nameTB1.Visible = false;
            nameTB2.Visible = false;
            //gameLP2.Hide();
            gameLP2.Dispose();
            winPanel.Show();
            menuPanel.Show();
            gameLP1.Hide();
            gameLP2.Hide();
            waitPanel.Hide();
            started1 = false;
            started2 = false;
            started3 = false;
            if (mode == 2)
            {
                cupPB.Visible = false;
                statLb.Visible = false;
                winnerLb.Text = winner.name + " won!";
            }
            else 
            {
                
                cupPB.Visible = true;
                statLb.Visible = true;
                
                winnerLb.Text = winner.name + " won!";
                if (winner.name != "BOT")
                {
                    SqlConnectionHandler.RunNonQuery($"INSERT INTO battleship(score) VALUES(1)");
                }
                else 
                {
                    SqlConnectionHandler.RunNonQuery($"INSERT INTO battleship(score) VALUES(-1)");
                }
                List<List<string>> sum = SqlConnectionHandler.Query($"SELECT sum(score) FROM battleship WHERE score = 1");
                if (sum.Count > 0)
                {
                    statLb.Text = Convert.ToString("Wins against bot: " + sum[0][0]);
                }
                else
                {
                    statLb.Hide();
                }
            }
            
        }
    }
}
