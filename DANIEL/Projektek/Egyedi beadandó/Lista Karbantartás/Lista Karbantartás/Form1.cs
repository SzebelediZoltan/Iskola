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

        private void balTiltas()
        {
            listBox1.ClearSelected();
            jobbra.Enabled = false;
            torol1.Enabled = false;
            le1.Enabled = false;
            alulra1.Enabled = false;
            fel1.Enabled = false;
            felulre1.Enabled = false;
        }

        private void jobbTiltas()
        {
            listBox2.ClearSelected();
            balra.Enabled = false;
            torol2.Enabled = false;
            le2.Enabled = false;
            alulra2.Enabled = false;
            fel2.Enabled = false;
            felulre2.Enabled = false;
        }
        private void hozzaad1_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2(listBox1);
            f2.Show();
            balTiltas();
        }

        private void hozzaad2_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2(listBox2);
            f2.Show();
            jobbTiltas();
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            Check(2);
        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Check(1);
        }
        
        private void Check(int x)
        {
            if (x == 2)
            {
                if (listBox2.Items.Count == 1)
                {
                    le2.Enabled = false;
                    alulra2.Enabled = false;
                    fel2.Enabled = false;
                    felulre2.Enabled = false;
                }
                else if (listBox2.SelectedIndex == 0)
                {
                    le2.Enabled = true;
                    alulra2.Enabled = true;
                    fel2.Enabled = false;
                    felulre2.Enabled = false;
                }
                else if (listBox2.SelectedIndex == listBox2.Items.Count - 1)
                {
                    le2.Enabled = false;
                    alulra2.Enabled = false;
                    fel2.Enabled = true;
                    felulre2.Enabled = true;
                }
                else
                {
                    le2.Enabled = true;
                    alulra2.Enabled = true;
                    fel2.Enabled = true;
                    felulre2.Enabled = true;
                }

                balra.Enabled = true;
                torol2.Enabled = true;
            } else if (x == 1)
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

                jobbra.Enabled = true;
                torol1.Enabled = true;
            }
        }

        private void torol1_Click(object sender, EventArgs e)
        {
            listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            balTiltas();
        }

        private void torol2_Click(object sender, EventArgs e)
        {
            listBox2.Items.RemoveAt(listBox2.SelectedIndex);
            jobbTiltas();
        }

        private void felulre2_Click(object sender, EventArgs e)
        {
            Felulre(listBox2);
        }

        private void fel2_Click(object sender, EventArgs e)
        {
            Fel(listBox2);
        }

        private void Felulre(ListBox listBox)
        {
            string tmp = "" + listBox.Items[listBox.SelectedIndex];
            listBox.Items[listBox.SelectedIndex] = listBox.Items[0];
            listBox.Items[0] = tmp;
            listBox.SelectedIndex = 0;
        }

        private void Fel(ListBox listBox)
        {
            string tmp = "" + listBox.Items[listBox.SelectedIndex];
            listBox2.Items[listBox.SelectedIndex] = listBox2.Items[listBox.SelectedIndex-1];
            listBox2.Items[listBox.SelectedIndex-1] = tmp;
            listBox2.SelectedIndex = listBox2.SelectedIndex-1;
        }

        private void Le(ListBox listBox)
        {
            string tmp = "" + listBox.Items[listBox.SelectedIndex];
            listBox2.Items[listBox.SelectedIndex] = listBox2.Items[listBox.SelectedIndex + 1];
            listBox2.Items[listBox.SelectedIndex + 1] = tmp;
            listBox2.SelectedIndex = listBox2.SelectedIndex + 1;
        }

        private void Alulra(ListBox listBox)
        {
            string tmp = "" + listBox.Items[listBox.SelectedIndex];
            listBox.Items[listBox.SelectedIndex] = listBox.Items[listBox.Items.Count-1];
            listBox.Items[listBox.Items.Count - 1] = tmp;
            listBox.SelectedIndex = listBox.Items.Count - 1;
        }

        private void le2_Click(object sender, EventArgs e)
        {
            Le(listBox2);
        }

        private void alulra2_Click(object sender, EventArgs e)
        {
            Alulra(listBox2);
        }
    }
}
