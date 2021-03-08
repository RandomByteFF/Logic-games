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
    public partial class LogicGames : Form
    {
        public LogicGames()
        {
            int returnValue = SqlConnectionHandler.InitialSetup();
            InitializeComponent();
        }

        //Hides the menu, opens sudoku game
        private void sudokuButton_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Sudoku sudokuWindow = new Sudoku();
            sudokuWindow.Show();
            sudokuWindow.FormClosed += new FormClosedEventHandler(this.WindowReopen);
        }

        //Hides the menu, opens snake game
        private void snakeButton_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Snake snakeWindow = new Snake();
            snakeWindow.Show();
            snakeWindow.FormClosed += new FormClosedEventHandler(this.WindowReopen);
        }

        //Hides the menu, opens battleship game
        private void battleshipButton_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Battleship battleshipWindow = new Battleship();
            battleshipWindow.Show();
            battleshipWindow.FormClosed += new FormClosedEventHandler(this.WindowReopen);
        }

        //Reopening menu window on the close of one of the games
        private void WindowReopen(object sender, EventArgs e)
        {
            this.Visible = true;
        }
    }
}
