using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2024_04_25_DataGridview
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            TablaBeallitasok();
            TablaFeltoltese();
        }

        private void TablaFeltoltese()
        {
            for (int i = 1; i < dgvTabla.RowCount+1; i++)
            {
                for (int j = 1; j < dgvTabla.ColumnCount+1; j++)
                {
                    dgvTabla.Rows[i-1].Cells[j-1].Value = i * j;
                }
            }
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
    }
}
