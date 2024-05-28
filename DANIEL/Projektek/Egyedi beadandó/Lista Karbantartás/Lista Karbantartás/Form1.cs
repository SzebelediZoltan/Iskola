using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lista_Karbantartás
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            balTiltas();
            jobbTiltas();
        }

        private void jobbTiltas()
        {
            torol1.Enabled = false;
            jobbra.Enabled = false;
            alulra1.Enabled = false;
            le1.Enabled = false;
            fel1.Enabled = false;
            felulre1.Enabled = false;
        }

        private void balTiltas()
        {
            torol2.Enabled = false;
            balra.Enabled = false;
            alulra2.Enabled = false;
            le2.Enabled = false;
            fel2.Enabled = false;
            felulre2.Enabled = false;
        }
        private void hozzaad1_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2(listBox1);
            f2.Show();
            listBox2.ClearSelected();
            jobbra.Enabled = false;
            torol2.Enabled = false;
            le1.Enabled = false;
            alulra1.Enabled = false;
            fel1.Enabled = false;
            felulre1.Enabled = false;
        }

        private void hozzaad2_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2(listBox2);
            f2.Show();
            listBox2.ClearSelected();
            balra.Enabled = false;
            torol2.Enabled = false;
            le2.Enabled = false;
            alulra2.Enabled = false;
            fel2.Enabled = false;
            felulre2.Enabled = false;
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox2.Items.Count == 1)
            {
                le2.Enabled = false;
                alulra2.Enabled = false;
                fel2.Enabled = false;
                felulre2.Enabled = false;
            } else if (listBox2.SelectedIndex == 0)
            {
                le2.Enabled = true;
                alulra2.Enabled = true;
                fel2.Enabled = false;
                felulre2.Enabled = false;
            } else if (listBox2.SelectedIndex == listBox2.Items.Count - 1)
            {
                le2.Enabled = false;
                alulra2.Enabled = false;
                fel2.Enabled = true;
                felulre2.Enabled = true;
            } else
            {
                le2.Enabled = true;
                alulra2.Enabled = true;
                fel2.Enabled = true;
                felulre2.Enabled = true;
            }

            balra.Enabled = true;
            torol2.Enabled = true;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.Items.Count == 1)
            {
                le1.Enabled = false;
                alulra1.Enabled = false;
                fel1.Enabled = false;
                felulre1.Enabled = false;
            }
            else if (listBox1.SelectedIndex == 0)
            {
                le1.Enabled = true;
                alulra1.Enabled = true;
                fel1.Enabled = false;
                felulre1.Enabled = false;
            }
            else if (listBox1.SelectedIndex == listBox1.Items.Count - 1)
            {
                le1.Enabled = false;
                alulra1.Enabled = false;
                fel1.Enabled = true;
                felulre1.Enabled = true;
            }
            else
            {
                le1.Enabled = true;
                alulra1.Enabled = true;
                fel1.Enabled = true;
                felulre1.Enabled = true;
            }

            if (listBox1.SelectedIndex == 0)
            {
                balra.Enabled = true;
            }

            balra.Enabled = true;
            torol1.Enabled = true;
        }
    }
}
