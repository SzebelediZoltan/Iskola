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

namespace Pizza_Rendeles
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            StreamReader fr = new StreamReader("pizzak.txt");

            while (!fr.EndOfStream)
            {
                cmb_pizza.Items.Add(fr.ReadLine());
            }

            fr.Close();

            cmb_pizza.SelectedIndex = 0;
        }

        static decimal osszeg = 0;
        private void btn_Felvetel_Click(object sender, EventArgs e)
        {
            string szoveg = cmb_pizza.Items[cmb_pizza.SelectedIndex] + " - ";

            string valasztott = "";
            if (rdb_kicsi.Checked)
            {
                szoveg += rdb_kicsi.Text;
                valasztott = rdb_kicsi.Text;
            } else if (rdb_normal.Checked)
            {
                szoveg += rdb_normal.Text;
                valasztott = rdb_normal.Text;
            } else if (rdb_nagy.Checked)
            {
                szoveg += rdb_nagy.Text;
                valasztott = rdb_nagy.Text;
            } else
            {
                MessageBox.Show("Nincs méret kiválasztva!");
                return;
            }

            szoveg += " x " + Convert.ToString(num_db.Value) + " = ";

            szoveg += PSzamolas(valasztott, num_db.Value) + " Ft";

            listBox1.Items.Add(szoveg);

            string extraSzoveg = "Extrák: ";

            int eOsszeg = 0;

            if (chb_hasab.Checked)
                eOsszeg += 600;
            if (chb_kolbasz.Checked)
                eOsszeg += 200;
            if (chb_sajt.Checked)
                eOsszeg += 500;
            if (chb_szosz.Checked)
                eOsszeg += 200;

            extraSzoveg += Convert.ToString(eOsszeg);
            osszeg += eOsszeg;
            listBox1.Items.Add(extraSzoveg + " Ft");
        }

        private void Kiiratas()
        {
            saveFileDialog1.InitialDirectory = "./";
            try
            {
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    StreamWriter fw = new StreamWriter(saveFileDialog1.FileName);
                    for (int i = 0; i < listBox1.Items.Count; i++)
                    {
                        fw.WriteLine(listBox1.Items[i]);
                    }
                    fw.Write("Összeg: " + osszeg);
                    fw.Close();
                }
            } catch
            {
                MessageBox.Show("Error!");
            }
        }

        static string PSzamolas(string valasztott, decimal szorzo)
        {
            string ar = valasztott.Split(' ')[4];
            osszeg += Convert.ToInt32(ar) * szorzo;

            return Convert.ToString(Convert.ToInt32(ar) * szorzo);
        }

        private void btn_rendeles_Click(object sender, EventArgs e)
        {
            MessageBox.Show("A teljes ár: " + Convert.ToString(osszeg) + " Ft");
            Kiiratas();
        }
    }
}
