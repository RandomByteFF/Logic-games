using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Logic_games.SnakeClasses;

namespace Logic_games
{
    public partial class Snake : Form
    {
        private int xOffset = 0;
        private int yOffset = 0;
        private int tileSize = 40;
        private int Tick = 200; //Move time
        private Color backColor1 = Color.FromArgb(170, 215, 85);
        private Color backColor2 = Color.FromArgb(162, 209, 73);
        private Vector2 nextMove;

        private List<Vector2> positions = new List<Vector2>();
        private List<PictureBox> activeSprites = new List<PictureBox>();
        
        public Snake()
        {
            InitializeComponent();
        }

        private void Snake_Load(object sender, EventArgs e)
        {
            Width = 1016;
            Height = 1039;
            nextMove = new Vector2(0, 1, tileSize);
            StartGame();
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

        private void StartGame() {
            positions.Add(new Vector2(0, 3, tileSize));
            positions.Add(new Vector2(0, 2, tileSize));
            positions.Add(new Vector2(0, 1, tileSize));


            Timer timer = new Timer();
            timer.Tick += new EventHandler(Update);
            timer.Interval = Tick;

            CreatePicturebox(Properties.Resources.head, positions[0]);

            timer.Start();
        }

        //Runs for every tick
        private void Update(object sender, EventArgs e) {
            positions[0] = positions[0] + nextMove;

            for (int i = 0; i < activeSprites.Count; i++)
            {
                activeSprites[i].Location = new Point(positions[i].x, positions[i].y);
            }
        }

        private void CreatePicturebox(Bitmap file, Vector2 position) {
            PictureBox pictureBox = new PictureBox();
            pictureBox.Image = (Image)file;
            pictureBox.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox.Location = new Point(position.x, position.y);
            activeSprites.Add(pictureBox);
            this.Controls.Add(pictureBox);
        }

        private void Snake_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down) // ˇ
            {
                nextMove = new Vector2(0, 1, tileSize);
            }

            else if (e.KeyCode == Keys.Left) // <
            {
                nextMove = new Vector2(-1, 0, tileSize);
            }

            else if (e.KeyCode == Keys.Up) // ^
            {
                nextMove = new Vector2(0, -1, tileSize);
            }

            else if (e.KeyCode == Keys.Right) // >
            {
                nextMove = new Vector2(1, 0, tileSize);
            }
        }
    }
}
