using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Logic_games.Properties;
using Logic_games.Games.Battleship;

namespace Logic_games.Games.Battleship
{
    class phase1
    {
        TableLayoutPanel gamePanel, gameLP1, rightMenuPanel;
        public static AnchorStyles str = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        static int carrierC = 1, battleshipC = 0, destroyerC = 0, submarineC = 0, patrolboatC = 1, shipID = -1;
        //static int carrierC = 1, battleshipC = 2, destroyerC = 3, submarineC = 4, patrolboatC = 5, shipID = -1;
        public int remaining = carrierC + battleshipC + destroyerC + submarineC + patrolboatC;
        int[,] placement;
        PictureBox RotatePB = new PictureBox { Anchor = str, Margin = new Padding(0), Name = "RotatePB", SizeMode = PictureBoxSizeMode.Zoom };
        List<PictureBox> shipSelection = new List<PictureBox>();
        List<Label> shipAmount = new List<Label>();
        public List<List<Ship>> inventory;
        Ship selectedShip;
        Player player;

        public phase1(TableLayoutPanel game, TableLayoutPanel gameLP, TableLayoutPanel right, Player p) 
        {
            player = p;
            gameLP1 = gameLP;
            gamePanel = game; //board
            rightMenuPanel = right; // right side
            placement = player.player;
        }

        public phase1(int[,] table) 
        {
            placement = table;
        }

        public void SetupGame() //GENERATING MAIN TABLE
        {
            playerBoard board = new playerBoard(gamePanel);
            PlaceShips();
            gameLP1.Visible = true;
            board.ImgClick += ImageClick;
            void ImageClick(object sender, playerBoard.ImgClickEventArgs e) 
            {
                if (shipID != -1 && selectedShip != null)
                {
                    selectedShip.X = e.coordinates[0] - 1;
                    selectedShip.Y = e.coordinates[1] - 1;
                    if (Placeable(e.coordinates, selectedShip))
                    {
                        TakeShip(shipID);
                    }
                }
            }
        }
        private void PlaceShips() //CREATING THE MENU ON THE RIGHT
        {
            TableLayoutPanel[] Panels = RightPanels();
            rightMenuPanel.Controls.Add(Panels[0], 0, 0);
            rightMenuPanel.Controls.Add(Panels[1], 0, 1);
            inventory=ShipsToInventory(false);
        }
        public List<List<Ship>> ShipsToInventory(bool random)
        {
            int r = remaining;
            List<Ship> carriers = new List<Ship>(), battleships = new List<Ship>(), destroyers = new List<Ship>(), submarines = new List<Ship>(), patrolboats = new List<Ship>();
            for (int i = 0; i < carrierC; i++) { carriers.Add(new Ship(5, new Image[] { Resources.carrier1, Resources.carrier2, Resources.carrier3, Resources.carrier4, Resources.carrier5 }, random, r--)); }
            for (int i = 0; i < battleshipC; i++) { battleships.Add(new Ship(4, new Image[] { Resources.battleship1, Resources.battleship2, Resources.battleship3, Resources.battleship4 }, random, r--)); }
            for (int i = 0; i < destroyerC; i++) { destroyers.Add(new Ship(3, new Image[] { Resources.destroyer1, Resources.destroyer2, Resources.destroyer3 }, random, r--)); }
            for (int i = 0; i < submarineC; i++) { submarines.Add(new Ship(3, new Image[] { Resources.submarine1, Resources.submarine2, Resources.submarine3 }, random, r--)); }
            for (int i = 0; i < patrolboatC; i++) { patrolboats.Add(new Ship(2, new Image[] { Resources.patrolBoat1, Resources.patrolBoat2 }, random, r--)); }
            return new List<List<Ship>>() { carriers, battleships, destroyers, submarines, patrolboats };
        }
        private void TakeShip(int shipID)
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

                selectedShip.placeShip(gamePanel, placement);

                if (remaining == 0)
                {
                    Finished?.Invoke(this, EventArgs.Empty);
                }
                else
                {
                    SelectShip(shipID);
                }
            }
        }
        public bool Placeable(int[] c, Ship s)
        {
            bool Check(int i, int max, int change, bool isX)
            {
                if (isX)
                {
                    while (i != max && placement[i, c[1]-1] == 0)
                    {
                        i += change;
                    }
                }
                else
                {
                    while (i != max && placement[c[0] - 1, i] == 0 )
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

            if (s.direction == 90 && c[0] + s.size - 1 < 11)
            {
                return Check(c[0] - 1, c[0] - 1 + s.size, 1, true);
            }
            else if (s.direction == 270 && c[0] - s.size >= 0)
            {
                return Check(c[0] - 1, c[0] - 1 - s.size, -1, true);
            }
            else if (s.direction == 180 && c[1] + s.size - 1 < 11)
            {
                return Check(c[1] - 1, c[1] - 1 + s.size, 1, false);
            }
            else if (s.direction == 0 && c[1] - s.size >= 0)
            {
                return Check(c[1] - 1, c[1] -1 - s.size, -1, false);
            }
            else { return false; }
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
        public static void RotatedImage(Image img, int direction)
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
        public void DeleteItems(int lvl)
        {
            player.inventory = new List<List<Ship>>(inventory);
            remaining = carrierC + battleshipC + destroyerC + submarineC + patrolboatC;
            shipSelection.Clear();
            shipAmount.Clear();
            if (lvl == 2)
            {
                rightMenuPanel.Dispose();
                gamePanel.Dispose();
                gameLP1.Controls.Clear();
                gameLP1.Visible = false;
            }
            else 
            {
                rightMenuPanel.Controls.Clear();
                gamePanel.Controls.Clear();
            }
        }
        private TableLayoutPanel[] RightPanels()
        {
            string[,] ships = new string[5, 2] { { "Carrier", "" + carrierC }, { "Battleship", "" + battleshipC }, { "Destroyer", "" + destroyerC }, { "Submarine", "" + submarineC }, { "PatrolBoat", "" + patrolboatC } };
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
                shipSelection.Add(new PictureBox() { Anchor = str, BackColor = Color.Silver, Image = shipImg[i - 1], Margin = new Padding(0), Name = ships[i - 1, 0] + "IMG", SizeMode = PictureBoxSizeMode.StretchImage });
                int id = i - 1;
                shipSelection.Last().Click += delegate (object sender, EventArgs e) { SelectID(sender, e, id); };

                shipAmount.Add(new Label() { Anchor = str, BackColor = Color.Gray, Margin = new Padding(0), Text = ships[i - 1, 1], TextAlign = ContentAlignment.MiddleCenter, Name = ships[i - 1, 0] + "Lb", ForeColor = Color.White });
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
                    shipAmount[shipID].BackColor = Color.CadetBlue;
                    shipSelection[shipID].BackColor = Color.CadetBlue;
                }
            }

            void RotateImg(object sender, EventArgs e, int diff)
            {
                if (selectedShip != null)
                {
                    selectedShip.dir(diff);
                    SelectShip(shipID);
                }
            }
            return new TableLayoutPanel[] { shipsPanel, RotatePanel };
        }

        public event EventHandler Finished;
    }
}
