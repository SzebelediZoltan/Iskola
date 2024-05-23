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

namespace Gyakorlás
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        static List<Adat> adatok = new List<Adat>();

        private void Form1_Load(object sender, EventArgs e)
        {

            Beolvasas();
            TablaBeallitasok();
        }

        private void Tablabair()
        {
            for (int i = 0; i < adatok.Count; i++)
            {
                dgvTabla.Rows[i].Cells[0].Value = adatok[i].korzet;
                dgvTabla.Rows[i].Cells[1].Value = adatok[i].szavazatok;
                dgvTabla.Rows[i].Cells[2].Value = adatok[i].nev;
                dgvTabla.Rows[i].Cells[3].Value = adatok[i].part;

            }
        }

        private void Beolvasas()
        {
            StreamReader fr = new StreamReader("szavazatok.txt");

            while (!fr.EndOfStream)
            {
                string[] sor = fr.ReadLine().Split(' ');
                Adat a = new Adat(Convert.ToInt32(sor[0]), Convert.ToInt32(sor[1]), sor[2], sor[3], sor[4]);
                adatok.Add(a);
            }
        }

        private void TablaBeallitasok()
        {
            dgvTabla.RowCount = adatok.Count;
            dgvTabla.ColumnCount = 4;
            dgvTabla.RowHeadersVisible = false;
            dgvTabla.Columns[0].HeaderText = "Körzet";
            dgvTabla.Columns[1].HeaderText = "Szavazatok";
            dgvTabla.Columns[2].HeaderText = "Név";
            dgvTabla.Columns[3].HeaderText = "Párt";

            Tablabair();
        }

        class Adat
        {
            public int korzet, szavazatok;
            public string nev, part;

            public Adat(int korzet, int szavazatok, string vez, string ker, string part)
            {
                this.korzet = korzet;
                this.szavazatok = szavazatok;
                this.nev = vez + " " + ker;
                if(part == "-")
                {
                    this.part = "Független";
                } else
                {
                    this.part = part;
                }
            }
        }

        private void dgvTabla_CurrentCellChanged(object sender, EventArgs e)
        {
            int sor = dgvTabla.CurrentCell.RowIndex;
            for (int i = 0; i < dgvTabla.ColumnCount; i++)
            {
                dgvTabla.Rows[sor].Cells[i].Selected = true;
            }

            Form2 from2 = new Form2(this);

        }
    }
}
