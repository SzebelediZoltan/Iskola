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
            dtgSettings();
        }

        private void dtgSettings()
        {
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.MultiSelect = false;
            dataGridView1.AllowUserToOrderColumns = true;

            dataGridView2.RowHeadersVisible = false;
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView2.AllowUserToResizeColumns = false;
            dataGridView2.AllowUserToResizeRows = false;
            dataGridView2.AllowUserToOrderColumns = true;
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

            SortableBindingList<Nagydij> ds = new SortableBindingList<Nagydij>();

            foreach (Nagydij item in Adatkezeles.palyaKivalasztas(Adatkezeles.szezon(Adatkezeles.nagydijak, Convert.ToInt32(menuItem.OwnerItem.Text)), menuItem.Text))
            {
                ds.Add(item);
            }

            dataGridView1.DataSource = ds;
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

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.SelectedCells[0].OwningColumn.HeaderText == "Pilota")
            {
                NevKiir(Convert.ToString(dataGridView1.SelectedCells[0].Value));
            }
            else if (dataGridView1.SelectedCells[0].OwningColumn.HeaderText == "Csapat")
            {
                CsapatKiir(Convert.ToString(dataGridView1.SelectedCells[0].Value));
            }
        }

        private void CsapatKiir(string nev)
        {

            SortableBindingList<Csapat> ds = new SortableBindingList<Csapat>();

            ds.Add(Adatkezeles.csapatok.Find(x => x.nev == nev));

            Adatkezeles.autok = Adatkezeles.autok;

            dataGridView2.DataSource = ds;
        }

        private void NevKiir(string nev)
        {

            SortableBindingList<Versenyzo> ds = new SortableBindingList<Versenyzo>();

            ds.Add(Adatkezeles.versenyzok.Find(x => x.nev == nev));

            dataGridView2.DataSource = ds;
        }

        private void AutoKiir(string nev)
        {
            SortableBindingList<Auto> ds = new SortableBindingList<Auto>();

            ds.Add(Adatkezeles.autok.Find(x => x.nev == nev));

            dataGridView2.DataSource = ds;
        }

        private void KorKiir(int kor)
        {
            SortableBindingList<Versenyzo> ds = new SortableBindingList<Versenyzo>();

            foreach (Versenyzo item in Adatkezeles.korKivalasztas(Adatkezeles.versenyzok, kor))
            {
                ds.Add(item);
            }

            dataGridView2.DataSource = ds;
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string hdText = dataGridView2.SelectedCells[0].OwningColumn.HeaderText;

            if (hdText == "Pilota_1" || hdText == "Pilota_2")
            {
                NevKiir(Convert.ToString(dataGridView2.SelectedCells[0].Value));
            }
            else if (hdText == "Auto_1" || hdText == "Auto_2")
            {
                AutoKiir(Convert.ToString(dataGridView2.SelectedCells[0].Value));
            }
            else if (hdText == "Csapat")
            {
                CsapatKiir(Convert.ToString(dataGridView2.SelectedCells[0].Value));
            } else if (hdText == "Kor")
            {
                KorKiir(Convert.ToInt32(dataGridView2.SelectedCells[0].Value));
            }
        }
    }
}
