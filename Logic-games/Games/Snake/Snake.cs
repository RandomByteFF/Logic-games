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
        private int Tick = 500; //Move time
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
            positions.Add(new Vector2(0, 6, tileSize));
            positions.Add(new Vector2(0, 5, tileSize));
            positions.Add(new Vector2(0, 4, tileSize));
            positions.Add(new Vector2(0, 3, tileSize));
            positions.Add(new Vector2(0, 2, tileSize));
            positions.Add(new Vector2(0, 1, tileSize));

            Timer timer = new Timer();
            timer.Tick += new EventHandler(Update);
            timer.Interval = Tick;

            CreateSprite(Properties.Resources.head, positions[0]);
            CreateSprite(Properties.Resources.body, positions[1]);
            CreateSprite(Properties.Resources.body, positions[2]);
            CreateSprite(Properties.Resources.body, positions[3]);
            CreateSprite(Properties.Resources.body, positions[4]);
            CreateSprite(Properties.Resources.tail, positions[5]);

            timer.Start();
        }

        //Runs for every tick
        private void Update(object sender, EventArgs e) {
            Vector2 previousHeadPosition = positions[0];
            activeSprites[0].Image = RotateSnake(activeSprites[0], positions[0], nextMove, Properties.Resources.head);
            positions.Insert(0, positions[0] + nextMove);
            positions.RemoveAt(positions.Count-1);
            activeSprites[0].Location = new Point(positions[0].x, positions[0].y); //Head position

            activeSprites[activeSprites.Count-1].Image = RotateSnake(activeSprites[activeSprites.Count-1], positions[positions.Count-1], positions[positions.Count-2], Properties.Resources.tail); //tail rotation
            activeSprites[activeSprites.Count-1].Location = new Point(positions[positions.Count-1].x, positions[positions.Count-1].y); //tail location

            if (previousHeadPosition.facing != nextMove.facing) //Determine if the snake turns
            {
                activeSprites[activeSprites.Count - 2].Image = RotateSnake(activeSprites[activeSprites.Count - 2], previousHeadPosition, nextMove, Properties.Resources.turn);
            }
            else
            {
                activeSprites[activeSprites.Count - 2].Image = RotateSnake(activeSprites[activeSprites.Count - 2], previousHeadPosition, nextMove, Properties.Resources.body);
            }
            
            PictureBox temp = activeSprites[activeSprites.Count - 2];
            activeSprites.RemoveAt(activeSprites.Count - 2);
            activeSprites.Insert(1, temp);
            activeSprites[1].Location = new Point(positions[1].x, positions[1].y); //Moves item before tail to after head
        }

        private void CreateSprite(Bitmap file, Vector2 position) {
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
                nextMove.facing = 0;
            }
            else if (e.KeyCode == Keys.Left) // <
            {
                nextMove = new Vector2(-1, 0, tileSize);
                nextMove.facing = 1;
            }
            else if (e.KeyCode == Keys.Up) // ^
            {
                nextMove = new Vector2(0, -1, tileSize);
                nextMove.facing = 2;
            }
            else if (e.KeyCode == Keys.Right) // >
            {
                nextMove = new Vector2(1, 0, tileSize);
                nextMove.facing = 3;
            }
        }

        private Image RotateSnake(PictureBox pic, Vector2 current, Vector2 target, Image original) {
            pic.Image = original;
            int ret = target.facing;
            switch (ret) { //Case 0: not required because default sprite faces downwards
                case 1:
                    if (current.facing == 0)
                    {
                        pic.Image.RotateFlip(RotateFlipType.Rotate90FlipY);
                    }
                    else pic.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    break;
                case 2:
                    if (current.facing == 1) pic.Image.RotateFlip(RotateFlipType.Rotate180FlipX);
                    else pic.Image.RotateFlip(RotateFlipType.Rotate180FlipNone);
                    break;
                case 3:
                    if (current.facing == 2) pic.Image.RotateFlip(RotateFlipType.Rotate270FlipY);
                    else pic.Image.RotateFlip(RotateFlipType.Rotate270FlipNone);
                    break;
                default:
                    if (current.facing == 3) pic.Image.RotateFlip(RotateFlipType.RotateNoneFlipX);
                    break;
            }
            // 0 - DOWN | 1 - LEFT | 2 - UP | 3 - RIGHT
            return pic.Image;
        }
    }
}
