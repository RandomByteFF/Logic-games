using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Logic_games
{
    public partial class Battleship : Form
    {
        public Battleship()
        {
            InitializeComponent();
            gameLP1.Visible = false;
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            //Vissza a főmenübe
            this.Close();
        }

        private void SetupGame(int mode)
        {
            AnchorStyles str = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            
            for (int i = 1; i < 11; i++)
            {
                gamePanel.Controls.Add(new Label() 
                {
                    Text=i+"", 
                    Padding=new Padding(0), 
                    Margin = new Padding(0), 
                    TextAlign= (ContentAlignment)32,
                    BackColor = Color.Gray,
                    Anchor = str 
                }, 0, i);

                gamePanel.Controls.Add(new Label() 
                {
                    Text=i+"", 
                    Padding = new Padding(0), 
                    Margin = new Padding(0), 
                    TextAlign = (ContentAlignment)32, 
                    BackColor = Color.Gray,
                    Anchor = str 
                }, i, 0);
            }
            for (int i = 1; i < 11; i++)
            {
                for (int j = 1; j < 11; j++)
                {
                    gamePanel.Controls.Add(new PictureBox()
                    {
                        Anchor = str,
                        BackColor = Color.Transparent,
                        BackgroundImage = new Bitmap(Properties.Resources.tail),
                        BackgroundImageLayout = ImageLayout.Stretch,
                        Image = new Bitmap(Properties.Resources.tail),
                        Margin = new Padding(0),
                        Tag = "i" + " j"
                    }, i, j);
                    int[] coordinates = new int[] { i, j };
                    gamePanel.Controls[gamePanel.Controls.Count - 1].Click += delegate(object sender, EventArgs e) { ImgClick(sender, e, coordinates); } ;
                }
            }
            gameLP1.Visible = true;
        }

        public void ImgClick(object sender, EventArgs e, int[] coordinates) 
        {
            label1.Text=coordinates[0]+" "+coordinates[1];
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
                case 2:
                    SetupGame(2);
                    break;
                default:
                    errorLb.Text = "No game mode selected";
                    break;
            }
        }
    }
}
