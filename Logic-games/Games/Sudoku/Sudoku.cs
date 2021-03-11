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
using System.IO;
using System.Reflection;

namespace Logic_games
{
    public partial class Sudoku : Form
    {
        static bool kapcs = true;
        static int mt = 0;
        static int red = 0;
        static int[,] meg = new int[9, 9];
        public Sudoku()
        {
            InitializeComponent();
            dataGridView1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            richTextBox1.Visible = false;
        }


        static int[,] Fel()
        {
            int[,] meg = new int[9, 9];
            string pille = "megoldas";
            Random val = new Random();
            pille += Convert.ToString(val.Next(1, 4));
            try
            {
                 string con = "server=localhost;user=root;database=logicgames;password=''";
            MySqlConnection filo = new MySqlConnection(con);
            filo.Open();
            string ms = "SELECT * FROM " + pille + ";";
            MySqlCommand mc = new MySqlCommand(ms, filo);
            MySqlDataReader rdr = mc.ExecuteReader();
            int i = 0;
            while (rdr.Read())
            {
                for (int j = 0; j < 9; j++)
                {
                    meg[i, j] = Convert.ToInt32(rdr[j]);
                }
                i++;
            }
            filo.Close();
            }
            catch (Exception ex)
            {
                kapcs = false;
                var assembly = Assembly.GetExecutingAssembly();
                var resourceName = $"Logic_games.Resources.megoldas{pille}.txt";
                List<string> m = new List<string>();

                using (Stream stream = assembly.GetManifestResourceStream(resourceName))
                using (StreamReader reader = new StreamReader(stream))
                {
                    while (!reader.EndOfStream)
                    {
                        m.Add(reader.ReadLine());
                    }
                }
                for (int i = 0; i < m.Count; i++)
                {
                    string[] line = m[i].Split(' ');
                    for (int j = 0; j < 9; j++)
                    {
                        meg[i, j] = Convert.ToInt32(line[j]);
                    }
                }
            }
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
                while (gode && i < 9)
                {
                    if (dataGridView1.Rows[e.RowIndex].Cells[i].Value != null)
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
                if (e.RowIndex < 3) { i = 0; k = 3; }
                else if (e.RowIndex < 6) { i = 3; k = 6; }
                else { i = 6; k = 9; }
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
                    dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.ForeColor = Color.DarkBlue;
                    dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.Font = new Font("Times New Roman", 14F, FontStyle.Bold);
                    dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].ReadOnly = true;
                    mt--;
                }
                else
                {
                    dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.ForeColor = Color.Red;
                    label4.Text = Convert.ToString(Convert.ToInt32(label4.Text) + 1);
                    red++;
                }
                if (mt == 0 && red == 0)
                {
                    MessageBox.Show("Gratulálok nyertél!");
                    dataGridView1.Visible = false;
                    button2.Visible = false;
                    button3.Visible = true;
                    label1.Visible = false;
                    label2.Visible = false;
                    label3.Visible = false;
                    label4.Visible = false;
                }
            }
        }
       
        private void button1_Click(object sender, EventArgs e)
        {
            label5.Visible = true;
            richTextBox1.Visible = true;
            button4.Visible = true;
            button1.Visible = false;
            meg = Fel();
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
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
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
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label5.Visible = false;
            richTextBox1.Visible = false;
            button4.Visible = false;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.Columns[2].DividerWidth = 5;
            dataGridView1.Rows[2].DividerHeight = 5;
            dataGridView1.Columns[5].DividerWidth = 5;
            dataGridView1.Rows[5].DividerHeight = 5;
            dataGridView1.Visible = true;
            button2.Visible = true;
            button1.Visible = false;
            label1.Visible = true;
            label2.Text = (mt / 2).ToString();
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            label4.Text = "0";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (mt != 0 && label2.Text != "0")
            {
                Random v = new Random();
                int x = v.Next(0, 9);
                int y = v.Next(0, 9);
                while (dataGridView1.Rows[x].Cells[y].Value != null)
                {
                    x = v.Next(0, 9);
                    y = v.Next(0, 9);
                }
                dataGridView1.Rows[x].Cells[y].Value = meg[x, y];
                dataGridView1.Rows[x].Cells[y].Style.Font = new Font("Times New Roman", 14F, FontStyle.Bold);
                dataGridView1.Rows[x].Cells[y].ReadOnly = true;
                label2.Text = Convert.ToString(Convert.ToInt32(label2.Text) - 1);
                mt--;
                if (mt == 0 && red == 0)
                {
                    MessageBox.Show("Gratulálok nyertél!");
                    dataGridView1.Visible = false;
                    button2.Visible = false;
                    button3.Visible = true;
                    label1.Visible = false;
                    label2.Visible = false;
                    label3.Visible = false;
                    label4.Visible = false;
                }
            }
            else if (mt != 0)
            {
                MessageBox.Show("Sajnos elfogyott a segítség kéréseidnek a száma!");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label6.Visible = true;
            label6.Text = "";
            button4.Visible = false;
            int sc = Convert.ToInt32(label2.Text) * 100 - Convert.ToInt32(label4.Text) * 10;
            if (kapcs)
            {
                string con = "server=localhost;user=root;database=logicgames;password=''";
                MySqlConnection filo = new MySqlConnection(con);
                string cm = "INSERT INTO sudoku VALUES(" + richTextBox1.Text + ", " + sc + ")";
                List<string> rang = Illango(filo, cm);
                for(int i = 0; i < 3&& i < rang.Count; i++)
                {
                    label6.Text += (i+1) + ". helyezett: " + rang[i] + "\n";
                }
            }
            else
            {
                MessageBox.Show("Couldn't connect to server");
                label6.Text = "Játékos: " + richTextBox1.Text + "\nelértpontszáma: " + sc;
            }
        }

        static List<string> Illango(MySqlConnection filo, string cm)
        {
            List<string> val = new List<string>();
            filo.Open();
            string cmd = "SELECT * FROM sudoku ORDER BY 2 DESC;";
            MySqlCommand v = new MySqlCommand(cm, filo);
            MySqlDataReader f = v.ExecuteReader();
            f.Close();
            MySqlCommand k = new MySqlCommand(cmd, filo);
            MySqlDataReader n = k.ExecuteReader();
            while (n.Read())
            {
                val.Add(n[0] + " pontszáma: " + n[1]);
            }
            n.Close();
            filo.Close();
            return val;
        }
    }
}
