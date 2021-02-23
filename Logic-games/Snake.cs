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
    public partial class Snake : Form
    {
        private int xOffset = 0;
        private int yOffset = 0;
        private int tileSize = 40;
        private Color backColor1 = Color.FromArgb(170, 215, 85);
        private Color backColor2 = Color.FromArgb(162, 209, 73);

        public Snake()
        {
            InitializeComponent();
        }

        private void Snake_Load(object sender, EventArgs e)
        {
            Width = 1016;
            Height = 1039;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            DrawBackGround();
        }

        private void DrawBackGround() {
            Graphics g = CreateGraphics();
            Brush backPen1 = new SolidBrush(backColor1);
            Brush backPen2 = new SolidBrush(backColor2);
            bool activePen = true;

            for (int i = yOffset; i < Height-tileSize; i += tileSize)
            {
                for (int j = xOffset; j < Width-tileSize; j += tileSize)
                {
                    Rectangle rec = new Rectangle(j, i, tileSize, tileSize);
                    g.FillRectangle(activePen ? backPen1 : backPen2, rec);
                    activePen = !activePen;
                }
            }
        }
    }
}
