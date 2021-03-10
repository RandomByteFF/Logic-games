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
    public partial class Statistics : Form
    {
        public Statistics()
        {
            InitializeComponent();
        }

        private void Statistics_Load(object sender, EventArgs e)
        {
            PlayTime();
            snakeLabel.Text = $"Snake - {Attempts("snake")} games";
            battleshipLabel.Text = $"Battleship - {BattleshipWins()} wins out of {Attempts("battleship")} against the bot";
        }

        private void PlayTime() 
        {
            List<List<string>> result = SqlConnectionHandler.Query("SELECT timeSpent FROM times");
            int seconds = 0;
            foreach (List<string> item in result)
            {
                string[] toTime = item[0].Split(':');
                seconds += int.Parse(toTime[0]) * 3600 + int.Parse(toTime[1]) * 60 + int.Parse(toTime[2]);
            }
            TimeSpan t = TimeSpan.FromSeconds(seconds);
            playTimeLabel.Text = "Play time:" + t.ToString("c");
        }

        private int Attempts(string table)
        {
            List<List<string>> result = SqlConnectionHandler.Query($"SELECT COUNT(id) FROM {table}");
            return int.Parse(result[0][0]);
        }

        private int BattleshipWins() 
        {
            List<List<string>> sum = SqlConnectionHandler.Query($"SELECT sum(score) FROM battleship WHERE score = 1");
            return int.Parse(sum[0][0]);
        }
    }
}
