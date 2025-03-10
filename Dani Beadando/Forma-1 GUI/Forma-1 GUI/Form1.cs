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
            FőDGV.RowHeadersVisible = false;
            FőDGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            FőDGV.SelectionMode = DataGridViewSelectionMode.CellSelect;
            FőDGV.AllowUserToResizeColumns = false;
            FőDGV.AllowUserToResizeRows = false;
            FőDGV.MultiSelect = false;
            FőDGV.AllowUserToOrderColumns = true;

            SortedDGV.RowHeadersVisible = false;
            SortedDGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            SortedDGV.AllowUserToResizeColumns = false;
            SortedDGV.AllowUserToResizeRows = false;
            SortedDGV.AllowUserToOrderColumns = true;
        }

        private void GenerateHeader()
        {
            List<int> evek = Adatkezeles.evek(Adatkezeles.nagydijak);

            foreach (var ev in evek)
            {
                ToolStripMenuItem evToolBoxItem = new ToolStripMenuItem();
                evToolBoxItem.Text = ev.ToString();
                evToolBoxItem.ForeColor = Color.White;
                evToolBoxItem.DropDownOpened += sotetites;
                evToolBoxItem.DropDownClosed += vilagositas;

                foreach (var nagydij in Adatkezeles.nagydijNevek(Adatkezeles.nagydijak, ev))
                {
                    ToolStripMenuItem palyaToolBoxItem = new ToolStripMenuItem();
                    palyaToolBoxItem.Text = nagydij;
                    palyaToolBoxItem.Click += kiIras;
                    evToolBoxItem.DropDownItems.Add(palyaToolBoxItem);
                }
                menuStrip1.Items.Add(evToolBoxItem);
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

            FőDGV.DataSource = ds;
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
                if(Adatkezeles.BeolvasasNagy(openFileDialog1.FileName) == true)
                {
                    ToolStripItem c = menuStrip1.Items[0];
                    menuStrip1.Items.Clear();
                    menuStrip1.Items.Add(c);
                    GenerateHeader();
                } else
                {
                    MessageBox.Show("Nem megfelelő a fájl", "Hiba!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (FőDGV.SelectedCells[0].OwningColumn.HeaderText == "Pilota")
            {
                NevKiir(Convert.ToString(FőDGV.SelectedCells[0].Value));
            }
            else if (FőDGV.SelectedCells[0].OwningColumn.HeaderText == "Csapat")
            {
                CsapatKiir(Convert.ToString(FőDGV.SelectedCells[0].Value));
            }

        }

        private void CsapatKiir(string nev)
        {

            SortableBindingList<Csapat> ds = new SortableBindingList<Csapat>();

            ds.Add(Adatkezeles.csapatok.Find(x => x.nev == nev));

            SortedDGV.DataSource = ds;
        }

        private void NevKiir(string nev)
        {

            SortableBindingList<Versenyzo> ds = new SortableBindingList<Versenyzo>();

            ds.Add(Adatkezeles.versenyzok.Find(x => x.nev == nev));

            SortedDGV.DataSource = ds;
        }

        private void AutoKiir(string nev)
        {
            SortableBindingList<Auto> ds = new SortableBindingList<Auto>();

            ds.Add(Adatkezeles.autok.Find(x => x.nev == nev));

            SortedDGV.DataSource = ds;
        }

        private void KorKiir(int kor)
        {
            SortableBindingList<Versenyzo> ds = new SortableBindingList<Versenyzo>();

            foreach (Versenyzo item in Adatkezeles.korKivalasztas(Adatkezeles.versenyzok, kor))
            {
                ds.Add(item);
            }

            SortedDGV.DataSource = ds;
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string hdText = SortedDGV.SelectedCells[0].OwningColumn.HeaderText;

            if (hdText == "Pilota_1" || hdText == "Pilota_2")
            {
                NevKiir(Convert.ToString(SortedDGV.SelectedCells[0].Value));
            }
            else if (hdText == "Auto_1" || hdText == "Auto_2")
            {
                AutoKiir(Convert.ToString(SortedDGV.SelectedCells[0].Value));
            }
            else if (hdText == "Csapat")
            {
                CsapatKiir(Convert.ToString(SortedDGV.SelectedCells[0].Value));
            } else if (hdText == "Kor")
            {
                KorKiir(Convert.ToInt32(SortedDGV.SelectedCells[0].Value));
            }
        }
    }
}
