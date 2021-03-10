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
        
        private DateTime date1;
        private TimeSpan timeSpan;

        //Hides the menu, opens sudoku game
        private void sudokuButton_Click(object sender, EventArgs e)
        {
            date1 = DateTime.Now;
            this.Visible = false;
            Sudoku sudokuWindow = new Sudoku();
            sudokuWindow.Show();
            sudokuWindow.FormClosed += new FormClosedEventHandler(this.WindowReopen);
            
        }

        //Hides the menu, opens snake game
        private void snakeButton_Click(object sender, EventArgs e)
        {
            date1 = DateTime.Now;
            this.Visible = false;
            Snake snakeWindow = new Snake();
            snakeWindow.Show();
            snakeWindow.FormClosed += new FormClosedEventHandler(this.WindowReopen);
        }

        //Hides the menu, opens battleship game
        private void battleshipButton_Click(object sender, EventArgs e)
        {
            date1 = DateTime.Now;
            this.Visible = false;
            Battleship battleshipWindow = new Battleship();
            battleshipWindow.Show();
            battleshipWindow.FormClosed += new FormClosedEventHandler(this.WindowReopen);
        }

        //Reopening menu window on the close of one of the games
        private void WindowReopen(object sender, EventArgs e)
        {
            timeSpan = DateTime.Now - date1;
            SqlConnectionHandler.RunNonQuery($"INSERT INTO times (timeSpent) VALUES('{timeSpan.ToString("c")}')");
            this.Visible = true;
        }

        private void statisticsButton_Click(object sender, EventArgs e)
        {
            if (SqlConnectionHandler.InitialSetup() == 0)
            {
                this.Visible = false;
                Statistics statisticsWindow = new Statistics();
                statisticsWindow.Show();
                statisticsWindow.FormClosed += new FormClosedEventHandler(this.WindowReopen);
            }
        }
    }
}
