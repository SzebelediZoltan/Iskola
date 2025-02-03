using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2025_01_28_DatagridView
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Panel panel;

        private void Form1_Load(object sender, EventArgs e)
        {
            TablaFormazas();
        }

        private void TablaFormazas()
        {
            tablaDGV.RowHeadersVisible = false;
            tablaDGV.RowCount = 5;
            tablaDGV.ColumnCount = 4;

            int h = 30;
            int w = 100;

            AdatokElhelyezese();
            SormagassagBeallitasa(h);
            OsztlopSzelesseg(w);

            tablaDGV.Height = tablaDGV.RowCount * h + 3 + tablaDGV.ColumnHeadersHeight;
            tablaDGV.Width = tablaDGV.ColumnCount * w + 3;

        }

        private void AdatokElhelyezese()
        {
            Random r = new Random();
            for (int i = 0; i < tablaDGV.ColumnCount; i++)
                tablaDGV.Columns[i].HeaderText = "" + i;
            for (int j = 0; j < tablaDGV.RowCount; j++)
            {
                for (int i = 0; i < tablaDGV.ColumnCount; i++)
                    //tablaDGV.Rows[j].Cells[i].Value = j + ", " + i;
                    tablaDGV.Rows[j].Cells[i].Value = "" + r.Next(0,1000000);
            }
        }

        private void OsztlopSzelesseg(int w)
        {
            for (int i = 0; i < tablaDGV.ColumnCount; i++)
            {
                tablaDGV.Columns[i].Width = w;
                //tablaDGV.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
        }

        private void SormagassagBeallitasa(int h)
        {
            for (int i = 0; i < tablaDGV.RowCount; i++)
            {
                tablaDGV.Rows[i].Height = h;
            }
        }

        private void tablaDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //MessageBox.Show($"{tablaDGV.CurrentCell.RowIndex} {tablaDGV.CurrentCell.ColumnIndex}");
            ModositBtn.Visible = true;
            if (!Controls.Contains(panel))
                panel = NewPanelSettings();
            else
                panel.Controls.Clear();
            List<TextBox> texboxes = NewTexboxesSettings(tablaDGV.ColumnCount);
            int j = 0;
            texboxes.ForEach(c => {
                c.Text = ""+tablaDGV.Rows[tablaDGV.CurrentCell.RowIndex].Cells[j++].Value;
                panel.Controls.Add(c); });
            Controls.Add(panel);
        }

        private List<TextBox> NewTexboxesSettings(int columnCount)
        {
            List<TextBox> texboxes = new List<TextBox>();
            for (int i = 0; i < columnCount; i++)
            {
                TextBox txb = new TextBox();
                txb.Width = 125;
                txb.Height = 20;
                txb.Location = new Point(0, 25 * i);
                texboxes.Add(txb);
            }
            return texboxes;
        }

        private Panel NewPanelSettings()
        {
            panel = new Panel();
            panel.Location = new Point(12, 85);
            panel.Width = tablaDGV.Location.X-50;
            panel.Height = Height - 60;
            return panel;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            Controls.Remove(panel);
            ModositBtn.Visible = false;
            try
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    AdatokBetoltese(openFileDialog1.FileName);

                }
                else
                {
                    MessageBox.Show("Hiba történt a dialógus ablak megnyitása során!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hiba a program futtatása során! ", "Hiba!!!!");
                Console.WriteLine(ex.Message);
            }
        }

        private void AdatokBetoltese(string fileName)
        {
            string[] st = File.ReadAllLines(fileName);
            tablaDGV.RowCount = st.Length - 1;
            string[] sor = st[0].Split(';');
            tablaDGV.ColumnCount = sor.Length;

            for (int j = 0; j < sor.Length; j++)
                tablaDGV.Columns[j].HeaderCell.Value = sor[j];

            TablabaAdatBetoltes(st);
        }

        private void TablabaAdatBetoltes(string[] st)
        {
            for (int i = 1; i < st.Length; i++)
            {
                string[] sor = st[i].Split(';');
                for (int j = 0; j < sor.Length; j++)
                    tablaDGV.Rows[i - 1].Cells[j].Value = sor[j];
            }
        }

        private void ModositBtn_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < tablaDGV.ColumnCount; i++)
            {
                tablaDGV.Rows[tablaDGV.CurrentCell.RowIndex].Cells[i].Value = panel.Controls[i].Text;
            }
        }
    }
}
