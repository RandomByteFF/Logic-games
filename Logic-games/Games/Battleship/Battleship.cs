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

        private void SetupGame(int mode) //GENERATING MAIN TABLE
        {

            //HEADERS
            AnchorStyles str = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            for (int i = 1; i < 11; i++)
            {
                gamePanel.Controls.Add(new Label()
                {
                    Text = Convert.ToChar(64 + i) + "",

                    Padding = new Padding(0),
                    Margin = new Padding(0),
                    TextAlign = (ContentAlignment)32,
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
                    gamePanel.Controls[gamePanel.Controls.Count - 1].Click += delegate (object sender, EventArgs e) { ImgClick(sender, e, coordinates); };
                }
            }
            gameLP1.Visible = true;
            PlaceShips();
        }

        //Panel elements - should be disposed later
        public int selectedShip = -1, remaining = 15;
        List<PictureBox> shipSelection = new List<PictureBox>();
        List<Label> shipAmount = new List<Label>();
        int[,] placement = new int[10, 10];
        int direction = 90, size = 0;

        public void PlaceShips() //CREATING THE MENU ON THE RIGHT
        {
            AnchorStyles str = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            string[,] ships = new string[5, 2] { { "Carrier", "1" }, { "Battleship", "2" }, { "Destroyer", "3" }, { "Submarine", "4" }, { "PatrolBoat", "5" } };
            Image[] shipImg = new Image[5] { Properties.Resources.Carrier, Properties.Resources.Battleship, Properties.Resources.Destroyer, Properties.Resources.Submarine, Properties.Resources.PatrolBoat };

            //Panel setup
            TableLayoutPanel RotatePanel = new TableLayoutPanel() { Anchor = str, BackColor = Color.Silver, CellBorderStyle = TableLayoutPanelCellBorderStyle.Single, ColumnCount = 3, Margin = new Padding(0) };
            RotatePanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            RotatePanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70F));
            RotatePanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            PictureBox RotatePB = new PictureBox { Anchor = str, Margin = new Padding(0), Name = "RotatePB", SizeMode = PictureBoxSizeMode.Zoom };
            RotatePanel.Controls.Add(new Button { Anchor = str, BackgroundImage = Properties.Resources.arrow1, BackgroundImageLayout = ImageLayout.Zoom, Margin = new Padding(0), Name = "RotateRightBtn", Text = "", BackColor = Color.DimGray }, 2, 0);
            RotatePanel.Controls[RotatePanel.Controls.Count - 1].Click += new EventHandler(delegate (object sender, EventArgs e) { RotateImg(sender, e, 90); });
            RotatePanel.Controls.Add(new Button { Anchor = str, BackgroundImage = Properties.Resources.arrow2, BackgroundImageLayout = ImageLayout.Zoom, Margin = new Padding(0), Name = "RotateLeftBtn", Text = "", BackColor = Color.DimGray }, 0, 0);
            RotatePanel.Controls[RotatePanel.Controls.Count - 1].Click += new EventHandler(delegate (object sender, EventArgs e) { RotateImg(sender, e, -90); });
            RotatePanel.Controls.Add(RotatePB, 1, 0);
            rightMenuPanel.Controls.Add(RotatePanel, 0, 1);
            //-------------
            TableLayoutPanel shipsPanel = new TableLayoutPanel() { Anchor = str, CellBorderStyle = TableLayoutPanelCellBorderStyle.Outset, ColumnCount = 2, Margin = new Padding(0), RowCount = 6 };
            shipsPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70f));
            shipsPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30f));
            shipsPanel.RowStyles.Add(new ColumnStyle(SizeType.Percent, 10f));
            shipsPanel.Controls.Add(new Label() { Anchor = str, BackColor = Color.DimGray, Margin = new Padding(0), Text = "Ship", TextAlign = ContentAlignment.MiddleCenter, ForeColor = Color.White }, 0, 0);
            shipsPanel.Controls.Add(new Label() { Anchor = str, BackColor = Color.DimGray, Margin = new Padding(0), Text = "No.", TextAlign = ContentAlignment.MiddleCenter, ForeColor = Color.White }, 1, 0);

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
            //Panels are ready!

            void SelectShip(object sender, EventArgs e, int shipID)
            {
                direction = 90;

                if (int.Parse(ships[shipID, 1]) > 0)
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

                    switch (selectedShip)
                    {
                        case 0:
                            size = 5;
                            break;
                        case 1:
                            size = 4;
                            break;
                        case 2:
                            size = 3;
                            break;
                        case 3:
                            size = 3;
                            break;
                        case 4:
                            size = 2;
                            break;
                        default:
                            break;
                    }
                }
            }
            void RotateImg(object sender, EventArgs e, int dir)
            {
                direction += dir;
                if (direction == 360)
                {
                    direction = 0;
                }
                else if (direction < 0)
                {
                    direction = 270;
                }
                Image img = null;
                switch (selectedShip)
                {
                    case 0:
                        img = Properties.Resources.Carrier;
                        break;
                    case 1:
                        img = Properties.Resources.Battleship;
                        break;
                    case 2:
                        img = Properties.Resources.Destroyer;
                        break;
                    case 3:
                        img = Properties.Resources.Submarine;
                        break;
                    case 4:
                        img = Properties.Resources.PatrolBoat;
                        break;
                    default:
                        break;
                }

                if (img != null)
                {
                    switch (direction)
                    {
                        case 0:
                            img.RotateFlip(RotateFlipType.Rotate270FlipNone);
                            break;
                        case 180:
                            img.RotateFlip(RotateFlipType.Rotate90FlipNone);
                            break;
                        case 270:
                            img.RotateFlip(RotateFlipType.Rotate180FlipNone);
                            break;
                    }
                }
                RotatePB.Image = img;
            }
        }
        public void TakeShip(int shipID)
        {
            int a = int.Parse(shipAmount[shipID].Text);
            if (a > 0) {
                shipAmount[shipID].Text = --a + "";
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
            if (selectedShip != -1 && Placeable(coordinates))
            {
                TakeShip(selectedShip);
                VisualizedShipPlacement(coordinates);
            }
        }
        private bool Placeable(int[] c)
        {
            bool CheckX(int i, int max, int change) 
            {
                while (i != max && placement[i, c[1] - 1] == 0)
                {
                    i+=change;
                }
                if (i == max)
                {
                    return true;
                }
                else { return false; }
            }

            bool CheckY(int i, int max, int change) 
            {
                while (i != max && placement[c[0] - 1, i] == 0)
                {
                    i += change;
                }
                if (i == max)
                {
                    return true;
                }
                else 
                { 
                    return false; 
                }
            }

            if (direction == 90 && c[0] + size - 1 < 11)
            {
                return CheckX(c[0] - 1, c[0] - 1 + size, 1);
            }
            else if (direction == 270 && c[0] - size >= 0)
            {
                return CheckX(c[0] - 1, c[0] - 1 - size, -1);
            }
            else if (direction == 180 && c[1] + size - 1 < 11)
            {
                return CheckY(c[1] - 1, c[1] - 1 + size, 1);
            }
            else if (direction == 0 && c[1] -1 - size >= 0)
            {
                return CheckY(c[1] - 1, c[1] - 1 - size, -1);             
            }

            return false;
        }
        private void VisualizedShipPlacement(int[] c)
        {
            int x = c[0] - 1, y = c[1] - 1;

            void PlaceX(int x0, int y0)
            {
                placement[x0, y0] = 1;
                Image img = Properties.Resources.apple;
                PictureBox cell = (PictureBox)gamePanel.GetControlFromPosition(x0 + 1, y0 + 1);
                cell.BackgroundImage = img;
            }
            void PlaceY(int x0, int y0)
            {
                placement[x0, y0] = 1;
                Image img = Properties.Resources.apple;
                PictureBox cell = (PictureBox)gamePanel.GetControlFromPosition(x0 + 1, y0 + 1);
                cell.BackgroundImage = img;
            }

            
            if (direction == 90 || direction == 270)
            {
                int j = direction == 90 ? 1 : -1;
                for (int i = 0; i < size; i++)
                {
                    PlaceX(x + (j * i), y);
                }
            }
            else
            {
                int j = direction == 180 ? 1 : -1;
                for (int i = 0; i < size; i++)
                {
                    PlaceY(x, y + (j * i));
                }
            }

            if (remaining == 0) 
            {
                placement.ToString();
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
        private void backBtn_Click(object sender, EventArgs e)
        {
            Close(); //BACK TO MAIN MENU
        }
    }
}
