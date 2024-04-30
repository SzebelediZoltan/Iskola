using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Rejtveny
{
    public partial class Form1 : Form
    {
        static int lepes = 0;
        static List<Megoldas> megoldasok = new List<Megoldas>();
        public Form1()
        {
            InitializeComponent();
        }

        private void TablaBeallitasok()
        {
            dgvTabla.RowCount = 10;
            dgvTabla.ColumnCount = 10;
            dgvTabla.ColumnHeadersVisible = false;
            dgvTabla.RowHeadersVisible = false;
            const int x = 50;
            SzelessegBeallitasa(x);
            dgvTabla.Width = dgvTabla.ColumnCount * x + 3;
            dgvTabla.Height = dgvTabla.RowCount * x + 3;
        }

        private void SzelessegBeallitasa(int x)
        {
            for (int i = 0; i < dgvTabla.ColumnCount; i++)
            {
                dgvTabla.Columns[i].Width = x;
            }
            for (int i = 0; i < dgvTabla.RowCount; i++)
            {
                dgvTabla.Rows[i].Height = x;
            }
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            TablaBeallitasok();
            Beolvasas();
            GridBeallitas();
            btnElozo.Enabled = false;
        }

        private void GridBeallitas()
        {
            lblNev.Text = megoldasok[lepes].nev;
            for (int i = 0; i < dgvTabla.RowCount; i++)
            {
                for (int j = 0; j < dgvTabla.ColumnCount; j++)
                {
                    dgvTabla.Rows[i].Cells[j].Value = megoldasok[lepes].matrix[i][j];
                }
            }
        }

        private void Beolvasas()
        {
            StreamReader fr = new StreamReader("megoldas.txt");
            while(!fr.EndOfStream)
            {
                string nev = fr.ReadLine();
                List<List<int>> matrix = MatrixOlvas(fr);
                Megoldas v = new Megoldas(nev, matrix);
                megoldasok.Add(v);
            }
        }

        private List<List<int>> MatrixOlvas(StreamReader fr)
        {
            List<List<int>> matrix = new List<List<int>>();
            for (int i = 0; i < 10; i++)
            {
                matrix.Add(new List<int>());
                string[] sor = fr.ReadLine().Split(' ');
                for (int j = 0; j < 10; j++)
                {
                    matrix[i].Add(Convert.ToInt32(sor[j]));
                }
            }

            return matrix;
        }

        class Megoldas
        {
            public string nev;
            public List<List<int>> matrix;

            public Megoldas(string nev, List<List<int>> matrix)
            {
                this.nev = nev;
                this.matrix = matrix;
            }
        }

        private void btnElozo_Click(object sender, EventArgs e)
        {
            lepes -= 1;
            GridBeallitas();
            if(lepes == 0)
            {
                btnElozo.Enabled = false;
            }
            if (lepes != megoldasok.Count - 1)
            {
                btnKovetkezo.Enabled = true;
            }
        }

        private void btnKovetkezo_Click(object sender, EventArgs e)
        {
            lepes += 1;
            GridBeallitas();
            if (lepes == megoldasok.Count-1)
            {
                btnKovetkezo.Enabled = false;
            }
            if (lepes != 0)
            {
                btnElozo.Enabled = true;
            }
        }
    }
}
