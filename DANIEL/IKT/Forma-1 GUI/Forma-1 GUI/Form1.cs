using Formula_1_Projekt;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forma_1_GUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void GenerateHeader()
        {
            List<int> evek = Adatkezeles.evek(Adatkezeles.nagydijak);

            foreach (var ev in evek)
            {
                ToolStripMenuItem nag = new ToolStripMenuItem();
                nag.Text = ev.ToString();
                nag.ForeColor = Color.White;
                nag.DropDownOpened += sotetites;
                nag.DropDownClosed += vilagositas;

                foreach (var nagydij in Adatkezeles.nagydijNevek(Adatkezeles.nagydijak, ev))
                {
                    ToolStripMenuItem nig = new ToolStripMenuItem();
                    nig.Text = nagydij;
                    nig.Click += kiIras;
                    nag.DropDownItems.Add(nig);
                }
                menuStrip1.Items.Add(nag);
            }
        }

        private void kiIras(object sender, EventArgs e)
        {
            var menuItem = sender as ToolStripMenuItem;

            var ds = new BindingList<Nagydij>();
            dataGridView1.DataSource = ds;

            foreach ( Nagydij item in Adatkezeles.palyaKivalasztas(Adatkezeles.szezon(Adatkezeles.nagydijak, 2023), "Brit"))
            {
                ds.Add(item);
            }
        }

        private void vilagositas(object sender, EventArgs e)
        {
            var menuItem = sender as ToolStripMenuItem;
            menuItem.ForeColor = Color.White;
        }

        private void sotetites(object sender, EventArgs e)
        {
            var menuItem = sender as ToolStripMenuItem;
            menuItem.ForeColor = Color.Black;
        }

        private void openFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Adatkezeles.BeolvasasNagy(openFileDialog1.FileName);
                GenerateHeader();
            }
        }
    }
}
