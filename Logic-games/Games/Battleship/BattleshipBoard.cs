using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Logic_games.Properties;
using Logic_games.Games.Battleship;
namespace Logic_games.Games.Battleship
{
    public class BattleshipBoard: TableLayoutPanel
    {
        private AnchorStyles str = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        public PictureBox[,] cells = new PictureBox[10,10];
        public event EventHandler<ImgClickEventArgs> ImgClick;
        public class ImgClickEventArgs : EventArgs
        {
            public int[] coordinates;
        }

        public BattleshipBoard(List<BattleshipShip> shipsDisplayed)
        {
            SetUp();
            DrawCells();
        }

        private void SetUp()
        {
            Hide();

            Size = new Size(400, 400);
            Anchor = AnchorStyles.None;
            BackgroundImage = Resources.water24;
            CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            ColumnCount = 11;
            RowCount = 11;

            ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 5F));
            RowStyles.Add(new ColumnStyle(SizeType.Percent, 5F));
            for (int i = 0; i < 10; i++)
            {
                ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 9.5F));
                RowStyles.Add(new ColumnStyle(SizeType.Percent, 9.5F));
            }

            Controls.Add(new Label() { Text = "", Padding = new Padding(0), Margin = new Padding(0), BackColor = Color.Gray, Anchor = str }, 0, 0);
            for (int i = 1; i < 11; i++)
            {
                Controls.Add(new Label() { Text = Convert.ToChar(64 + i) + "", Padding = new Padding(0), Margin = new Padding(0), TextAlign = (ContentAlignment)32, BackColor = Color.Gray, Anchor = str }, 0, i);
                Controls.Add(new Label() { Text = i + "", Padding = new Padding(0), Margin = new Padding(0), TextAlign = (ContentAlignment)32, BackColor = Color.Gray, Anchor = str }, i, 0);
            }
            Show();
        }

        private void DrawCells()
        {
            //CELLS
            for (int i = 1; i < 11; i++)
            {
                for (int j = 1; j < 11; j++)
                {
                    cells[i-1, j-1]= new PictureBox() { Anchor = str, BackColor = Color.Transparent, BackgroundImageLayout = ImageLayout.Stretch, Margin = new Padding(0), Tag = "i" + " j", SizeMode= PictureBoxSizeMode.Zoom };
                    Controls.Add(cells[i - 1, j - 1], i, j);
                    int[] coords = new int[] { i, j };
                    try
                    {
                        cells[i - 1, j - 1].Click += delegate (object sender, EventArgs e) { ThisClick(sender, e, coords); };
                    }
                    catch 
                    { }
                }
            }

            void ThisClick(object sender, EventArgs e, int[] c)
            {
                ImgClick?.Invoke(this, new ImgClickEventArgs { coordinates = c });
            }
        }

        //DrawGuesses
        public void DrawGuessBoard(int[,] map)
        {
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    if (map[i, j] == 0) { cells[i, j].Image = Resources.Notclicked; }
                    else if (map[i, j] == 1) { cells[i, j].Image = Resources.Miss; }
                    else { cells[i, j].Image = Resources.Hit; }
                }
            }
        }

        //ADDING ONE SINGLE SHIP
        public void UpdateShips(BattleshipShip ship)
        {
            for (int i = 0; i < ship.size; i++)
            {
                PictureBox cell = (PictureBox)this.GetControlFromPosition(ship.positions[i][0], ship.positions[i][1]);
                Image img= ship.components[i];
                cell.BackgroundImage = img;
            }
        }
    }
}