using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Logic_games
{
    public partial class Sudoku : Form
    {
        static int mt = 0;
        static int red = 0;
        public Sudoku()
        {
            InitializeComponent();
            int[,] meg = Fel();
            int[,] val = new int[9, 9];
            dataGridView1.DefaultCellStyle.SelectionBackColor = dataGridView1.DefaultCellStyle.BackColor;
            dataGridView1.DefaultCellStyle.SelectionForeColor = dataGridView1.DefaultCellStyle.ForeColor;
            dataGridView1.DefaultCellStyle.Font = new Font("Times New Roman", 14F);
            for (int i = 0; i < 9; i++)
            {
                dataGridView1.Columns.Add(string.Empty, string.Empty);
                dataGridView1.Columns[i].Width = 40;
                if (i != 9)
                {
                    dataGridView1.Rows.Add();
                    dataGridView1.Rows[i].Height = 40;
                }

                Random v = new Random();
                int vv = v.Next(2, 4);
                List<int> ki = new List<int>();
                while (ki.Count < vv)
                {
                    Random rand = new Random();
                    int r = rand.Next(0, 9);
                    if (!ki.Contains(r))
                    {
                        ki.Add(r);
                    }
                }
                for (int j = 0; j < 9; j++)
                {
                    if (!ki.Contains(j))
                    {
                        val[i, j] = meg[i, j];
                    }
                   
                }
            }
            for(int i = 0; i < 9; i++)
            {
                for ( int j = 0; j < 9; j++)
                {
                    dataGridView1[j, i].ReadOnly = true;
                    if (val[i, j] != 0)
                    {
                        dataGridView1[j, i].Value = val[i, j];
                        dataGridView1[j, i].Style.Font = new Font("Times New Roman", 14F, FontStyle.Bold);
                    }
                    else
                    {
                        dataGridView1[j, i].ReadOnly = false;
                        mt++;
                    }
                }
            }
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            
        }

        static int[,] Fel()
        {
            int[,] meg = new int[9, 9];
            string con = "server=localhost;user=root;database=logicgames;password=''";
            MySqlConnection filo = new MySqlConnection(con);
            filo.Open();
            string pille = "megoldas";
            Random val = new Random();
            //pille += Convert.ToString(val.Next(1, 4));
            pille += Convert.ToString(1);
            string ms = "SELECT * FROM " + pille + ";";
            MySqlCommand mc = new MySqlCommand(ms, filo);
            MySqlDataReader rdr = mc.ExecuteReader();
            int i = 0;
            while (rdr.Read())
            {
                for(int j = 0; j < 9; j++)
                 {
                     meg[i, j] = Convert.ToInt32(rdr[j]);
                 }
                i++;
            }
            filo.Close();
            return meg;
        }
        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                string val = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = null;
                bool gode = true;
                int i = 0;
                while(gode && i < 9)
                {
                    if(dataGridView1.Rows[e.RowIndex].Cells[i].Value != null)
                    {
                        if (dataGridView1.Rows[e.RowIndex].Cells[i].Value.ToString() == val) { gode = false; }
                    }
                    if (dataGridView1.Rows[i].Cells[e.ColumnIndex].Value != null)
                    {
                        if (dataGridView1.Rows[i].Cells[e.ColumnIndex].Value.ToString() == val) { gode = false; }
                    }
                    i++;
                }
                int j = 0;
                int k = 0;
                if (e.ColumnIndex < 3) { j = 2; }
                else if (e.ColumnIndex < 6) { j = 5; }
                else { j = 8; }
                if (e.RowIndex < 3) { i = 0;k = 3; }
                else if (e.RowIndex < 6) { i = 3;k = 6; }
                else { i = 6;k = 9; }
                while (gode && i < k)
                {
                    if (dataGridView1.Rows[i].Cells[j - 2].Value != null)
                    {
                        if (dataGridView1.Rows[i].Cells[j - 2].Value.ToString() == val) { gode = false; }
                    }
                    if (dataGridView1.Rows[i].Cells[j - 1].Value != null)
                    {
                        if (dataGridView1.Rows[i].Cells[j - 1].Value.ToString() == val) { gode = false; }
                    }
                    if (dataGridView1.Rows[i].Cells[j].Value != null)
                    {
                        if (dataGridView1.Rows[i].Cells[j].Value.ToString() == val) { gode = false; }
                    }
                    i++;
                }
                dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = val;
                if (gode)
                {
                    if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.ForeColor == Color.Red) red--;
                    dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.ForeColor = Color.Black;
                    dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].ReadOnly = true;
                    mt--;
                }
                else
                {
                    dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.ForeColor = Color.Red;
                    red++;
                }
                if(mt == 0 && red == 0)
                {
                    MessageBox.Show("Gratulálok nyertél!");
                }
            }
        }
    }
}
