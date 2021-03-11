using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Logic_games.Properties;
using Logic_games.Games.Battleship;

namespace Logic_games.Games.Battleship
{
    public partial class BattleshipPlacement : Form
    {
        //VARIABLES
        public List<BattleshipShip> shipsPlaced= new List<BattleshipShip>();
        public BattleshipBoard placeBoard;

        private List<PictureBox> selectPictureBox;
        private List<Label>selectLabel;
        private BattleshipShip selectedShip;
        
        private int shipID=1;
        private int selected = -1;
        private int goal=0;

        //GETTING NUMBERS AND PREPARING WINDOW
        public BattleshipPlacement(int[] shipNumbers)
        {
            InitializeComponent();
            DoubleBuffered = true;
            Hide();
            SetUp();

            foreach (int n in shipNumbers) { goal += n; } //COUNTING SHIPS

            placeBoard = new BattleshipBoard(shipsPlaced);
            placementPanel.Controls.Add(placeBoard);

            placeBoard.ImgClick += PlaceShip;
        }
        //PREPARATION
        private void SetUp()
        {
            selectPictureBox = new List<PictureBox>() { carrierPictureBox, battleshipPictureBox, destroyerPictureBox, submarinePictureBox, patrolBoatPictureBox };
            selectLabel = new List<Label>() { carrierLabel, battleshipLabel, destroyerLabel, submarineLabel, patrolBoatLabel };

            for (int i = 0; i < 5; i++) //ADDING SELECT OPTION ON THE RIGHT SIDE
            {
                int currentId = i; //FOR REFERENCE
                selectPictureBox[i].Click += delegate (object sender, EventArgs e) { SelectId(sender, e, currentId); };
            }

            void SelectId(object sender, EventArgs e, int idClicked)
            {
                for (int i = 0; i < 5; i++)
                {
                    if (selectLabel[i].BackColor != Color.Black) 
                    {
                        //SETTING BACK TO GRAY
                        selectLabel[i].BackColor = Color.DimGray;
                        selectPictureBox[i].BackColor = Color.Gainsboro;
                    }
                }
                if (selectLabel[idClicked].BackColor != Color.Black) //IF AVAILABLE
                {
                    selectPictureBox[idClicked].BackColor = Color.CadetBlue;
                    selectLabel[idClicked].BackColor = Color.CadetBlue;

                    selected = idClicked;
                    selectedShip = new BattleshipShip(idClicked, shipID); //GIVING SHIP TYPE AND AN ID
                    SetRotatePictureBox();
                }
            }
        }

        //SHIP PLACEMENT
        public void PlaceShip(object sender, BattleshipBoard.ImgClickEventArgs e) 
        {
            if (selectedShip != null && Placeable(selectedShip, shipsPlaced, e.coordinates)) //IF SELECTED AND PLACEABLE
            {
                shipsPlaced.Add(selectedShip);
                //REMAINING NUMBER OF SHIPS
                int remaining = int.Parse(selectLabel[selected].Text);
                selectLabel[selected].Text = Convert.ToString(--remaining);
                if (remaining == 0) 
                {
                    selectLabel[selected].BackColor = Color.Black;
                    selectPictureBox[selected].BackColor = Color.Black;
                    //SETTINB BACK TO DEFAULT
                    rotatePictureBox.Image = null;
                    selected = -1;
                }
                placeBoard.UpdateShips(selectedShip); //ADDING SHIP TO BOARD

                shipID += 1;
                if (selected != -1) { selectedShip = new BattleshipShip(selected, shipID); } //CREATING NEW SHIP IF IT'S IN THE INVENTORY

                SetRotatePictureBox();
                //ENDING THIS PHASE
                if (shipID > goal) 
                {
                    placeBoard.ImgClick -= PlaceShip;
                    OnPlacedAllShips?.Invoke(this, new PlacedAllShips { inventory=shipsPlaced, myBoard=placeBoard});
                    shipID = 1;
                    Close();
                }
            }
        }

        public bool Placeable(BattleshipShip ship, List<BattleshipShip> otherShips, int[] coordinates) 
        {
            int xDiff=0, yDiff=0;
            //SETTING CHECKER FOR DIRECTION
            if (ship.direction == 90) { xDiff = 1; }
            else if (ship.direction == 270) { xDiff = -1; }
            else if (ship.direction==180) { yDiff = 1; }
            else { yDiff = -1;  }

            if (Checker(xDiff, yDiff))
            {
                //ADDING COORDINATES TO SHIP
                for (int i = 0; i < ship.size; i++) { ship.positions.Add(new int[] { coordinates[0] + (i * xDiff), coordinates[1] + (i * yDiff) }); }
                //COMPARING BOATS
                foreach (BattleshipShip item in otherShips)
                {
                    foreach (int[] pos in item.positions)
                    {
                        for (int i = 0; i < ship.positions.Count; i++)
                        {
                            int[] x = ship.positions[i];
                            if (pos[0] == x[0] && pos[1]== x[1]) 
                            {
                                ship.positions.Clear();
                                return false;
                            }
                        }
                    }
                }
                //THERE ARE NO PROBLEMS ->
                return true;
            }
            else 
            {
                return false;
            }

            bool Checker(int x, int y) //IF IT COULD BE ON THE BOARD
            {
                int i = 0;
                int currX = coordinates[0], currY = coordinates[1];
                while ((currX<11 && currX>0)&& (currY < 11 && currY > 0) && i<ship.size)
                {
                    i++;
                    currX = coordinates[0] + (i * x);
                    currY = coordinates[1] + (i * y);
                }
                //RETURNING RESULT
                if (i == ship.size)
                {
                    return true;
                }
                else 
                {
                    return false;
                }
            }
        }

        //ROTATEPICTUREBOX IMAGE SETTING
        private void SetRotatePictureBox()
        {
            if (selected != -1)
            {
                Image img = null;
                switch (selected)
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
                }
                rotatePictureBox.Image = img;

                if (selectedShip.direction == 0) { img.RotateFlip(RotateFlipType.Rotate270FlipNone); }
                else if (selectedShip.direction == 180) { img.RotateFlip(RotateFlipType.Rotate90FlipNone); }
                else if (selectedShip.direction == 270) { img.RotateFlip(RotateFlipType.Rotate180FlipNone); }
            }
        }

        //BUTTONS
        private void rotateRightButton_Click(object sender, EventArgs e)
        {
            selectedShip.dir(+90);
            SetRotatePictureBox();
        }

        private void rotateLeftButton_Click(object sender, EventArgs e)
        {
            selectedShip.dir(-90);
            SetRotatePictureBox();
        }

        //EVENTS
        public event EventHandler<PlacedAllShips> OnPlacedAllShips;
        public class PlacedAllShips : EventArgs
        {
            public List<BattleshipShip> inventory;
            public BattleshipBoard myBoard;
        }
    }
}
