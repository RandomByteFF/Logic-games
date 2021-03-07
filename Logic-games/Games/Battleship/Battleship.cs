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

        private void SetupGame(int mode) //GENERATING MAIN TABLE
        {
            //HEADERS
            
            for (int i = 1; i < 11; i++)
            {
                gamePanel.Controls.Add(new Label(){ Text = Convert.ToChar(64 + i) + "", Padding = new Padding(0), Margin = new Padding(0), TextAlign = (ContentAlignment)32, BackColor = Color.Gray, Anchor = str }, 0, i);
                gamePanel.Controls.Add(new Label(){ Text = i + "", Padding = new Padding(0), Margin = new Padding(0), TextAlign = (ContentAlignment)32, BackColor = Color.Gray, Anchor = str }, i, 0);
            }
            //CELLS
            for (int i = 1; i < 11; i++)
            {
                for (int j = 1; j < 11; j++)
                {
                    gamePanel.Controls.Add(new PictureBox() { Anchor = str, BackColor = Color.Transparent, BackgroundImageLayout = ImageLayout.Stretch, Margin = new Padding(0), Tag = "i" + " j" }, i, j);
                    int[] coordinates = new int[] { i, j };
                    gamePanel.Controls[gamePanel.Controls.Count - 1].Click += delegate (object sender, EventArgs e) { ImgClick(sender, e, coordinates); };
                }
            }
            PlaceShips();
            gameLP1.Visible = true;
        }

        public AnchorStyles str = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        int remaining = 15, shipID = -1;
        int[,] placement = new int[10, 10];
        PictureBox RotatePB = new PictureBox { Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right, Margin = new Padding(0), Name = "RotatePB", SizeMode = PictureBoxSizeMode.Zoom };
        List<PictureBox> shipSelection = new List<PictureBox>();
        List<Label> shipAmount = new List<Label>();
        List<List<Ship>> inventory;
        Ship selectedShip;
        
        public void PlaceShips() //CREATING THE MENU ON THE RIGHT
        {
            TableLayoutPanel[] Panels = RightPanels();
            rightMenuPanel.Controls.Add(Panels[0], 0, 0);
            rightMenuPanel.Controls.Add(Panels[1], 0, 1);
            ShipsToInventory();  
        }

        public void ShipsToInventory()
        {
            List<Ship> carriers = new List<Ship>() { new Ship(5, new Image[] { Resources.carrier1, Resources.carrier2, Resources.carrier3, Resources.carrier4, Resources.carrier5 }) };
            List<Ship> battleships = new List<Ship>() { new Ship(4, new Image[] { Resources.battleship1, Resources.battleship2, Resources.battleship3, Resources.battleship4 }), new Ship(4, new Image[] { Resources.battleship1, Resources.battleship2, Resources.battleship3, Resources.battleship4 }) };
            List<Ship> destroyers = new List<Ship>(), submarines = new List<Ship>(), patrolboats = new List<Ship>();
            for (int i = 0; i < 3; i++) { destroyers.Add(new Ship(3, new Image[] { Resources.destroyer1, Resources.destroyer2, Resources.destroyer3 })); }
            for (int i = 0; i < 4; i++) { submarines.Add(new Ship(3, new Image[] { Resources.submarine1, Resources.submarine2, Resources.submarine3 })); }
            for (int i = 0; i < 5; i++) { patrolboats.Add(new Ship(2, new Image[] { Resources.patrolBoat1, Resources.patrolBoat2 })); }
            inventory = new List<List<Ship>>() { carriers, battleships, destroyers, submarines, patrolboats };
        }
        public void TakeShip(int shipID, Ship selectedShip)
        {
            int a = int.Parse(shipAmount[shipID].Text);
            if (a > 0)
            {
                shipAmount[shipID].Text = --a + "";
                remaining--;
                if (a == 0)
                {
                    shipAmount[shipID].BackColor = Color.Black;
                    shipSelection[shipID].BackColor = Color.Black;
                }
                VisualizedShipPlacement(selectedShip);
            }
        }
        public void ImgClick(object sender, EventArgs e, int[] coordinates)
        {
            label1.Text = coordinates[0] + " " + coordinates[1];
            if (shipID != -1)
            {
                selectedShip.X = coordinates[0] - 1;
                selectedShip.Y = coordinates[1] - 1;
                if (Placeable(coordinates, selectedShip.direction))
                {
                    TakeShip(shipID, selectedShip);
                }
            }
        }
        private bool Placeable(int[] c, int direction)
        {
            bool Check(int i, int max, int change, bool isX)
            {
                if (isX)
                {
                    while (i != max && placement[i, c[1] - 1] == 0)
                    {
                        i += change;
                    }
                }
                else 
                {
                    while (i != max && placement[c[0] - 1, i] == 0)
                    {
                        i += change;
                    }
                }

                if (i == max)
                {
                    return true;
                }
                else { return false; }
            }

            if (selectedShip.direction == 90 && c[0] + selectedShip.size - 1 < 11)
            {
                return Check(c[0] - 1, c[0] - 1 + selectedShip.size, 1, true);
            }
            else if (selectedShip.direction == 270 && c[0] - selectedShip.size >= 0)
            {
                return Check(c[0] - 1, c[0] - 1 - selectedShip.size, -1, true);
            }
            else if (selectedShip.direction == 180 && c[1] + selectedShip.size - 1 < 11)
            {
                return Check(c[1] - 1, c[1] - 1 + selectedShip.size, 1, false);
            }
            else if (selectedShip.direction == 0 && c[1] - selectedShip.size >= 0)
            {
                return Check(c[1] - 1, c[1] - selectedShip.size, -1, false);
            }
            else { return false; }
        }
        private void VisualizedShipPlacement(Ship ship)
        {
            int x = ship.X, y = ship.Y;
            Image[] images = ship.components;
            Image img;
            void Place(int x0, int y0)
            {
                placement[x0, y0] = 1;
                PictureBox cell = (PictureBox)gamePanel.GetControlFromPosition(x0 + 1, y0 + 1);
                cell.BackgroundImage = img;
                RotatedImage(img, ship.direction);
            }
            if (ship.direction == 90 || ship.direction == 270)
            {
                int j = ship.direction == 90 ? 1 : -1;
                for (int i = 0; i < ship.size; i++)
                {
                    img = images[i];
                    Place(x + (j * i), y);
                }
            }
            else
            {
                int j = ship.direction == 180 ? 1 : -1;
                for (int i = 0; i < ship.size; i++)
                {
                    img = images[i];
                    Place(x, y + (j * i));
                }
            }

            if (remaining == 0)
            {
                Phase2();
            }
            else 
            {
                SelectShip(shipID);
            }
        }
        public void Phase2() 
        {
            DeleteItems();
        }
        private void DeleteItems() 
        {
            shipSelection.Clear();
            shipAmount.Clear();
            rightMenuPanel.Dispose();
        }

        void RotatedImage(Image img, int direction)
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
        private void SelectShip(int ID)
        {
            int r = inventory[ID].Count() - int.Parse(shipAmount[ID].Text);
            if (r >= inventory[ID].Count)
            {
                ID = -1; selectedShip = null;
            }
            else
            {
                selectedShip = inventory[ID][r];

                Image img = null;
                switch (ID)
                {
                    case 0:
                        img = Resources.Carrier;
                        break;
                    case 1:
                        img = Resources.Battleship;
                        break;
                    case 2:
                        img = Resources.Destroyer;
                        break;
                    case 3:
                        img = Resources.Submarine;
                        break;
                    case 4:
                        img = Resources.PatrolBoat;
                        break;
                    default:
                        break;
                }

                RotatePB.Image = img;
                RotatedImage(img, selectedShip.direction);
            }
        }
        TableLayoutPanel[] RightPanels() 
        {
            string[,] ships = new string[5, 2] { { "Carrier", "1" }, { "Battleship", "2" }, { "Destroyer", "3" }, { "Submarine", "4" }, { "PatrolBoat", "5" } };
            Image[] shipImg = new Image[5] { Resources.Carrier, Resources.Battleship, Resources.Destroyer, Resources.Submarine, Resources.PatrolBoat };

            TableLayoutPanel RotatePanel = new TableLayoutPanel() { Anchor = str, BackColor = Color.Silver, CellBorderStyle = TableLayoutPanelCellBorderStyle.Single, ColumnCount = 3, Margin = new Padding(0) };
            RotatePanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            RotatePanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70F));
            RotatePanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            RotatePanel.Controls.Add(new Button { Anchor = str, BackgroundImage = Resources.arrow1, BackgroundImageLayout = ImageLayout.Zoom, Margin = new Padding(0), Name = "RotateRightBtn", Text = "", BackColor = Color.DimGray }, 2, 0);
            RotatePanel.Controls[RotatePanel.Controls.Count - 1].Click += new EventHandler(delegate (object sender, EventArgs e) { RotateImg(sender, e, 90); });
            RotatePanel.Controls.Add(new Button { Anchor = str, BackgroundImage = Resources.arrow2, BackgroundImageLayout = ImageLayout.Zoom, Margin = new Padding(0), Name = "RotateLeftBtn", Text = "", BackColor = Color.DimGray }, 0, 0);
            RotatePanel.Controls[RotatePanel.Controls.Count - 1].Click += new EventHandler(delegate (object sender, EventArgs e) { RotateImg(sender, e, -90); });
            RotatePanel.Controls.Add(RotatePB, 1, 0);

            TableLayoutPanel shipsPanel = new TableLayoutPanel() { Anchor = str, CellBorderStyle = TableLayoutPanelCellBorderStyle.Outset, ColumnCount = 2, Margin = new Padding(0), RowCount = 6 };
            shipsPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70f));
            shipsPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30f));
            shipsPanel.RowStyles.Add(new ColumnStyle(SizeType.Percent, 10f));
            shipsPanel.Controls.Add(new Label() { Anchor = str, BackColor = Color.DimGray, Margin = new Padding(0), Text = "Ship", TextAlign = ContentAlignment.MiddleCenter, ForeColor = Color.White }, 0, 0);
            shipsPanel.Controls.Add(new Label() { Anchor = str, BackColor = Color.DimGray, Margin = new Padding(0), Text = "No.", TextAlign = ContentAlignment.MiddleCenter, ForeColor = Color.White }, 1, 0);

            for (int i = 1; i < 6; i++)
            {
                shipSelection.Add(new PictureBox(){ Anchor = str, BackColor = Color.Silver, Image = shipImg[i - 1], Margin = new Padding(0), Name = ships[i - 1, 0] + "IMG", SizeMode = PictureBoxSizeMode.StretchImage});
                int id = i - 1;
                shipSelection.Last().Click += delegate (object sender, EventArgs e) { SelectID(sender, e, id); };

                shipAmount.Add(new Label(){ Anchor = str, BackColor = Color.Gray, Font = new Font("Microsoft Sans Serif", 6.75F, FontStyle.Regular), Margin = new Padding(0), Text = ships[i - 1, 1], TextAlign = ContentAlignment.MiddleCenter, Name = ships[i - 1, 0] + "Lb", ForeColor = Color.White });
                shipsPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 18f));
                shipsPanel.Controls.Add(shipSelection.Last(), 0, i);
                shipsPanel.Controls.Add(shipAmount.Last(), 1, i);
            }

            void SelectID(object sender, EventArgs e, int ID)
            {
                if (int.Parse(shipAmount[ID].Text) > 0)
                {
                    SelectShip(ID);

                    if (shipID != -1 && shipAmount[shipID].BackColor != Color.Black) //sets back the previously selected
                    {
                        shipAmount[shipID].BackColor = Color.Gray;
                        shipSelection[shipID].BackColor = Color.Silver;
                    }
                    shipID = ID;
                    
                    label1.Text = selectedShip.direction+"";

                    shipAmount[shipID].BackColor = Color.CadetBlue;
                    shipSelection[shipID].BackColor = Color.CadetBlue;
                }
            }

            void RotateImg(object sender, EventArgs e, int dir)
            {
                selectedShip.direction += dir;
                if (selectedShip.direction < 0) { selectedShip.direction = 270; }
                else if(selectedShip.direction==360) { selectedShip.direction = 0; }
                SelectShip(shipID);
            }
            return new TableLayoutPanel[] { shipsPanel, RotatePanel};
        }
    }
}
