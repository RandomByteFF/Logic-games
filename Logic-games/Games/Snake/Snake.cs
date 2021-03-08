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
        private int yOffset = 80;
        private int tileSize = 40;
        private int Tick = 200; //Move time
        private Color backColor1 = Color.FromArgb(170, 215, 85);
        private Color backColor2 = Color.FromArgb(162, 209, 73);
        private Color backgroundColor = Color.FromArgb(74, 117, 44);
        /*private Color backColor1 = Color.FromArgb(0, 0, 0);
        private Color backColor2 = Color.FromArgb(255, 255, 255);*/
        //Different color palette for debugging
        private Vector2 nextMove;
        private Vector2 previousMove = new Vector2();
        private Vector2 applePosition;
        private PictureBox appleSprite;

        private List<Vector2> positions = new List<Vector2>();
        private List<PictureBox> activeSprites = new List<PictureBox>();

        public int score = -1;
        bool headColor = false;
        bool tailColor = true;

        Timer timer = new Timer();
        Random rng = new Random();

        public Snake()
        {
            InitializeComponent();
        }

        private void Snake_Load(object sender, EventArgs e)
        {
            Width = 1016;
            Height = 1039;
            BackColor = backgroundColor;
            appleIcon.BackColor = Color.Transparent;
            recordIcon.BackColor = Color.Transparent;
            nextMove = new Vector2(0, 1, tileSize);
            panel.Visible = false;
            panel.BackColor = backgroundColor;
            DoubleBuffered = true;
            timer.Tick += new EventHandler(Update);
            startButton.Location = new Point((Width / 2) - (startButton.Size.Width / 2), (Height / 2) - (startButton.Size.Height / 2));
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            DrawBackGround(e.Graphics);
        }

        private void DrawBackGround(Graphics g) {
            Brush backPen1 = new SolidBrush(backColor1);
            Brush backPen2 = new SolidBrush(backColor2);
            bool activeLine = true;
            bool activePen = true;

            for (int i = yOffset; i < Height-tileSize; i += tileSize)
            {
                activePen = activeLine;
                activeLine = !activeLine;
                for (int j = xOffset; j <= ClientRectangle.Width; j += tileSize)
                {
                    Rectangle rec = new Rectangle(j, i, tileSize, tileSize);
                    g.FillRectangle(activePen ? backPen1 : backPen2, rec);
                    activePen = !activePen;
                }
            }
        }

        private void SnakeSpawn() {
            for (int i = 4; i > 1; i--)
            {
                positions.Add(new Vector2(0, i, tileSize));
            }
            CreateSprite(Properties.Resources.head, positions[0]);
            CreateSprite(Properties.Resources.body, positions[1]);
            CreateSprite(Properties.Resources.tail2, positions[2]);
            bool color = true;
            for (int i = 0; i < activeSprites.Count; i++)
            {
                activeSprites[i].BackColor = color ? backColor1 : backColor2;
                color = !color;
            }
        }

        private void StartGame() {
            var highScore = SqlConnectionHandler.Query("SELECT MAX(score) FROM snake");
            if (highScore.Count != 0 && highScore[0][0] != "")
            {
                recordText.Text = highScore[0][0];
            }
            else recordText.Text = "0";
            SnakeSpawn();

            timer.Interval = Tick;

            CreateSprite(Properties.Resources.apple, new Vector2(), -2);
            NewApplePosition();
            headColor = false;
            tailColor = true;

            timer.Start();
        }

        //Runs for every tick
        private void Update(object sender, EventArgs e) {
            Bitmap headImage = Properties.Resources.head;
            Bitmap bodyImage = Properties.Resources.body;
            Bitmap turnImage = Properties.Resources.turn2;
            Bitmap tailImage = Properties.Resources.tail2;

            Vector2 previousHeadPosition = positions[0];
            Vector2 nextLocation = positions[0] + nextMove;

            activeSprites[0].Image = RotateSnake(activeSprites[0], positions[0], nextMove, headImage);
            positions.Insert(0, positions[0] + nextMove);
            activeSprites[0].Location = new Point(positions[0].x, positions[0].y); //Head position
            activeSprites[0].BackColor = headColor ? backColor1 : backColor2; //Head backColor

            int bodyIndex = activeSprites.Count - 2;
            Bitmap replaceImage = previousHeadPosition.facing != nextMove.facing ? turnImage : bodyImage; //Determine if snake turns
            bool pickedUpApple = positions[0] == applePosition;
            if (pickedUpApple)
            {
                replaceImage = (Bitmap)RotateSnake(new PictureBox(), previousHeadPosition, nextMove, replaceImage);
                NewApplePosition();
                CreateSprite(replaceImage, positions[1], 1);
                bodyIndex++;
            }
            else
            {
                replaceImage = (Bitmap)RotateSnake(activeSprites[bodyIndex], previousHeadPosition, nextMove, replaceImage);
                positions.RemoveAt(positions.Count - 1);
                PictureBox temp = activeSprites[bodyIndex];
                activeSprites.RemoveAt(bodyIndex);
                activeSprites.Insert(1, temp);
                activeSprites[1].Location = new Point(positions[1].x, positions[1].y); //Moves item before tail to after head
            }
            activeSprites[1].BackColor = !headColor ? backColor1 : backColor2;

            headColor = !headColor;
            if (!pickedUpApple)
            {
                tailColor = !tailColor;
            }
            int tailIndex = activeSprites.Count - 1;
            activeSprites[tailIndex].Image = RotateSnake(activeSprites[tailIndex], positions[tailIndex], positions[bodyIndex], tailImage); //tail rotation
            activeSprites[tailIndex].Location = new Point(positions[tailIndex].x, positions[tailIndex].y); //tail location
            activeSprites[tailIndex].BackColor = tailColor ? backColor1 : backColor2;

            if (Vector2.Contains(positions, nextLocation))
            {
                int at = Vector2.ContainsAt(positions, nextLocation);
                activeSprites[0].BackgroundImage = activeSprites[at].Image;
                activeSprites[0].BackgroundImageLayout = ImageLayout.Stretch;
                GameEnd();
            }

            if (nextLocation.x >= ClientRectangle.Width || nextLocation.x < xOffset || nextLocation.y >= ClientRectangle.Height || nextLocation.y < yOffset) 
            {
                if (nextLocation.y < yOffset) 
                {
                    activeSprites[0].BackColor = backgroundColor;
                }
                GameEnd();
            }

            previousMove = nextMove;
        }

        private void CreateSprite(Bitmap file, Vector2 position, int addToActiveSprites = -1) {
            PictureBox pictureBox = new PictureBox();
            pictureBox.Image = (Image)file;
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox.Location = new Point(position.x, position.y);
            pictureBox.Size = new Size(tileSize, tileSize);
            if (addToActiveSprites == -1) activeSprites.Add(pictureBox);
            else if (addToActiveSprites == -2) appleSprite = pictureBox;
            else activeSprites.Insert(addToActiveSprites, pictureBox);
            this.Controls.Add(pictureBox);
        }

        private void Snake_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down) // ˇ
            {
                if (previousMove.facing != 2) 
                {
                    nextMove = new Vector2(0, 1, tileSize);
                    nextMove.facing = 0;
                }
            }
            else if (e.KeyCode == Keys.Left) // <
            {
                if (previousMove.facing != 3)
                {
                    nextMove = new Vector2(-1, 0, tileSize);
                    nextMove.facing = 1;
                }
            }
            else if (e.KeyCode == Keys.Up) // ^
            {
                if (previousMove.facing != 0)
                {
                    nextMove = new Vector2(0, -1, tileSize);
                    nextMove.facing = 2;
                }
            }
            else if (e.KeyCode == Keys.Right) // >
            {
                if (previousMove.facing != 1)
                {
                    nextMove = new Vector2(1, 0, tileSize);
                    nextMove.facing = 3;
                }
            }
        }

        private Image RotateSnake(PictureBox pic, Vector2 current, Vector2 target, Image original) {
            pic.Image = original;
            int ret = target.facing;
            switch (ret) { //Case 0: not required because default sprite faces downwards
                case 1:
                    if (current.facing == 0) pic.Image.RotateFlip(RotateFlipType.Rotate90FlipY);
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

        private void GameEnd() 
        {
            timer.Stop();
            SqlConnectionHandler.RunNonQuery($"INSERT INTO snake (score) VALUES({score})");
            panel.Location = new Point((Width/2)-(panel.Size.Width/2), (Height / 2) - (panel.Size.Height / 2));
            panel.Visible = true;
        }

        private void Snake_SizeChanged(object sender, EventArgs e)
        {
            Invalidate();
        }

        private void NewApplePosition() 
        {
            Vector2 start = new Vector2(xOffset/tileSize, yOffset/tileSize, tileSize);
            Vector2 end = new Vector2((Width - xOffset) / tileSize, (Height - yOffset)/tileSize, tileSize);
            Vector2 final = Vector2.RangeExclude(rng, start, end, positions, tileSize);
            appleSprite.Location = new Point(final.x, final.y);
            applePosition = final;
            appleSprite.BackColor = (final.xGrid + final.yGrid) % 2 == 0 ? backColor1 : backColor2;
            scoreText.Text = Convert.ToString(++score);
        }

        private void restartButton_Click(object sender, EventArgs e)
        {
            foreach (PictureBox i in activeSprites) 
            {
                i.Dispose();
            }
            activeSprites.Clear();
            positions.Clear();
            panel.Visible = false;
            score = -1;
            nextMove = new Vector2(0, 1, tileSize);
            appleSprite.Dispose();
            Focus();
            StartGame();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            panel.Visible = false;
            Close();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            startButton.Visible = false;
            Focus();
            StartGame();
        }
    }
}
