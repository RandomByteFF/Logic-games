﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Logic_games.Properties;
using Logic_games.Games.Battleship;

namespace Logic_games.Games.Battleship
{
    class playerBoard
    {
        public event EventHandler<ImgClickEventArgs> ImgClick;
        public class ImgClickEventArgs : EventArgs
        {
            public int[] coordinates;
        }

        public TableLayoutPanel gamePanel;
        public playerBoard(TableLayoutPanel gp)
        {
            gamePanel = gp;
            Setup(gamePanel);
        }

        public void Reset() 
        {
            gamePanel.Controls.Clear();
            Setup(gamePanel);
        }

        public void InventoryToBoard(List<List<Ship>> Inventory, TableLayoutPanel board)
        {
            foreach (List<Ship> type in Inventory)
            {
                foreach (Ship s in type)
                {
                    s.placeShip(board, new int[10, 10]);
                }
            }
        }

        public void GuessBoard(int[,] map) 
        {
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    Image[] states = new Image[] { Resources.Notclicked, Resources.Miss, Resources.Hit };
                    PictureBox cell = (PictureBox)gamePanel.GetControlFromPosition(i + 1, j + 1);
                    cell.SizeMode = PictureBoxSizeMode.Zoom;
                    cell.Image =states[map[i, j]];
                }
            }
        }

        public void Setup(TableLayoutPanel gamePanel) 
        {
            gamePanel.Anchor = AnchorStyles.None;
            gamePanel.BackgroundImage = Resources.water24;
            gamePanel.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            gamePanel.ColumnCount = 11;
            gamePanel.RowCount = 11;
            gamePanel.ColumnStyles.Clear();
            gamePanel.RowStyles.Clear();
            gamePanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 5F));
            gamePanel.RowStyles.Add(new ColumnStyle(SizeType.Percent, 5F));
            for (int i = 0; i < 10; i++)
            {
                gamePanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 9.5F));
                gamePanel.RowStyles.Add(new ColumnStyle(SizeType.Percent, 9.5F));
            }
            gamePanel.Size = new Size(400, 400);

            //HEADERS
            gamePanel.Controls.Add(new Label() { Text = "", Padding = new Padding(0), Margin = new Padding(0), BackColor = Color.Gray, Anchor = phase1.str }, 0, 0);
            for (int i = 1; i < 11; i++)
            {
                gamePanel.Controls.Add(new Label() { Text = Convert.ToChar(64 + i) + "", Padding = new Padding(0), Margin = new Padding(0), TextAlign = (ContentAlignment)32, BackColor = Color.Gray, Anchor = phase1.str }, 0, i);
                gamePanel.Controls.Add(new Label() { Text = i + "", Padding = new Padding(0), Margin = new Padding(0), TextAlign = (ContentAlignment)32, BackColor = Color.Gray, Anchor = phase1.str }, i, 0);
            }
            DefaultCells();
        }

        private void DefaultCells()
        { 
            //CELLS
            for (int i = 1; i< 11; i++)
            {
                for (int j = 1; j< 11; j++)
                {
                    gamePanel.Controls.Add(new PictureBox() { Anchor = phase1.str, BackColor = Color.Transparent, BackgroundImageLayout = ImageLayout.Stretch, Margin = new Padding(0), Tag = "i" + " j" }, i, j);
                    int[] coordinates = new int[] { i, j };
                    gamePanel.Controls[gamePanel.Controls.Count - 1].Click += delegate (object sender, EventArgs e) { ThisClick(sender, e, coordinates);};
                }
            }
            void ThisClick(object sender, EventArgs e, int[] c)
            {
                ImgClick?.Invoke(this, new ImgClickEventArgs { coordinates = c });
            }
        }
    }
}
