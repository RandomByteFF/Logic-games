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
        static int[,] meg = new int[9, 9];
        public Sudoku()
        {
            InitializeComponent();
            meg = Fel();
            int[,] val = new int[9, 9];
            dataGridView1.DefaultCellStyle.SelectionBackColor = dataGridView1.DefaultCellStyle.BackColor;
            dataGridView1.DefaultCellStyle.SelectionForeColor = dataGridView1.DefaultCellStyle.ForeColor;
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
                    }
                    else
                    {
                        dataGridView1[j, i].ReadOnly = false;
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
            string con = "server=localhost;user=root;database=Sudoku;password=''";
            MySqlConnection filo = new MySqlConnection(con);
            filo.Open();
            string pille = "megoldas";
            Random val = new Random();
            pille += Convert.ToString(val.Next(1, 4));
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
                if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString() == meg[e.RowIndex,e.ColumnIndex].ToString())
                {
                    dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].ReadOnly = true;
                }
                else
                {
                    dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.ForeColor = Color.Red;
                }
            }
        }
    }
}
