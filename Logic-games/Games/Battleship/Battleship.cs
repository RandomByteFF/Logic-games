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
            Close(); //BACK TO MAIN MENU
        }

        public int selectedShip=-1, remaining=15;

        private void SetupGame(int mode)
        {
        //GENERATING MAIN TABLE

            //HEADERS
            AnchorStyles str = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;    
            for (int i = 1; i < 11; i++)
            {
                gamePanel.Controls.Add(new Label() 
                {
                    Text = Convert.ToChar(64 + i) + "",
                    
                    Padding=new Padding(0), 
                    Margin = new Padding(0), 
                    TextAlign= (ContentAlignment)32,
                    BackColor = Color.Gray,
                    Anchor = str 
                }, 0, i);

                gamePanel.Controls.Add(new Label() 
                {
                    Text = i + "",
                    Padding = new Padding(0), 
                    Margin = new Padding(0), 
                    TextAlign = (ContentAlignment)32, 
                    BackColor = Color.Gray,
                    Anchor = str 
                }, i, 0);
            }
            //CELLS
            for (int i = 1; i < 11; i++)
            {
                for (int j = 1; j < 11; j++)
                {
                    gamePanel.Controls.Add(new PictureBox()
                    {
                        Anchor = str,
                        BackColor = Color.Transparent,
                        BackgroundImage = new Bitmap(Properties.Resources.battleship1),
                        BackgroundImageLayout = ImageLayout.Stretch,
                        Image = new Bitmap(Properties.Resources.battleship4),
                        Margin = new Padding(0),
                        Tag = "i" + " j"
                    }, i, j);
                    int[] coordinates = new int[] { i, j };
                    gamePanel.Controls[gamePanel.Controls.Count - 1].Click += delegate(object sender, EventArgs e) { ImgClick(sender, e, coordinates); };
                }
            }
            gameLP1.Visible = true;

            PlaceShips();
        }

        //Panel elements - should be disposed later
        List<PictureBox> shipSelection = new List<PictureBox>();
        List<Label> shipAmount = new List<Label>();
        public void PlaceShips()
        {
        //CREATING THE MENU ON THE RIGHT
            AnchorStyles str = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            
            string[,] ships = new string[5, 2] {{"Carrier", "1"},{"Battleship", "2"},{"Destroyer", "3"},{"Submarine", "4"},{"PatrolBoat", "5"}};
            Image[] shipImg = new Image[5] { Properties.Resources.Carrier, Properties.Resources.Battleship, Properties.Resources.Destroyer, Properties.Resources.Submarine, Properties.Resources.PatrolBoat };
            
            

            //Panel setup
            TableLayoutPanel shipsPanel = new TableLayoutPanel()
            {
                Anchor = str,
                CellBorderStyle = TableLayoutPanelCellBorderStyle.Outset,
                ColumnCount = 2,
                Margin = new Padding(0),
                Name = "shipsTLP",
                RowCount = 6
            };

            shipsPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70f));
            shipsPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30f));
            shipsPanel.RowStyles.Add(new ColumnStyle(SizeType.Percent, 10f));
            shipsPanel.Controls.Add(new Label() {Anchor = str, BackColor = Color.DimGray, Margin = new Padding(0), Text = "Ship", TextAlign = ContentAlignment.MiddleCenter, ForeColor = Color.White}, 0, 0);
            shipsPanel.Controls.Add(new Label() {Anchor = str, BackColor = Color.DimGray, Margin = new Padding(0), Text = "No.", TextAlign = ContentAlignment.MiddleCenter, ForeColor = Color.White}, 1, 0);

            for (int i = 1; i < 6; i++)
            {
                shipSelection.Add(new PictureBox()
                {
                    Anchor = str,
                    BackColor = Color.Silver,
                    Image = shipImg[i - 1],
                    Margin = new Padding(0),
                    Name = ships[i - 1, 0] + "IMG",
                    SizeMode = PictureBoxSizeMode.StretchImage
                });
                int id = i - 1;
                shipSelection.Last().Click += delegate (object sender, EventArgs e) { SelectShip(sender, e, id); };
                
                shipAmount.Add(new Label()
                {
                    Anchor = str,
                    BackColor = Color.Gray,
                    Font = new Font("Microsoft Sans Serif", 6.75F, FontStyle.Regular),
                    Margin = new Padding(0),
                    Text = ships[i - 1, 1],
                    TextAlign = ContentAlignment.MiddleCenter,
                    Name = ships[i - 1, 0] + "Lb",
                    ForeColor = Color.White
                });

                shipsPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 18f));
                shipsPanel.Controls.Add(shipSelection.Last(), 0, i);
                shipsPanel.Controls.Add(shipAmount.Last(), 1, i);
            }
            rightMenuPanel.Controls.Add(shipsPanel, 0, 0);
            //Panel is ready!

            void SelectShip(object sender, EventArgs e, int shipID)
            {
                if (int.Parse(ships[shipID,1])>0) 
                {
                    RotatePB.Image = shipImg[shipID];
                    if (selectedShip != -1 && shipAmount[selectedShip].BackColor != Color.Black) 
                    {
                        shipAmount[selectedShip].BackColor = Color.Gray;
                        shipSelection[selectedShip].BackColor = Color.Silver;
                    }
                    selectedShip = shipID;
                    shipAmount[shipID].BackColor = Color.CadetBlue;
                    shipSelection[shipID].BackColor = Color.CadetBlue;
                }
            }   
        }
        public void PlaceShip(int shipID)
        {
            int a = int.Parse(shipAmount[shipID].Text);
            if (a > 0) {
                shipAmount[shipID].Text = --a+ "";
                remaining--;
                if (a == 0)
                {
                    shipAmount[shipID].BackColor = Color.Black;
                    shipSelection[shipID].BackColor = Color.Black;
                }
            }
        }

        public void ImgClick(object sender, EventArgs e, int[] coordinates)
        {
            label1.Text = coordinates[0] + " " + coordinates[1];
            if (selectedShip != -1)
            {
                PlaceShip(selectedShip);
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
                case 2:
                    SetupGame(2);
                    break;
                default:
                    errorLb.Text = "No game mode selected";
                    break;
            }
        }

        private void RotateRightBtn_Click(object sender, EventArgs e)
        {
            Image img = RotatePB.Image;
            if (img != null) 
            {
                img.RotateFlip(RotateFlipType.Rotate90FlipNone);
                RotatePB.Image = img;
            }
            
        }

        private void RotateLeftBtn_Click(object sender, EventArgs e)
        {
            Image img = RotatePB.Image;
            if (img != null)
            {
                img.RotateFlip(RotateFlipType.Rotate270FlipNone);
                RotatePB.Image = img;
            }
        }
    }
}
